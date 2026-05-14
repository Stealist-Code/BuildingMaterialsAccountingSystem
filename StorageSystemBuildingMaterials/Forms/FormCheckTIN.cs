using Microsoft.Extensions.DependencyModel;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Forms
{
    public partial class FormCheckTIN : Form
    {
        private readonly ITINService _tINService;
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly IProductService _productService;
        private readonly IShipmentService _shipmentService;
        private readonly IShipmentValidation _shipmentValidation;
        private readonly Guid _userId;

        public FormCheckTIN(ITINService tINService, Guid currentUserId, IProductService productService, IShipmentService shipmentService, IShipmentValidation shipmentValidation)
        {
            InitializeComponent();

            _tINService = tINService;
            _userId = currentUserId;
            _productService = productService;
            _shipmentService = shipmentService;
            _shipmentValidation = shipmentValidation;

            SetupDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadAllInfoTIN()
        {
            var tIN = tbTIN.Text;
            var customer = await _tINService.GetInfoCustomer(tIN);

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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            var shipmentForm = new FormShipment(_userId, _productService, _shipmentService, _shipmentValidation);

            shipmentForm.ShowDialog();
        }
    }
}
