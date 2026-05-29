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
            Date = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            ShipmentAmount = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            reportDtoBindingSource = new BindingSource(components);
            panelReport = new Panel();
            btnExportReport = new Button();
            textBoxDecor2 = new TextBox();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            labelDate = new Label();
            btnQuit = new Button();
            panelReportTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).BeginInit();
            panelReport.SuspendLayout();
            SuspendLayout();
            // 
            // panelReportTitle
            // 
            panelReportTitle.BackColor = Color.Gold;
            panelReportTitle.Controls.Add(textBoxDecor);
            panelReportTitle.Controls.Add(labelReport);
            panelReportTitle.Dock = DockStyle.Left;
            panelReportTitle.Location = new Point(0, 0);
            panelReportTitle.Margin = new Padding(3, 4, 3, 4);
            panelReportTitle.Name = "panelReportTitle";
            panelReportTitle.Size = new Size(254, 776);
            panelReportTitle.TabIndex = 0;
            // 
            // textBoxDecor
            // 
            textBoxDecor.BackColor = SystemColors.MenuText;
            textBoxDecor.BorderStyle = BorderStyle.None;
            textBoxDecor.Font = new Font("Segoe UI", 1F);
            textBoxDecor.Location = new Point(26, 91);
            textBoxDecor.Margin = new Padding(3, 4, 3, 4);
            textBoxDecor.Name = "textBoxDecor";
            textBoxDecor.Size = new Size(200, 3);
            textBoxDecor.TabIndex = 1;
            // 
            // labelReport
            // 
            labelReport.AutoSize = true;
            labelReport.Font = new Font("Segoe UI", 20F);
            labelReport.Location = new Point(37, 21);
            labelReport.Name = "labelReport";
            labelReport.Size = new Size(198, 46);
            labelReport.TabIndex = 0;
            labelReport.Text = "Отчетность";
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.AutoGenerateColumns = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.Gold;
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
            dgvReport.Location = new Point(254, 103);
            dgvReport.Margin = new Padding(3, 4, 3, 4);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(931, 673);
            dgvReport.TabIndex = 1;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "CustomerName";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // ShipmentAmount
            // 
            ShipmentAmount.DataPropertyName = "ShipmentAmount";
            ShipmentAmount.HeaderText = "ShipmentAmount";
            ShipmentAmount.MinimumWidth = 6;
            ShipmentAmount.Name = "ShipmentAmount";
            ShipmentAmount.ReadOnly = true;
            // 
            // Profit
            // 
            Profit.DataPropertyName = "Profit";
            Profit.HeaderText = "Profit";
            Profit.MinimumWidth = 6;
            Profit.Name = "Profit";
            Profit.ReadOnly = true;
            // 
            // reportDtoBindingSource
            // 
            reportDtoBindingSource.DataSource = typeof(DTO.ReportDto);
            // 
            // panelReport
            // 
            panelReport.BackColor = Color.Gold;
            panelReport.Controls.Add(btnQuit);
            panelReport.Controls.Add(btnExportReport);
            panelReport.Controls.Add(textBoxDecor2);
            panelReport.Controls.Add(dateTimePickerTo);
            panelReport.Controls.Add(dateTimePickerFrom);
            panelReport.Controls.Add(labelDate);
            panelReport.Dock = DockStyle.Top;
            panelReport.Location = new Point(254, 0);
            panelReport.Margin = new Padding(3, 4, 3, 4);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(935, 105);
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
            btnExportReport.Location = new Point(667, 37);
            btnExportReport.Margin = new Padding(2, 3, 2, 3);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(249, 41);
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
            textBoxDecor2.Location = new Point(250, 53);
            textBoxDecor2.Margin = new Padding(3, 4, 3, 4);
            textBoxDecor2.Name = "textBoxDecor2";
            textBoxDecor2.Size = new Size(23, 3);
            textBoxDecor2.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerTo.Font = new Font("Segoe UI", 13F);
            dateTimePickerTo.Format = DateTimePickerFormat.Short;
            dateTimePickerTo.Location = new Point(290, 35);
            dateTimePickerTo.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(135, 36);
            dateTimePickerTo.TabIndex = 4;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePickerFrom.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(99, 35);
            dateTimePickerFrom.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(135, 36);
            dateTimePickerFrom.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15F);
            labelDate.Location = new Point(21, 31);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(68, 35);
            labelDate.TabIndex = 2;
            labelDate.Text = "Дата";
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Right;
            btnQuit.BackColor = Color.Black;
            btnQuit.FlatAppearance.BorderSize = 20;
            btnQuit.FlatStyle = FlatStyle.Popup;
            btnQuit.Font = new Font("Segoe UI", 12F);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(468, 37);
            btnQuit.Margin = new Padding(2, 3, 2, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(184, 41);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "Выйти";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1189, 776);
            Controls.Add(panelReport);
            Controls.Add(dgvReport);
            Controls.Add(panelReportTitle);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnQuit;
    }
}