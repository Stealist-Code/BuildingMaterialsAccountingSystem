using StorageSystemBuildingMaterials.Controls;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Enums;
using StorageSystemBuildingMaterials.Forms.Interfaces;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;
using System.Windows.Forms;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Класс формы
    /// </summary>
    public partial class FormMain : Form, ILocalizable
    {
        private readonly User _user;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IShipmentValidation _shipmentValidation;
        private readonly IReportService _reportService;
        private readonly IShipmentService _shipmentService;
        private readonly IUserService _userService;
        private readonly ICurrencyService _currencyService;
        private readonly ISupplyService _supplyService;
        private readonly IDiscountService _discountService;
        private readonly ITINService _tINService;
        private readonly IWeatherService _weatherService;
        private readonly IConfigurationAppService _configurationAppService;
        private readonly Func<FormLogin> _loginForm;
        private readonly CurrencyState _currencyState;

        private readonly BindingSource _bindingSource = new BindingSource();
        private Dictionary<string, Guid> _categoryIds;

        public FormMain(User user,
                        ICategoryService categoryService,
                        IProductService productService,
                        IShipmentService shipmentService,
                        IShipmentValidation shipmentValidation,
                        IUserService userService,
                        IReportService reportService,
                        Func<FormLogin> loginForm,
                        CurrencyState currencyState,
                        ICurrencyService currencyService,
                        ISupplyService supplyService,
                        IDiscountService discountService,
                        ITINService tINService,
                        IWeatherService weatherService,
                        IConfigurationAppService configurationAppService)
        {
            InitializeComponent();

            _user = user;
            _categoryService = categoryService;
            _productService = productService;
            _shipmentValidation = shipmentValidation;
            _shipmentService = shipmentService;
            _userService = userService;
            _loginForm = loginForm;
            _reportService = reportService;
            _currencyState = currencyState;
            _currencyService = currencyService;
            _supplyService = supplyService;
            _discountService = discountService;
            _tINService = tINService;
            _weatherService = weatherService;
            _configurationAppService = configurationAppService;

            if (!Enum.TryParse(user.Role.Title, out Roles _role))
            {
                return;
            }

            buttonAdmin.Visible = _role == Roles.Admin;

            SetupDataGridView();

            this.Load += FormMain_Load;
            SubscribeButtons();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await LoadCategories();
            await LoadAllProducts();
            ApplyLocalization();
        }

        /// <summary>
        /// Загружает категории
        /// </summary>
        private async Task LoadCategories()
        {
            var categories = await _categoryService.GetAllCategories();

            _categoryIds = categories.ToDictionary(c => c.Name, c => c.Id);

            LoadCategoryButtons(categories);
        }

        /// <summary>
        /// Загрузка всех товаров
        /// </summary>
        private async Task LoadAllProducts()
        {
            try
            {
                var products = await _supplyService.GetActualProducts();

                ApplyCurrency(products);

                _bindingSource.DataSource = products;
                dgvProducts.Columns["Id"].Visible = false;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["Article"].HeaderText = Resources.Article;
                dgvProducts.Columns["Name"].HeaderText = Resources.Name;
                dgvProducts.Columns["CategoryName"].HeaderText = Resources.CategoryName;
                dgvProducts.Columns["Unit"].HeaderText = Resources.Unit;
                dgvProducts.Columns["PurchasePrice"].HeaderText = $"{Resources.PurchasePrice} ({_currencyState.SelectedCurrency})";
                dgvProducts.Columns["CurrentStock"].HeaderText = Resources.CurrentStock;
                dgvProducts.Columns["ReceivedDate"].HeaderText = Resources.ReceivedDate;
                dgvProducts.Columns["DaysLeft"].HeaderText = Resources.DaysLeft;
                dgvProducts.Columns["ExpirationDate"].Visible = false;
                dgvProducts.Columns["Insurance"].Visible = false;
                dgvProducts.Columns["ThermalContainer"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        /// <summary>
        /// Метод для обновления данных товаров
        /// </summary>
        public async void RefreshData()
        {
            await LoadAllProducts();
        }

        /// <summary>
        /// Создаёт кнопки категорий
        /// </summary>
        private void LoadCategoryButtons(List<Category> categories)
        {
            pnlCategories.Controls.Clear();

            int y = 5;

            foreach (var cat in categories)
            {
                var btn = new Button
                {
                    Text = cat.Name,
                    Tag = cat.Id,
                    Width = pnlCategories.Width - 10,
                    Height = 35,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(5),
                    BackColor = Color.Gold,
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Location = new Point(5, y)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += async (s, e) =>
                {
                    await LoadProductsByCategoryId((Guid)((Button)s).Tag);
                };

                pnlCategories.Controls.Add(btn);

                y += btn.Height + 5;
            }
        }

        /// <summary>
        /// Загрузка товаров по категории
        /// </summary>
        private async Task LoadProductsByCategoryId(Guid categoryId)
        {
            var products = await _supplyService.GetActualProducts();
            ApplyCurrency(products);
            _bindingSource.DataSource = products.Where(x => x.CategoryId == categoryId).ToList();
            dgvProducts.Columns["DaysLeft"].Visible = true;
        }

        /// <summary>
        /// Подписка на кнопки
        /// </summary>
        private void SubscribeButtons()
        {
            btnAllProducts.Click += async (s, e) =>
            {
                try
                {
                    var products = await _supplyService.GetActualProducts();
                    ApplyCurrency(products);
                    _bindingSource.DataSource = products;
                    dgvProducts.Columns["DaysLeft"].Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
                }
            };

            buttonSearch.Click += async (s, e) =>
            {
                var searchForm = new FormSearch(_categoryService);

                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    var products = await _supplyService.SearchProductsAdvanced(
                        searchForm.Article,
                        searchForm.NameFilter,
                        searchForm.CategoryId);

                    _bindingSource.DataSource = products;
                }
            };

            buttonShipment.Click += async (s, e) =>
            {

            };

            buttonAdmin.Click += async (s, e) =>
            {
                var adminForm = new FormAdmin(
                    () => new WorkersControl(_userService),
                    () => new ProductsControl(_productService, _categoryService, _supplyService),
                    () => new ShipmentsControl(_shipmentService)
                );

                adminForm.ShowDialog();

                await LoadCategories();
                await LoadAllProducts();
            };

            buttonLogout.Click += (s, e) => this.Close();
        }

        /// <summary>
        /// Настройка DataGridView
        /// </summary>
        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = _bindingSource;
            dgvProducts.ColumnHeadersHeight = 45;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            var loginForm = _loginForm();
            loginForm.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new FormSettings(_currencyService, _currencyState, _configurationAppService);

            settingsForm.ShowDialog();
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.MainTitle;

            btnAllProducts.Text = Resources.AllProducts;
            btnExpiredProduct.Text = Resources.ExpiredProduct;
            buttonSearch.Text = Resources.Search;
            buttonShipment.Text = Resources.Shipment;
            buttonAdmin.Text = Resources.Admin;
            buttonLogout.Text = Resources.Logout;
            buttonSettings.Text = Resources.SettingsTitle;
            textBoxVisualCatalog.Text = Resources.Catalog;
            buttonReport.Text = Resources.Reporting;
            buttonDelivery.Text = Resources.Supplies;


            dgvProducts.Columns["Article"].HeaderText = Resources.Article;
            dgvProducts.Columns["Name"].HeaderText = Resources.Name;
            dgvProducts.Columns["CategoryName"].HeaderText = Resources.CategoryName;
            dgvProducts.Columns["Unit"].HeaderText = Resources.Unit;
            dgvProducts.Columns["PurchasePrice"].HeaderText = Resources.PurchasePrice;
            dgvProducts.Columns["CurrentStock"].HeaderText = Resources.CurrentStock;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var reportForm = new FormReports(_reportService);

            reportForm.ShowDialog();
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            var deliveryForm = new FormDelivery(_productService, _shipmentService, _discountService, _currencyService, _currencyState, _user.Id);

            deliveryForm.ShowDialog();
            RefreshData();
        }

        private async void btnExpiredProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var products = await _supplyService.GetExpiredProducts();
                ApplyCurrency(products);
                _bindingSource.DataSource = products;
                dgvProducts.Columns["DaysLeft"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        private void ApplyCurrency(List<ProductDto> products)
        {
            foreach (var p in products)
            {
                if (_currencyState.CurrentRate > 0)
                {
                    p.PurchasePrice = Math.Round(p.PurchasePrice / _currencyState.CurrentRate, 2);
                }
            }
        }

        private void buttonShipment_Click(object sender, EventArgs e)
        {
            var checkTINForm = new FormCheckTIN(_tINService, _user.Id, _productService, _shipmentService, _shipmentValidation, _weatherService);

            checkTINForm.ShowDialog();
        }
    }
}