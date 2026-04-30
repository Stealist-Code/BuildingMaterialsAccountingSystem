using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System;

namespace StorageSystemBuildingMaterials.Controls
{
    public partial class ShipmentsControl : UserControl
    {
        private readonly IShipmentService _shipmentService;
        private DataGridView dgvShipments;
        private DataGridView dgvItems;
        private List<ShipmentDto> _shipments;

        public ShipmentsControl(IShipmentService shipmentService)
        {
            InitializeComponent();
            _shipmentService = shipmentService;

            Load += async (s, e) => await LoadData();

            dgvShipments.SelectionChanged += dgvShipments_SelectionChanged;
        }

        private async Task LoadData()
        {
            _shipments = await _shipmentService.GetAllShipments();

            dgvShipments.DataSource = _shipments.Select(x => new
            {
                x.Id,
                x.UserEmail,
                x.Address,
                x.ShipmentDate
            }).ToList();

            dgvShipments.Columns["UserEmail"]?.HeaderText = Resources.UserEmail;
            dgvShipments.Columns["Address"]?.HeaderText = Resources.Address;
            dgvShipments.Columns["ShipmentDate"]?.HeaderText = Resources.ShipmentDate;

            dgvItems.Columns["ProductName"]?.HeaderText = Resources.Product;
            dgvItems.Columns["Quantity"]?.HeaderText = Resources.Quantity;


            dgvShipments.Columns["Id"]?.Visible = false;
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvShipments = new DataGridView();
            dgvItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvShipments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvShipments
            // 
            dgvShipments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipments.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvShipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvShipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvShipments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvShipments.Location = new Point(0, 0);
            dgvShipments.MultiSelect = false;
            dgvShipments.Name = "dgvShipments";
            dgvShipments.ReadOnly = true;
            dgvShipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipments.Size = new Size(578, 544);
            dgvShipments.TabIndex = 0;
            // 
            // dgvItems
            // 
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle4;
            dgvItems.Location = new Point(577, 0);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(269, 544);
            dgvItems.TabIndex = 1;
            // 
            // ShipmentsControl
            // 
            Controls.Add(dgvItems);
            Controls.Add(dgvShipments);
            Name = "ShipmentsControl";
            Size = new Size(846, 544);
            ((System.ComponentModel.ISupportInitialize)dgvShipments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        private void dgvShipments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShipments.CurrentRow?.Cells["Id"]?.Value is not Guid)
            {
                return;
            }

            var id = (Guid)dgvShipments.CurrentRow?.Cells["Id"]?.Value;

            var shipment = _shipments.FirstOrDefault(x => x.Id == id);

            if (shipment is not null)
            {
                dgvItems.DataSource = shipment?.Items.Select(x => new
                {
                    x.ProductName,
                    x.Quantity
                }).ToList();
            }
        }
    }
}