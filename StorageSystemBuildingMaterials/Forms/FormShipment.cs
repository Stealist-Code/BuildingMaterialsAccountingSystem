using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Forms.Interfaces;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Forms
{
    public partial class FormShipment : Form, ILocalizable
    {
        private readonly IProductService _productService;
        private readonly IShipmentService _shipmentService;
        private readonly IShipmentValidation _shipmentValidation;
        private readonly Guid _userId;
        private List<CartItemDto> cart = new List<CartItemDto>();

        public FormShipment(Guid currentUserId, IProductService productService, IShipmentService shipmentService, IShipmentValidation shipmentValidation)
        {
            InitializeComponent();

            _userId = currentUserId;
            _productService = productService;
            _shipmentService = shipmentService;
            _shipmentValidation = shipmentValidation;

            this.Text = Resources.CreateShipment;
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAdd.Click += btnAdd_Click;
            btnCreate.Click += btnCreate_Click;
            Load += async (s, e) => await LoadProducts();
            SetupCartGrid();
        }

        private async Task LoadProducts()
        {
            var products = await _productService.GetProducts();

            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "Id";
        }

        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ProductName", Resources.Product);
            dgvCart.Columns.Add("Quantity", Resources.Quantity);
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshCart()
        {
            dgvCart.Rows.Clear();

            foreach (var item in cart)
            {
                dgvCart.Rows.Add(item.ProductName, item.Quantity);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem is null)
            {
                MessageBox.Show(Resources.UnknownError);
                return;
            }

            var product = cbProduct.SelectedItem as ProductDto;
            int quantity = (int)nudQuantity.Value;
            var existing = cart.FirstOrDefault(i => i.ProductId == product?.Id);

            try
            {
                _shipmentValidation.ValidateAddToCart(product, quantity, existing);

                if (existing is not null)
                {
                    existing.Quantity += quantity;
                }
                else
                {
                    cart.Add(new CartItemDto
                    {
                        ProductId = product.Id,
                        ProductName = product.Name,
                        Quantity = quantity,
                        Stock = product.CurrentStock
                    });
                }

                RefreshCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message) ?? ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow is null)
            {
                MessageBox.Show(Resources.UnknownError);
                return;
            }


            try
            {
                int idx = dgvCart.CurrentRow.Index;

                if (idx >= 0 && idx < cart.Count)
                {
                    cart.RemoveAt(idx);
                    RefreshCart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message) ?? ex.Message);
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var address = new Address
                {
                    Id = Guid.NewGuid(),
                    Country = txtCountry.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Region = txtRegion.Text.Trim(),
                    Street = txtStreet.Text.Trim(),
                    Building = txtBuilding.Text.Trim()
                };

                var totalPrice = nudTotalPrice.Value;

                _shipmentValidation.ValidateShipmentFields(address, cart);



                var shipmentItems = cart.Select(c => new ShipmentItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = c.ProductId,
                    Quantity = c.Quantity,
                    
                }).ToList();

                var customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    MiddleName = txtMiddleName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                };

                await _shipmentService.CreateShipment(
                    _userId,
                    address,
                    customer,
                    shipmentItems,
                    totalPrice
                );

                MessageBox.Show(Resources.ShipmentCreated);
                Close();
            }
            catch (Exception ex)
            {
                var errorText = Resources.ResourceManager.GetString(ex.Message) ?? ex.Message;
                MessageBox.Show(errorText);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.CreateShipment;

            btnAdd.Text = Resources.Add;
            btnCreate.Text = Resources.Create;

            labelTextVisualCountry.Text = Resources.Country;
            labelTextVisualRegion.Text = Resources.Region;
            labelTextVisualCity.Text = Resources.City;
            labelTextVisualStreet.Text = Resources.Street;
            labelTextVisualBuilding.Text = Resources.Building;
            labelTextVisualProduct.Text = Resources.Product;
            labelTextVisualCountProduct.Text = Resources.Amount;
            labelTextVisualLastName.Text = Resources.LastName;
            labelTextVisualFirstName.Text = Resources.FirstName;
            labelTextVisualMiddleName.Text = Resources.MiddleName;
            labelTextVisualEmail.Text = Resources.Email;
            labelTextVisualPrice.Text = Resources.Price;
            labelTextVisualSelling.Text = Resources.Selling;
            labelTextVisualShipment.Text = Resources.CreatingShipment;
            labelPositions.Text = Resources.Positions;

            dgvCart.Columns[0].HeaderText = Resources.Product;
            dgvCart.Columns[1].HeaderText = Resources.Quantity;
        }

        private void FormShipment_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }
    }
}