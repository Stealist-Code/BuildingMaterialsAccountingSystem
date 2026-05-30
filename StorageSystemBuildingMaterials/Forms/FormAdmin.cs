namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Административная панель: управление пользователями, товарами, категориями, история отгрузок.
    /// </summary>
    public partial class FormAdmin : Form, ILocalizable
    {
        private readonly Func<WorkersControl> _workersFactory;
        private readonly Func<ProductsControl> _productsFactory;
        private readonly Func<ShipmentsControl> _shipmentsFactory;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="workersFactory">factory рабочих</param>
        /// <param name="productsFactory">factory товаров</param>
        /// <param name="shipmentsFactory">factory отгрузок</param>
        public FormAdmin(Func<WorkersControl> workersFactory,
                        Func<ProductsControl> productsFactory,
                        Func<ShipmentsControl> shipmentsFactory)
        {
            InitializeComponent();

            _workersFactory = workersFactory;
            _productsFactory = productsFactory;
            _shipmentsFactory = shipmentsFactory;

            btnWorkers.Click += (s, e) => Show(_workersFactory());
            btnProducts.Click += (s, e) => Show(_productsFactory());
            btnShipments.Click += (s, e) => Show(_shipmentsFactory());
            this.Load += (s, e) => ApplyLocalization();

            Show(_workersFactory());
        }

        private void Show(Control control)
        {
            pnlContent.Controls.Clear();

            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.Admin;

            btnWorkers.Text = Resources.Workers;
            btnProducts.Text = Resources.Products;
            btnShipments.Text = Resources.Shipments;
            textBoxVisualAdmin.Text = Resources.Admin;

            foreach (Control control in pnlContent.Controls)
            {
                if (control is ILocalizable loc)
                {
                    loc.ApplyLocalization();
                }
            }
        }
    }
}