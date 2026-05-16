using System.Windows.Forms;
using System.Drawing;

namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dgvProducts = new DataGridView();
            buttonShipment = new Button();
            buttonSearch = new Button();
            buttonLogout = new Button();
            buttonAdmin = new Button();
            textBoxDecor = new TextBox();
            textBoxDecor2 = new TextBox();
            textBoxDecor3 = new TextBox();
            textBoxVisualCatalog = new TextBox();
            pnlCategories = new Panel();
            btnAllProducts = new Button();
            buttonSettings = new Button();
            buttonReport = new Button();
            buttonDelivery = new Button();
            textBox1 = new TextBox();
            btnExpiredProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = SystemColors.ActiveCaptionText;
            dgvProducts.Location = new Point(268, 50);
            dgvProducts.Margin = new Padding(2, 3, 2, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.RowTemplate.Height = 31;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(856, 715);
            dgvProducts.TabIndex = 1;
            // 
            // buttonShipment
            // 
            buttonShipment.BackColor = Color.Gold;
            buttonShipment.FlatAppearance.BorderColor = Color.LightGray;
            buttonShipment.FlatAppearance.BorderSize = 0;
            buttonShipment.FlatStyle = FlatStyle.Flat;
            buttonShipment.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonShipment.Location = new Point(2, 3);
            buttonShipment.Margin = new Padding(2, 3, 2, 3);
            buttonShipment.Name = "buttonShipment";
            buttonShipment.Size = new Size(110, 39);
            buttonShipment.TabIndex = 2;
            buttonShipment.Text = "Отгрузка";
            buttonShipment.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Gold;
            buttonSearch.FlatAppearance.BorderColor = Color.LightGray;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            buttonSearch.Location = new Point(279, 5);
            buttonSearch.Margin = new Padding(2, 3, 2, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(158, 39);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Поиск товара";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Gold;
            buttonLogout.BackgroundImageLayout = ImageLayout.None;
            buttonLogout.FlatAppearance.BorderColor = Color.LightGray;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            buttonLogout.Location = new Point(603, 5);
            buttonLogout.Margin = new Padding(2, 3, 2, 3);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(177, 39);
            buttonLogout.TabIndex = 4;
            buttonLogout.Text = "Выйти из аккаунта";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdmin.BackColor = Color.Gold;
            buttonAdmin.BackgroundImageLayout = ImageLayout.None;
            buttonAdmin.FlatAppearance.BorderColor = Color.LightGray;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            buttonAdmin.Location = new Point(843, 5);
            buttonAdmin.Margin = new Padding(2, 3, 2, 3);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(143, 39);
            buttonAdmin.TabIndex = 5;
            buttonAdmin.Text = "Админ-панель";
            buttonAdmin.UseVisualStyleBackColor = false;
            // 
            // textBoxDecor
            // 
            textBoxDecor.BackColor = Color.Black;
            textBoxDecor.BorderStyle = BorderStyle.None;
            textBoxDecor.Location = new Point(16, 93);
            textBoxDecor.Margin = new Padding(2, 3, 2, 3);
            textBoxDecor.Multiline = true;
            textBoxDecor.Name = "textBoxDecor";
            textBoxDecor.ReadOnly = true;
            textBoxDecor.Size = new Size(178, 3);
            textBoxDecor.TabIndex = 23;
            // 
            // textBoxDecor2
            // 
            textBoxDecor2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDecor2.BackColor = Color.Gold;
            textBoxDecor2.BorderStyle = BorderStyle.None;
            textBoxDecor2.Location = new Point(-6, 1);
            textBoxDecor2.Margin = new Padding(2, 3, 2, 3);
            textBoxDecor2.Multiline = true;
            textBoxDecor2.Name = "textBoxDecor2";
            textBoxDecor2.ReadOnly = true;
            textBoxDecor2.Size = new Size(226, 779);
            textBoxDecor2.TabIndex = 24;
            // 
            // textBoxDecor3
            // 
            textBoxDecor3.BackColor = Color.Gold;
            textBoxDecor3.BorderStyle = BorderStyle.None;
            textBoxDecor3.Location = new Point(2, 1);
            textBoxDecor3.Margin = new Padding(2, 3, 2, 3);
            textBoxDecor3.Multiline = true;
            textBoxDecor3.Name = "textBoxDecor3";
            textBoxDecor3.ReadOnly = true;
            textBoxDecor3.Size = new Size(1146, 43);
            textBoxDecor3.TabIndex = 25;
            // 
            // textBoxVisualCatalog
            // 
            textBoxVisualCatalog.BackColor = Color.Gold;
            textBoxVisualCatalog.BorderStyle = BorderStyle.None;
            textBoxVisualCatalog.Font = new Font("Microsoft Sans Serif", 14F);
            textBoxVisualCatalog.Location = new Point(11, 179);
            textBoxVisualCatalog.Margin = new Padding(2, 3, 2, 3);
            textBoxVisualCatalog.Multiline = true;
            textBoxVisualCatalog.Name = "textBoxVisualCatalog";
            textBoxVisualCatalog.ReadOnly = true;
            textBoxVisualCatalog.Size = new Size(183, 43);
            textBoxVisualCatalog.TabIndex = 26;
            textBoxVisualCatalog.Text = "Каталог";
            textBoxVisualCatalog.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlCategories
            // 
            pnlCategories.BackColor = Color.Gold;
            pnlCategories.Location = new Point(2, 228);
            pnlCategories.Margin = new Padding(2, 3, 2, 3);
            pnlCategories.Name = "pnlCategories";
            pnlCategories.Size = new Size(218, 555);
            pnlCategories.TabIndex = 27;
            pnlCategories.Paint += pnlCategories_Paint;
            // 
            // btnAllProducts
            // 
            btnAllProducts.BackColor = Color.Gold;
            btnAllProducts.FlatAppearance.BorderSize = 0;
            btnAllProducts.FlatStyle = FlatStyle.Flat;
            btnAllProducts.Font = new Font("Microsoft Sans Serif", 14F);
            btnAllProducts.Location = new Point(16, 44);
            btnAllProducts.Margin = new Padding(2, 3, 2, 3);
            btnAllProducts.Name = "btnAllProducts";
            btnAllProducts.Size = new Size(178, 44);
            btnAllProducts.TabIndex = 28;
            btnAllProducts.Text = "Все товары";
            btnAllProducts.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSettings.BackColor = Color.Gold;
            buttonSettings.BackgroundImageLayout = ImageLayout.None;
            buttonSettings.FlatAppearance.BorderColor = Color.LightGray;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSettings.Location = new Point(991, 5);
            buttonSettings.Margin = new Padding(2, 3, 2, 3);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(143, 39);
            buttonSettings.TabIndex = 29;
            buttonSettings.Text = "Настройки";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.Gold;
            buttonReport.FlatAppearance.BorderColor = Color.LightGray;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            buttonReport.Location = new Point(441, 5);
            buttonReport.Margin = new Padding(2, 3, 2, 3);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(158, 39);
            buttonReport.TabIndex = 29;
            buttonReport.Text = "Отчетность";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonDelivery
            // 
            buttonDelivery.BackColor = Color.Gold;
            buttonDelivery.FlatAppearance.BorderColor = Color.LightGray;
            buttonDelivery.FlatAppearance.BorderSize = 0;
            buttonDelivery.FlatStyle = FlatStyle.Flat;
            buttonDelivery.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            buttonDelivery.Location = new Point(117, 5);
            buttonDelivery.Margin = new Padding(2, 3, 2, 3);
            buttonDelivery.Name = "buttonDelivery";
            buttonDelivery.Size = new Size(158, 39);
            buttonDelivery.TabIndex = 30;
            buttonDelivery.Text = "Поставки";
            buttonDelivery.UseVisualStyleBackColor = false;
            buttonDelivery.Click += buttonDelivery_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(17, 171);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(178, 3);
            textBox1.TabIndex = 31;
            // 
            // btnExpiredProduct
            // 
            btnExpiredProduct.BackColor = Color.Gold;
            btnExpiredProduct.FlatAppearance.BorderSize = 0;
            btnExpiredProduct.FlatStyle = FlatStyle.Flat;
            btnExpiredProduct.Font = new Font("Microsoft Sans Serif", 14F);
            btnExpiredProduct.Location = new Point(2, 101);
            btnExpiredProduct.Margin = new Padding(2, 3, 2, 3);
            btnExpiredProduct.Name = "btnExpiredProduct";
            btnExpiredProduct.Size = new Size(218, 64);
            btnExpiredProduct.TabIndex = 32;
            btnExpiredProduct.Text = "Списанные товары";
            btnExpiredProduct.UseVisualStyleBackColor = false;
            btnExpiredProduct.Click += btnExpiredProduct_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1146, 777);
            Controls.Add(btnExpiredProduct);
            Controls.Add(textBox1);
            Controls.Add(buttonDelivery);
            Controls.Add(buttonSettings);
            Controls.Add(buttonReport);
            Controls.Add(btnAllProducts);
            Controls.Add(pnlCategories);
            Controls.Add(textBoxVisualCatalog);
            Controls.Add(textBoxDecor);
            Controls.Add(buttonAdmin);
            Controls.Add(buttonLogout);
            Controls.Add(buttonSearch);
            Controls.Add(buttonShipment);
            Controls.Add(dgvProducts);
            Controls.Add(textBoxDecor2);
            Controls.Add(textBoxDecor3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormMain";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private Button buttonShipment;
        private Button buttonSearch;
        private Button buttonLogout;
        private Button buttonAdmin;
        private TextBox textBoxDecor;
        private TextBox textBoxDecor2;
        private TextBox textBoxDecor3;
        private TextBox textBoxVisualCatalog;
        private Panel pnlCategories;
        private Button btnAllProducts;
        private Button buttonSettings;
        private Button buttonReport;
        private Button buttonDelivery;
        private TextBox textBox1;
        private Button btnExpiredProduct;
    }
}