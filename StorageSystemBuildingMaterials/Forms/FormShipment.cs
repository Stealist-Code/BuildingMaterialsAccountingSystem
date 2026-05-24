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
        private readonly Guid _addressId;
        private readonly Guid _customerId;
        private readonly string _tIN;
        private readonly Form _formCheckTin;
        private List<CartItemDto> cart = new List<CartItemDto>();

        public FormShipment(Guid currentUserId, IProductService productService, IShipmentService shipmentService, IShipmentValidation shipmentValidation, Customer customer, Form formCheckTin)
        {
            InitializeComponent();

            _userId = currentUserId;
            _productService = productService;
            _shipmentService = shipmentService;
            _shipmentValidation = shipmentValidation;
            _customerId = customer.Id;
            _tIN = customer.TIN;
            _addressId = customer.Address.Id;
            _formCheckTin = formCheckTin;

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

            textBoxTIN.Text = _tIN;
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
                var totalPrice = nudTotalPrice.Value;

                var shipmentItems = cart.Select(c => new ShipmentItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = c.ProductId,
                    Quantity = c.Quantity,

                }).ToList();

                await _shipmentService.CreateShipment(
                    _userId,
                    _addressId,
                    _customerId,
                    shipmentItems,
                    totalPrice
                );

                MessageBox.Show(Resources.ShipmentCreated);
                if (_formCheckTin != null)
                {
                    _formCheckTin.Close();
                }
                Close();
            }
            catch (Exception ex)
            {
                var errorText = Resources.ResourceManager.GetString(ex.Message) ?? ex.Message;
                MessageBox.Show(errorText);
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.CreateShipment;

            btnAdd.Text = Resources.Add;
            btnCreate.Text = Resources.Create;

            labelTextVisualProduct.Text = Resources.Product;
            labelTextVisualCountProduct.Text = Resources.Amount;
            labelTextVisualPrice.Text = Resources.Price;
            labelTextVisualShipment.Text = Resources.CreatingShipment;
            labelPositions.Text = Resources.Positions;

            dgvCart.Columns[0].HeaderText = Resources.Product;
            dgvCart.Columns[1].HeaderText = Resources.Quantity;
        }

        private void FormShipment_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}