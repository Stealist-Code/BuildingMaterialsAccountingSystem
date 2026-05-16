namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipment));
            txtStreet = new TextBox();
            cbProduct = new ComboBox();
            nudQuantity = new NumericUpDown();
            labelTextVisualStreet = new Label();
            labelTextVisualProduct = new Label();
            labelTextVisualCountProduct = new Label();
            btnAdd = new Button();
            btnCreate = new Button();
            labelTextVisualShipment = new Label();
            labelPositions = new Label();
            textBox1 = new TextBox();
            dgvCart = new DataGridView();
            txtBuilding = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            labelTextVisualBuilding = new Label();
            labelTextVisualRegion = new Label();
            labelTextVisualCity = new Label();
            labelTextVisualCountry = new Label();
            labelTextVisualMiddleName = new Label();
            txtMiddleName = new TextBox();
            labelTextVisualFirstName = new Label();
            txtFirstName = new TextBox();
            labelTextVisualLastName = new Label();
            txtLastName = new TextBox();
            labelTextVisualEmail = new Label();
            txtEmail = new TextBox();
            labelTextVisualPrice = new Label();
            labelTextVisualSelling = new Label();
            nudTotalPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalPrice).BeginInit();
            SuspendLayout();
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.None;
            txtStreet.BackColor = Color.White;
            txtStreet.Font = new Font("Microsoft Sans Serif", 15F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(214, 427);
            txtStreet.Margin = new Padding(2, 3, 2, 3);
            txtStreet.Multiline = true;
            txtStreet.Name = "txtStreet";
            txtStreet.RightToLeft = RightToLeft.No;
            txtStreet.Size = new Size(295, 43);
            txtStreet.TabIndex = 12;
            // 
            // cbProduct
            // 
            cbProduct.Anchor = AnchorStyles.None;
            cbProduct.Font = new Font("Microsoft Sans Serif", 15F);
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(214, 585);
            cbProduct.Margin = new Padding(2, 3, 2, 3);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(295, 37);
            cbProduct.TabIndex = 13;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 15F);
            nudQuantity.Location = new Point(213, 661);
            nudQuantity.Margin = new Padding(2, 3, 2, 3);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(297, 36);
            nudQuantity.TabIndex = 14;
            // 
            // labelTextVisualStreet
            // 
            labelTextVisualStreet.Anchor = AnchorStyles.None;
            labelTextVisualStreet.AutoSize = true;
            labelTextVisualStreet.BackColor = Color.Transparent;
            labelTextVisualStreet.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualStreet.ForeColor = Color.Black;
            labelTextVisualStreet.Location = new Point(39, 425);
            labelTextVisualStreet.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualStreet.Name = "labelTextVisualStreet";
            labelTextVisualStreet.Size = new Size(92, 37);
            labelTextVisualStreet.TabIndex = 15;
            labelTextVisualStreet.Text = "Улица";
            // 
            // labelTextVisualProduct
            // 
            labelTextVisualProduct.Anchor = AnchorStyles.None;
            labelTextVisualProduct.AutoSize = true;
            labelTextVisualProduct.BackColor = Color.Transparent;
            labelTextVisualProduct.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualProduct.ForeColor = Color.Black;
            labelTextVisualProduct.Location = new Point(39, 584);
            labelTextVisualProduct.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualProduct.Name = "labelTextVisualProduct";
            labelTextVisualProduct.Size = new Size(91, 37);
            labelTextVisualProduct.TabIndex = 16;
            labelTextVisualProduct.Text = "Товар";
            // 
            // labelTextVisualCountProduct
            // 
            labelTextVisualCountProduct.Anchor = AnchorStyles.None;
            labelTextVisualCountProduct.AutoSize = true;
            labelTextVisualCountProduct.BackColor = Color.Transparent;
            labelTextVisualCountProduct.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualCountProduct.ForeColor = Color.Black;
            labelTextVisualCountProduct.Location = new Point(39, 659);
            labelTextVisualCountProduct.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCountProduct.Name = "labelTextVisualCountProduct";
            labelTextVisualCountProduct.Size = new Size(161, 37);
            labelTextVisualCountProduct.TabIndex = 17;
            labelTextVisualCountProduct.Text = "Количество";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 20;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(567, 647);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(424, 65);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Зарезервировать товар";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.AutoSize = true;
            btnCreate.BackColor = Color.Black;
            btnCreate.FlatAppearance.BorderSize = 20;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1123, 647);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(393, 65);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Создать отгрузку";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // labelTextVisualShipment
            // 
            labelTextVisualShipment.Anchor = AnchorStyles.None;
            labelTextVisualShipment.AutoSize = true;
            labelTextVisualShipment.BackColor = Color.Transparent;
            labelTextVisualShipment.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualShipment.ForeColor = Color.Black;
            labelTextVisualShipment.Location = new Point(323, 51);
            labelTextVisualShipment.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualShipment.Name = "labelTextVisualShipment";
            labelTextVisualShipment.Size = new Size(449, 46);
            labelTextVisualShipment.TabIndex = 20;
            labelTextVisualShipment.Text = "Оформление отгрузки";
            // 
            // labelPositions
            // 
            labelPositions.Anchor = AnchorStyles.None;
            labelPositions.AutoSize = true;
            labelPositions.BackColor = Color.Transparent;
            labelPositions.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPositions.ForeColor = Color.Black;
            labelPositions.Location = new Point(1183, 51);
            labelPositions.Margin = new Padding(2, 0, 2, 0);
            labelPositions.Name = "labelPositions";
            labelPositions.Size = new Size(347, 46);
            labelPositions.TabIndex = 21;
            labelPositions.Text = "Текущие позиции";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(1024, 73);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(6, 917);
            textBox1.TabIndex = 22;
            // 
            // dgvCart
            // 
            dgvCart.Anchor = AnchorStyles.None;
            dgvCart.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.Location = new Point(1107, 145);
            dgvCart.Margin = new Padding(2, 3, 2, 3);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 72;
            dgvCart.RowTemplate.Height = 31;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(441, 455);
            dgvCart.TabIndex = 23;
            // 
            // txtBuilding
            // 
            txtBuilding.Anchor = AnchorStyles.None;
            txtBuilding.BackColor = Color.White;
            txtBuilding.Font = new Font("Microsoft Sans Serif", 15F);
            txtBuilding.ForeColor = Color.Black;
            txtBuilding.Location = new Point(214, 501);
            txtBuilding.Margin = new Padding(2, 3, 2, 3);
            txtBuilding.Multiline = true;
            txtBuilding.Name = "txtBuilding";
            txtBuilding.RightToLeft = RightToLeft.No;
            txtBuilding.Size = new Size(295, 43);
            txtBuilding.TabIndex = 24;
            // 
            // txtRegion
            // 
            txtRegion.Anchor = AnchorStyles.None;
            txtRegion.BackColor = Color.White;
            txtRegion.Font = new Font("Microsoft Sans Serif", 15F);
            txtRegion.ForeColor = Color.Black;
            txtRegion.Location = new Point(214, 276);
            txtRegion.Margin = new Padding(2, 3, 2, 3);
            txtRegion.Multiline = true;
            txtRegion.Name = "txtRegion";
            txtRegion.RightToLeft = RightToLeft.No;
            txtRegion.Size = new Size(295, 43);
            txtRegion.TabIndex = 25;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.None;
            txtCity.BackColor = Color.White;
            txtCity.Font = new Font("Microsoft Sans Serif", 15F);
            txtCity.ForeColor = Color.Black;
            txtCity.Location = new Point(214, 351);
            txtCity.Margin = new Padding(2, 3, 2, 3);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.RightToLeft = RightToLeft.No;
            txtCity.Size = new Size(295, 43);
            txtCity.TabIndex = 26;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.None;
            txtCountry.BackColor = Color.White;
            txtCountry.Font = new Font("Microsoft Sans Serif", 15F);
            txtCountry.ForeColor = Color.Black;
            txtCountry.Location = new Point(214, 195);
            txtCountry.Margin = new Padding(2, 3, 2, 3);
            txtCountry.Multiline = true;
            txtCountry.Name = "txtCountry";
            txtCountry.RightToLeft = RightToLeft.No;
            txtCountry.Size = new Size(295, 43);
            txtCountry.TabIndex = 27;
            // 
            // labelTextVisualBuilding
            // 
            labelTextVisualBuilding.Anchor = AnchorStyles.None;
            labelTextVisualBuilding.AutoSize = true;
            labelTextVisualBuilding.BackColor = Color.Transparent;
            labelTextVisualBuilding.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualBuilding.ForeColor = Color.Black;
            labelTextVisualBuilding.Location = new Point(39, 500);
            labelTextVisualBuilding.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualBuilding.Name = "labelTextVisualBuilding";
            labelTextVisualBuilding.Size = new Size(107, 37);
            labelTextVisualBuilding.TabIndex = 28;
            labelTextVisualBuilding.Text = "Здание";
            // 
            // labelTextVisualRegion
            // 
            labelTextVisualRegion.Anchor = AnchorStyles.None;
            labelTextVisualRegion.AutoSize = true;
            labelTextVisualRegion.BackColor = Color.Transparent;
            labelTextVisualRegion.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualRegion.ForeColor = Color.Black;
            labelTextVisualRegion.Location = new Point(39, 275);
            labelTextVisualRegion.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualRegion.Name = "labelTextVisualRegion";
            labelTextVisualRegion.Size = new Size(104, 37);
            labelTextVisualRegion.TabIndex = 29;
            labelTextVisualRegion.Text = "Регион";
            // 
            // labelTextVisualCity
            // 
            labelTextVisualCity.Anchor = AnchorStyles.None;
            labelTextVisualCity.AutoSize = true;
            labelTextVisualCity.BackColor = Color.Transparent;
            labelTextVisualCity.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualCity.ForeColor = Color.Black;
            labelTextVisualCity.Location = new Point(39, 349);
            labelTextVisualCity.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCity.Name = "labelTextVisualCity";
            labelTextVisualCity.Size = new Size(93, 37);
            labelTextVisualCity.TabIndex = 30;
            labelTextVisualCity.Text = "Город";
            // 
            // labelTextVisualCountry
            // 
            labelTextVisualCountry.Anchor = AnchorStyles.None;
            labelTextVisualCountry.AutoSize = true;
            labelTextVisualCountry.BackColor = Color.Transparent;
            labelTextVisualCountry.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualCountry.ForeColor = Color.Black;
            labelTextVisualCountry.Location = new Point(38, 193);
            labelTextVisualCountry.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCountry.Name = "labelTextVisualCountry";
            labelTextVisualCountry.Size = new Size(105, 37);
            labelTextVisualCountry.TabIndex = 31;
            labelTextVisualCountry.Text = "Страна";
            // 
            // labelTextVisualMiddleName
            // 
            labelTextVisualMiddleName.Anchor = AnchorStyles.None;
            labelTextVisualMiddleName.AutoSize = true;
            labelTextVisualMiddleName.BackColor = Color.Transparent;
            labelTextVisualMiddleName.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualMiddleName.ForeColor = Color.Black;
            labelTextVisualMiddleName.Location = new Point(537, 349);
            labelTextVisualMiddleName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualMiddleName.Name = "labelTextVisualMiddleName";
            labelTextVisualMiddleName.Size = new Size(130, 37);
            labelTextVisualMiddleName.TabIndex = 33;
            labelTextVisualMiddleName.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Anchor = AnchorStyles.None;
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.Font = new Font("Microsoft Sans Serif", 15F);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(696, 351);
            txtMiddleName.Margin = new Padding(2, 3, 2, 3);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.RightToLeft = RightToLeft.No;
            txtMiddleName.Size = new Size(294, 43);
            txtMiddleName.TabIndex = 32;
            // 
            // labelTextVisualFirstName
            // 
            labelTextVisualFirstName.Anchor = AnchorStyles.None;
            labelTextVisualFirstName.AutoSize = true;
            labelTextVisualFirstName.BackColor = Color.Transparent;
            labelTextVisualFirstName.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualFirstName.ForeColor = Color.Black;
            labelTextVisualFirstName.Location = new Point(537, 269);
            labelTextVisualFirstName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualFirstName.Name = "labelTextVisualFirstName";
            labelTextVisualFirstName.Size = new Size(70, 37);
            labelTextVisualFirstName.TabIndex = 35;
            labelTextVisualFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 15F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(696, 271);
            txtFirstName.Margin = new Padding(2, 3, 2, 3);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.RightToLeft = RightToLeft.No;
            txtFirstName.Size = new Size(294, 43);
            txtFirstName.TabIndex = 34;
            // 
            // labelTextVisualLastName
            // 
            labelTextVisualLastName.Anchor = AnchorStyles.None;
            labelTextVisualLastName.AutoSize = true;
            labelTextVisualLastName.BackColor = Color.Transparent;
            labelTextVisualLastName.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualLastName.ForeColor = Color.Black;
            labelTextVisualLastName.Location = new Point(537, 188);
            labelTextVisualLastName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualLastName.Name = "labelTextVisualLastName";
            labelTextVisualLastName.Size = new Size(130, 37);
            labelTextVisualLastName.TabIndex = 37;
            labelTextVisualLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Microsoft Sans Serif", 15F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(696, 189);
            txtLastName.Margin = new Padding(2, 3, 2, 3);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.RightToLeft = RightToLeft.No;
            txtLastName.Size = new Size(294, 43);
            txtLastName.TabIndex = 36;
            // 
            // labelTextVisualEmail
            // 
            labelTextVisualEmail.Anchor = AnchorStyles.None;
            labelTextVisualEmail.AutoSize = true;
            labelTextVisualEmail.BackColor = Color.Transparent;
            labelTextVisualEmail.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualEmail.ForeColor = Color.Black;
            labelTextVisualEmail.Location = new Point(542, 420);
            labelTextVisualEmail.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualEmail.Name = "labelTextVisualEmail";
            labelTextVisualEmail.Size = new Size(133, 37);
            labelTextVisualEmail.TabIndex = 39;
            labelTextVisualEmail.Text = "Эл. почта";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Microsoft Sans Serif", 15F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(696, 421);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(294, 43);
            txtEmail.TabIndex = 38;
            // 
            // labelTextVisualPrice
            // 
            labelTextVisualPrice.Anchor = AnchorStyles.None;
            labelTextVisualPrice.AutoSize = true;
            labelTextVisualPrice.BackColor = Color.Transparent;
            labelTextVisualPrice.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualPrice.ForeColor = Color.Black;
            labelTextVisualPrice.Location = new Point(542, 483);
            labelTextVisualPrice.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualPrice.Name = "labelTextVisualPrice";
            labelTextVisualPrice.Size = new Size(81, 37);
            labelTextVisualPrice.TabIndex = 41;
            labelTextVisualPrice.Text = "Цена";
            // 
            // labelTextVisualSelling
            // 
            labelTextVisualSelling.Anchor = AnchorStyles.None;
            labelTextVisualSelling.AutoSize = true;
            labelTextVisualSelling.BackColor = Color.Transparent;
            labelTextVisualSelling.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualSelling.ForeColor = Color.Black;
            labelTextVisualSelling.Location = new Point(537, 523);
            labelTextVisualSelling.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualSelling.Name = "labelTextVisualSelling";
            labelTextVisualSelling.Size = new Size(130, 37);
            labelTextVisualSelling.TabIndex = 42;
            labelTextVisualSelling.Text = "продажи";
            // 
            // nudTotalPrice
            // 
            nudTotalPrice.Anchor = AnchorStyles.None;
            nudTotalPrice.Font = new Font("Microsoft Sans Serif", 15F);
            nudTotalPrice.Location = new Point(696, 503);
            nudTotalPrice.Margin = new Padding(2, 3, 2, 3);
            nudTotalPrice.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudTotalPrice.Name = "nudTotalPrice";
            nudTotalPrice.Size = new Size(297, 36);
            nudTotalPrice.TabIndex = 43;
            // 
            // FormShipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1650, 849);
            Controls.Add(nudTotalPrice);
            Controls.Add(labelTextVisualSelling);
            Controls.Add(labelTextVisualPrice);
            Controls.Add(labelTextVisualEmail);
            Controls.Add(txtEmail);
            Controls.Add(labelTextVisualLastName);
            Controls.Add(txtLastName);
            Controls.Add(labelTextVisualFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(labelTextVisualMiddleName);
            Controls.Add(txtMiddleName);
            Controls.Add(labelTextVisualCountry);
            Controls.Add(labelTextVisualCity);
            Controls.Add(labelTextVisualRegion);
            Controls.Add(labelTextVisualBuilding);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtRegion);
            Controls.Add(txtBuilding);
            Controls.Add(dgvCart);
            Controls.Add(textBox1);
            Controls.Add(labelPositions);
            Controls.Add(labelTextVisualShipment);
            Controls.Add(btnCreate);
            Controls.Add(btnAdd);
            Controls.Add(labelTextVisualCountProduct);
            Controls.Add(labelTextVisualProduct);
            Controls.Add(labelTextVisualStreet);
            Controls.Add(nudQuantity);
            Controls.Add(cbProduct);
            Controls.Add(txtStreet);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormShipment";
            Text = "Otgruzka";
            WindowState = FormWindowState.Minimized;
            Load += FormShipment_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label labelTextVisualStreet;
        private System.Windows.Forms.Label labelTextVisualProduct;
        private System.Windows.Forms.Label labelTextVisualCountProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelTextVisualShipment;
        private System.Windows.Forms.Label labelPositions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label labelTextVisualBuilding;
        private System.Windows.Forms.Label labelTextVisualRegion;
        private System.Windows.Forms.Label labelTextVisualCity;
        private System.Windows.Forms.Label labelTextVisualCountry;
        private Label labelTextVisualMiddleName;
        private TextBox txtMiddleName;
        private Label labelTextVisualFirstName;
        private TextBox txtFirstName;
        private Label labelTextVisualLastName;
        private TextBox txtLastName;
        private Label labelTextVisualEmail;
        private TextBox txtEmail;
        private Label labelTextVisualPrice;
        private Label labelTextVisualSelling;
        private NumericUpDown nudTotalPrice;
    }
}