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
            cbProduct = new ComboBox();
            nudQuantity = new NumericUpDown();
            labelTextVisualProduct = new Label();
            labelTextVisualCountProduct = new Label();
            btnAdd = new Button();
            btnCreate = new Button();
            labelTextVisualShipment = new Label();
            labelPositions = new Label();
            textBox1 = new TextBox();
            dgvCart = new DataGridView();
            labelTextVisualPrice = new Label();
            nudTotalPrice = new NumericUpDown();
            labelTIN = new Label();
            textBoxTIN = new TextBox();
            btnCancel = new Button();
            textBoxWeather = new TextBox();
            labelWeather = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalPrice).BeginInit();
            SuspendLayout();
            // 
            // cbProduct
            // 
            cbProduct.Anchor = AnchorStyles.None;
            cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProduct.Font = new Font("Microsoft Sans Serif", 15F);
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(233, 255);
            cbProduct.Margin = new Padding(2, 3, 2, 3);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(295, 37);
            cbProduct.TabIndex = 13;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 15F);
            nudQuantity.Location = new Point(234, 331);
            nudQuantity.Margin = new Padding(2, 3, 2, 3);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(297, 36);
            nudQuantity.TabIndex = 14;
            // 
            // labelTextVisualProduct
            // 
            labelTextVisualProduct.Anchor = AnchorStyles.None;
            labelTextVisualProduct.AutoSize = true;
            labelTextVisualProduct.BackColor = Color.Transparent;
            labelTextVisualProduct.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualProduct.ForeColor = Color.Black;
            labelTextVisualProduct.Location = new Point(68, 253);
            labelTextVisualProduct.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualProduct.Name = "labelTextVisualProduct";
            labelTextVisualProduct.Size = new Size(91, 37);
            labelTextVisualProduct.TabIndex = 16;
            labelTextVisualProduct.Text = "Товар";
            labelTextVisualProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTextVisualCountProduct
            // 
            labelTextVisualCountProduct.Anchor = AnchorStyles.None;
            labelTextVisualCountProduct.AutoSize = true;
            labelTextVisualCountProduct.BackColor = Color.Transparent;
            labelTextVisualCountProduct.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualCountProduct.ForeColor = Color.Black;
            labelTextVisualCountProduct.Location = new Point(68, 328);
            labelTextVisualCountProduct.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCountProduct.Name = "labelTextVisualCountProduct";
            labelTextVisualCountProduct.Size = new Size(161, 37);
            labelTextVisualCountProduct.TabIndex = 17;
            labelTextVisualCountProduct.Text = "Количество";
            labelTextVisualCountProduct.TextAlign = ContentAlignment.MiddleLeft;
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
            btnAdd.Location = new Point(128, 693);
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
            btnCreate.Location = new Point(1098, 693);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(285, 65);
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
            labelTextVisualShipment.Location = new Point(103, 68);
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
            labelPositions.Location = new Point(873, 51);
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
            textBox1.Location = new Point(604, 41);
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 204);
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
            dgvCart.Location = new Point(694, 172);
            dgvCart.Margin = new Padding(2, 3, 2, 3);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 72;
            dgvCart.RowTemplate.Height = 31;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(689, 455);
            dgvCart.TabIndex = 23;
            // 
            // labelTextVisualPrice
            // 
            labelTextVisualPrice.Anchor = AnchorStyles.None;
            labelTextVisualPrice.BackColor = Color.Transparent;
            labelTextVisualPrice.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualPrice.ForeColor = Color.Black;
            labelTextVisualPrice.Location = new Point(68, 378);
            labelTextVisualPrice.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualPrice.Name = "labelTextVisualPrice";
            labelTextVisualPrice.Size = new Size(136, 101);
            labelTextVisualPrice.TabIndex = 41;
            labelTextVisualPrice.Text = "Цена продажи";
            labelTextVisualPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudTotalPrice
            // 
            nudTotalPrice.Anchor = AnchorStyles.None;
            nudTotalPrice.Font = new Font("Microsoft Sans Serif", 15F);
            nudTotalPrice.Location = new Point(233, 413);
            nudTotalPrice.Margin = new Padding(2, 3, 2, 3);
            nudTotalPrice.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudTotalPrice.Name = "nudTotalPrice";
            nudTotalPrice.Size = new Size(297, 36);
            nudTotalPrice.TabIndex = 43;
            // 
            // labelTIN
            // 
            labelTIN.Anchor = AnchorStyles.None;
            labelTIN.AutoSize = true;
            labelTIN.BackColor = Color.Transparent;
            labelTIN.Font = new Font("Segoe UI", 15.75F);
            labelTIN.ForeColor = Color.Black;
            labelTIN.Location = new Point(68, 185);
            labelTIN.Margin = new Padding(2, 0, 2, 0);
            labelTIN.Name = "labelTIN";
            labelTIN.Size = new Size(75, 37);
            labelTIN.TabIndex = 44;
            labelTIN.Text = "ИНН";
            labelTIN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTIN
            // 
            textBoxTIN.Anchor = AnchorStyles.None;
            textBoxTIN.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTIN.Location = new Point(232, 185);
            textBoxTIN.MaximumSize = new Size(296, 37);
            textBoxTIN.MinimumSize = new Size(296, 37);
            textBoxTIN.Name = "textBoxTIN";
            textBoxTIN.ReadOnly = true;
            textBoxTIN.Size = new Size(296, 37);
            textBoxTIN.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 20;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(709, 693);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(285, 65);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // textBoxWeather
            // 
            textBoxWeather.Anchor = AnchorStyles.None;
            textBoxWeather.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxWeather.Location = new Point(234, 492);
            textBoxWeather.MaximumSize = new Size(296, 37);
            textBoxWeather.MinimumSize = new Size(296, 37);
            textBoxWeather.Name = "textBoxWeather";
            textBoxWeather.ReadOnly = true;
            textBoxWeather.Size = new Size(296, 37);
            textBoxWeather.TabIndex = 46;
            // 
            // labelWeather
            // 
            labelWeather.Anchor = AnchorStyles.None;
            labelWeather.AutoSize = true;
            labelWeather.BackColor = Color.Transparent;
            labelWeather.Font = new Font("Segoe UI", 15.75F);
            labelWeather.ForeColor = Color.Black;
            labelWeather.Location = new Point(70, 492);
            labelWeather.Margin = new Padding(2, 0, 2, 0);
            labelWeather.Name = "labelWeather";
            labelWeather.Size = new Size(107, 37);
            labelWeather.TabIndex = 47;
            labelWeather.Text = "Погода";
            labelWeather.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormShipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1472, 849);
            Controls.Add(textBoxWeather);
            Controls.Add(labelWeather);
            Controls.Add(btnCancel);
            Controls.Add(textBoxTIN);
            Controls.Add(labelTIN);
            Controls.Add(nudTotalPrice);
            Controls.Add(labelTextVisualPrice);
            Controls.Add(dgvCart);
            Controls.Add(textBox1);
            Controls.Add(labelPositions);
            Controls.Add(labelTextVisualShipment);
            Controls.Add(btnCreate);
            Controls.Add(btnAdd);
            Controls.Add(labelTextVisualCountProduct);
            Controls.Add(labelTextVisualProduct);
            Controls.Add(nudQuantity);
            Controls.Add(cbProduct);
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
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label labelTextVisualProduct;
        private System.Windows.Forms.Label labelTextVisualCountProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelTextVisualShipment;
        private System.Windows.Forms.Label labelPositions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvCart;
        private Label labelTextVisualPrice;
        private NumericUpDown nudTotalPrice;
        private Label labelTIN;
        private TextBox textBoxTIN;
        private Button btnCancel;
        private TextBox textBoxWeather;
        private Label labelWeather;
    }
}