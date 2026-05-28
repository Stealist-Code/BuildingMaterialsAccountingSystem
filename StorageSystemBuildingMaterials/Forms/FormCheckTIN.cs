using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма для проверки ИНН
    /// </summary>
    public partial class FormCheckTIN : Form
    {
        private readonly ITINService _tINService;
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly IProductService _productService;
        private readonly IShipmentService _shipmentService;
        private readonly IShipmentValidation _shipmentValidation;
        private readonly IWeatherService _weatherService;
        private readonly Guid _userId;

        public FormCheckTIN(ITINService tINService, Guid currentUserId, IProductService productService, IShipmentService shipmentService, IShipmentValidation shipmentValidation, IWeatherService weatherService)
        {
            InitializeComponent();

            _tINService = tINService;
            _userId = currentUserId;
            _productService = productService;
            _shipmentService = shipmentService;
            _shipmentValidation = shipmentValidation;
            _weatherService = weatherService;

            ApplyLocalization();

            SetupDataGridView();
        }

        private async Task LoadAllInfoTIN()
        {
            var tIN = tbTIN.Text;
            var customer = await _tINService.GetInfoCustomer(tIN);
            if (customer is null)
            {
                MessageBox.Show(Resources.InvalidTIN);
                return;
            }

            var (lat, lon) = await _tINService.GetCoordinates(customer.FullAddress);
            var (weatherCode, temperature) = await _weatherService.GetWeatherCodeAndTemperature(lat, lon);
            customer.Weather = $"{weatherCode}, {temperature}℃";

            var message = await _tINService.CheckCompanyOnBlackList(tIN);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            _bindingSource.DataSource = customer;
            dgvTIN.Columns["Id"].Visible = false;
            dgvTIN.Columns["Email"].Visible = false;
            dgvTIN.Columns["AddressId"].Visible = false;
            dgvTIN.Columns["FullAddress"].Visible = false;
            dgvTIN.Columns["Country"].HeaderText = Resources.Country;
            dgvTIN.Columns["Region"].HeaderText = Resources.Region;
            dgvTIN.Columns["City"].HeaderText = Resources.City;
            dgvTIN.Columns["Street"].HeaderText = Resources.Street;
            dgvTIN.Columns["Building"].HeaderText = Resources.Building;
            dgvTIN.Columns["FirstName"].HeaderText = Resources.FirstName;
            dgvTIN.Columns["LastName"].HeaderText = Resources.LastName;
            dgvTIN.Columns["MiddleName"].HeaderText = Resources.MiddleName;
        }

        private void SetupDataGridView()
        {
            dgvTIN.AutoGenerateColumns = true;
            dgvTIN.DataSource = _bindingSource;
            dgvTIN.ColumnHeadersHeight = 45;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            LoadAllInfoTIN();
        }

        private async void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dgvTIN.CurrentRow is null)
            {
                return;
            }

            var selectedCustomer = dgvTIN.CurrentRow.DataBoundItem as CustomerDto;

            if (selectedCustomer is null)
            {
                return;
            }

            var message = await _tINService.CheckCompanyOnBlackList(selectedCustomer.TIN);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            var customer = await _tINService.FindCustomerWithTIN(selectedCustomer.TIN);

            var shipmentForm = new FormShipment(_userId, _productService, _shipmentService, _shipmentValidation, customer, this);

            shipmentForm.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            labelCheckTIN.Text = Resources.CheckTIN;
            labelTIN.Text = Resources.TIN;
            buttonCancel.Text = Resources.Cancel;
            buttonSelect.Text = Resources.Select;
            buttonCheck.Text = Resources.Check;
            this.Text = Resources.FormCheckTIN;
        }
    }
}
