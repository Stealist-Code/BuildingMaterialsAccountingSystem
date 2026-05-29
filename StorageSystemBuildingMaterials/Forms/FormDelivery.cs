using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using StorageSystemBuildingMaterials.Properties;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма для оформления поставок
    /// </summary>
    public partial class FormDelivery : Form
    {
        private readonly IProductService _productService;
        private readonly IShipmentService _shipmentService;
        private readonly IDiscountService _discountService;
        private readonly ICurrencyService _currencyService;
        private readonly CurrencyState _currencyState;
        private readonly Guid _userId;

        public FormDelivery(IProductService productService, 
                            IShipmentService shipmentService,
                            IDiscountService discountService, 
                            ICurrencyService currencyService,
                            CurrencyState currencyState, 
                            Guid userId)
        {
            InitializeComponent();

            _productService = productService;
            _shipmentService = shipmentService;
            _userId = userId;
            _discountService = discountService;
            _currencyService = currencyService;
            _currencyState = currencyState;
            ApplyLocalization();

            this.Load += async (s, e) => await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var products = await _productService.GetProducts();

            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "Id";
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "JSON (*.json)|*.json"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                var json = File.ReadAllText(ofd.FileName);

                var imports = JsonConvert.DeserializeObject<List<ShipmentImportDto>>(json);

                if (imports is null || !imports.Any())
                {
                    MessageBox.Show(Resources.JsonEmpty);
                    return;
                }

                var products = await _productService.GetProducts();
                var rate = await _currencyService.GetRate(_currencyState.SelectedCurrency);

                var supplyItems = new List<SupplyItem>();

                foreach (var item in imports)
                {
                    if (string.IsNullOrWhiteSpace(item.ProductName))
                    {
                        MessageBox.Show(Resources.NoProductName);
                        return;
                    }

                    var product = products.FirstOrDefault(p =>
                        string.Equals(p.Name, item.ProductName, StringComparison.OrdinalIgnoreCase));

                    if (product is null)
                    {
                        throw new Exception(Resources.ProductNotFound);
                    }

                    if (item.Quantity <= 0)
                    {
                        throw new Exception(Resources.QuantityZero);
                    }

                    if (item.ExpirationDate == default)
                    {
                        throw new Exception(Resources.NoExpirationDate);
                    }

                    var productState = await _discountService.CreateProductState();

                    var priceInRUB = item.Price * rate;

                    supplyItems.Add(new SupplyItem
                    {
                        Id = Guid.NewGuid(),
                        ProductId = product.Id,
                        Quantity = item.Quantity,
                        CurrentStock = item.Quantity,
                        PurchasePrice = priceInRUB,
                        PurchasePriceOnDayPurchace = priceInRUB,
                        ExchangeRateOnDayPurchace = rate,
                        Currency = _currencyState.SelectedCurrency,
                        ExpirationDate = DateTime.SpecifyKind(item.ExpirationDate, DateTimeKind.Utc),
                        ReceivedDate = DateTime.UtcNow,
                        ProductState = productState,
                        ProductStateId = productState.Id
                    });
                }

                await _shipmentService.CreateSupply(
                    _userId,
                    new Address
                    {
                        Country = "Россия",
                        Region = "Татарстан",
                        City = "Казань",
                        Street = "Склад",
                        Building = "1"
                    },
                    supplyItems
                );

                MessageBox.Show(Resources.SupplySuccess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var productId = (Guid)cbProducts.SelectedValue;
                var quantity = (int)nudQuantity.Value;
                var purchasePrice = (decimal)nudPrice.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show(Resources.QuantityZero);
                    return;
                }

                var productState = await _discountService.CreateProductState();
                var rate = await _currencyService.GetRate(_currencyState.SelectedCurrency);
                var priceInRUB = purchasePrice * rate;

                var supplyItems = new List<SupplyItem>
                {
                    new SupplyItem
                    {
                        Id = Guid.NewGuid(),
                        ProductId = productId,
                        Quantity = quantity,
                        CurrentStock = quantity,
                        PurchasePrice = priceInRUB,
                        PurchasePriceOnDayPurchace = priceInRUB,
                        ExchangeRateOnDayPurchace = rate,
                        Currency = _currencyState.SelectedCurrency,
                        ExpirationDate = DateTime.SpecifyKind(dtpExpirationDate.Value, DateTimeKind.Utc),
                        ReceivedDate = DateTime.UtcNow,
                        ProductState = productState,
                        ProductStateId = productState.Id
                    }
                };

                await _shipmentService.CreateSupply(
                    _userId,
                    new Address
                    {
                        Country = "Россия",
                        Region = "Татарстан",
                        City = "Казань",
                        Street = "Склад",
                        Building = "1"
                    },
                    supplyItems
                );

                MessageBox.Show(Resources.SupplySuccess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.Supplies;

            labelDelivery.Text = Resources.CreateSupply;
            labelProduct.Text = Resources.Product;
            labelExpirationDate.Text = Resources.ExpirationDate;
            labelAmount.Text = Resources.Amount;
            labelPurchasePrice.Text = $"{Resources.PurchasePrice} ({_currencyState.SelectedCurrency})";
            btnUpload.Text = Resources.Upload;
            labelUploadFile.Text = Resources.UploadFile;
            btnCancel.Text = Resources.Cancel;
            btnCreate.Text = Resources.Create;
        }
    }
}
