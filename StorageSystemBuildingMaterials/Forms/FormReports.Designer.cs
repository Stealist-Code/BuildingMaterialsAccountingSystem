namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelReportTitle = new Panel();
            textBoxDecor = new TextBox();
            labelReport = new Label();
            dgvReport = new DataGridView();
            reportDtoBindingSource = new BindingSource(components);
            panelReport = new Panel();
            btnExportReport = new Button();
            textBoxDecor2 = new TextBox();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            labelDate = new Label();
            Date = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            ShipmentAmount = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            panelReportTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).BeginInit();
            panelReport.SuspendLayout();
            SuspendLayout();
            // 
            // panelReportTitle
            // 
            panelReportTitle.BackColor = Color.Gainsboro;
            panelReportTitle.Controls.Add(textBoxDecor);
            panelReportTitle.Controls.Add(labelReport);
            panelReportTitle.Dock = DockStyle.Left;
            panelReportTitle.Location = new Point(0, 0);
            panelReportTitle.Name = "panelReportTitle";
            panelReportTitle.Size = new Size(222, 582);
            panelReportTitle.TabIndex = 0;
            // 
            // textBoxDecor
            // 
            textBoxDecor.BackColor = SystemColors.MenuText;
            textBoxDecor.BorderStyle = BorderStyle.None;
            textBoxDecor.Font = new Font("Segoe UI", 1F);
            textBoxDecor.Location = new Point(23, 68);
            textBoxDecor.Name = "textBoxDecor";
            textBoxDecor.Size = new Size(175, 2);
            textBoxDecor.TabIndex = 1;
            // 
            // labelReport
            // 
            labelReport.AutoSize = true;
            labelReport.Font = new Font("Segoe UI", 20F);
            labelReport.Location = new Point(32, 16);
            labelReport.Name = "labelReport";
            labelReport.Size = new Size(157, 37);
            labelReport.TabIndex = 0;
            labelReport.Text = "Отчетность";
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.AutoGenerateColumns = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { Date, CustomerName, ShipmentAmount, Profit });
            dgvReport.DataSource = reportDtoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.Location = new Point(222, 77);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(724, 505);
            dgvReport.TabIndex = 1;
            // 
            // reportDtoBindingSource
            // 
            reportDtoBindingSource.DataSource = typeof(DTO.ReportDto);
            // 
            // panelReport
            // 
            panelReport.BackColor = Color.DarkGray;
            panelReport.Controls.Add(btnExportReport);
            panelReport.Controls.Add(textBoxDecor2);
            panelReport.Controls.Add(dateTimePickerTo);
            panelReport.Controls.Add(dateTimePickerFrom);
            panelReport.Controls.Add(labelDate);
            panelReport.Dock = DockStyle.Top;
            panelReport.Location = new Point(222, 0);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(727, 79);
            panelReport.TabIndex = 2;
            // 
            // btnExportReport
            // 
            btnExportReport.Anchor = AnchorStyles.Right;
            btnExportReport.BackColor = Color.Black;
            btnExportReport.FlatAppearance.BorderSize = 20;
            btnExportReport.FlatStyle = FlatStyle.Popup;
            btnExportReport.Font = new Font("Segoe UI", 12F);
            btnExportReport.ForeColor = Color.White;
            btnExportReport.Location = new Point(493, 28);
            btnExportReport.Margin = new Padding(2);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(218, 31);
            btnExportReport.TabIndex = 7;
            btnExportReport.Text = "Экспорт отчета";
            btnExportReport.UseVisualStyleBackColor = false;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // textBoxDecor2
            // 
            textBoxDecor2.BackColor = SystemColors.MenuText;
            textBoxDecor2.BorderStyle = BorderStyle.None;
            textBoxDecor2.Font = new Font("Segoe UI", 1F);
            textBoxDecor2.Location = new Point(219, 40);
            textBoxDecor2.Name = "textBoxDecor2";
            textBoxDecor2.Size = new Size(20, 2);
            textBoxDecor2.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerTo.Font = new Font("Segoe UI", 13F);
            dateTimePickerTo.Format = DateTimePickerFormat.Short;
            dateTimePickerTo.Location = new Point(254, 26);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(119, 31);
            dateTimePickerTo.TabIndex = 4;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePickerFrom.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(87, 26);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(119, 30);
            dateTimePickerFrom.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15F);
            labelDate.Location = new Point(18, 23);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(54, 28);
            labelDate.TabIndex = 2;
            labelDate.Text = "Дата";
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "CustomerName";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // ShipmentAmount
            // 
            ShipmentAmount.DataPropertyName = "ShipmentAmount";
            ShipmentAmount.HeaderText = "ShipmentAmount";
            ShipmentAmount.Name = "ShipmentAmount";
            ShipmentAmount.ReadOnly = true;
            // 
            // Profit
            // 
            Profit.DataPropertyName = "Profit";
            Profit.HeaderText = "Profit";
            Profit.Name = "Profit";
            Profit.ReadOnly = true;
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(949, 582);
            Controls.Add(panelReport);
            Controls.Add(dgvReport);
            Controls.Add(panelReportTitle);
            Name = "FormReports";
            Text = "Отчетность";
            Load += FormReports_Load;
            panelReportTitle.ResumeLayout(false);
            panelReportTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).EndInit();
            panelReport.ResumeLayout(false);
            panelReport.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReportTitle;
        private Label labelReport;
        private TextBox textBoxDecor;
        private DataGridView dgvReport;
        private Panel panelReport;
        private Label labelDate;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private TextBox textBoxDecor2;
        private Button btnExportReport;
        private BindingSource reportDtoBindingSource;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn ShipmentAmount;
        private DataGridViewTextBoxColumn Profit;
    }
}