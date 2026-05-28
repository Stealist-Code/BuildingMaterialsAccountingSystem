using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Data;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма для отображения карты склада
    /// </summary>
    public partial class FormWarehouseMap : Form
    {
        private readonly int _rowsMin = 10;
        private readonly int _columnsMin = 3;
        private readonly ISupplyService _supplyService;
        private readonly BindingSource _bindingSource = new BindingSource();

        public FormWarehouseMap(ISupplyService supplyService)
        {
            _supplyService = supplyService;
            InitializeComponent();
            dataGridViewWarehouseMap.DataSource = _bindingSource;
            dataGridViewWarehouseMap.SizeChanged += (s, e) => ResizeRows();
            this.Load += FormWarehouseMap_Load;
            ApplyLocalization();
        }

        private async void FormWarehouseMap_Load(object sender, EventArgs e)
        {
            await BuildGrid();
            SetupHeadersAsStatic();
        }

        private async Task BuildGrid()
        {
            var products = await _supplyService.GetProducts();

            var calculatedColumns = products.Count > 0
                ? (int)Math.Ceiling(products.Count / (double)_rowsMin)
                : 0;

            var columnCount = Math.Max(calculatedColumns, _columnsMin);

            var table = new DataTable();

            for (var c = 0; c < columnCount; c++)
            {
                table.Columns.Add($"{Resources.Row} №{c+1}", typeof(string));
            }

            for (var r = 0; r < _rowsMin; r++)
            {
                table.Rows.Add(table.NewRow());
            }

            var productIndex = 0;
            for (var col = 0; col < columnCount; col++)
            {
                for (var row = 0; row < _rowsMin; row++)
                {
                    if (productIndex < products.Count)
                    {
                        table.Rows[row][col] = products[productIndex].Name;
                        productIndex++;
                    }
                }
            }

            _bindingSource.DataSource = table;

            ResizeRows();
            await ApplyColor(columnCount, products);
        }

        private void ResizeRows()
        {
            if (dataGridViewWarehouseMap.Rows.Count == 0)
            {
                return;
            }

            var availableHeight = dataGridViewWarehouseMap.ClientSize.Height;
            var rowHeight = availableHeight / dataGridViewWarehouseMap.Rows.Count;

            if (rowHeight < 1)
            {
                rowHeight = 1;
            }

            foreach (DataGridViewRow row in dataGridViewWarehouseMap.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private async Task ApplyColor(int columnCount, List<ProductDto> products)
        {
            var productIndex = 0;
            for (var col = 0; col < columnCount; col++)
            {
                for (var row = 0; row < _rowsMin; row++)
                {
                    if (productIndex >= products.Count)
                    {
                        break;
                    }

                    var product = products[productIndex];
                    var cell = dataGridViewWarehouseMap.Rows[row].Cells[col];

                    cell.Style.BackColor = await GetProductColor(product);
                    productIndex++;
                }
            }
        }

        private async Task<Color> GetProductColor(ProductDto productDto)
        {
            if (productDto is null)
            {
                return Color.White;
            }
            if (productDto.DaysLeft < 10)
            {
                return Color.Red;
            }
            if (productDto.DaysLeft < 30)
            {
                return Color.Orange;
            }
            if (productDto.DaysLeft < 60)
            {
                return Color.Green;
            }
            return Color.DarkBlue;
        }

        private void SetupHeadersAsStatic()
        {
            dataGridViewWarehouseMap.EnableHeadersVisualStyles = false;
            dataGridViewWarehouseMap.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewWarehouseMap.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;

            foreach (DataGridViewColumn column in dataGridViewWarehouseMap.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.WarehouseMap;
            labelWarehouseMap.Text = Resources.WarehouseMap;
            labelShipment1.Text = Resources.ShippingFirst;
            labelShpment2.Text = Resources.NextWeekShipmentPlan;
            labelShipment3.Text = Resources.StandardRotation;
            labelShimpent4.Text = Resources.AccountingForBalances;
        }
    }
}
