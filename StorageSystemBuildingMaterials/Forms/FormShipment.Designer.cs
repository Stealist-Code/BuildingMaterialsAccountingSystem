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
            labelTextVisualSelling = new Label();
            nudTotalPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalPrice).BeginInit();
            SuspendLayout();
            // 
            // cbProduct
            // 
            cbProduct.Anchor = AnchorStyles.None;
            cbProduct.Font = new Font("Microsoft Sans Serif", 15F);
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(466, 183);
            cbProduct.Margin = new Padding(2, 3, 2, 3);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(295, 37);
            cbProduct.TabIndex = 13;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 15F);
            nudQuantity.Location = new Point(465, 259);
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
            labelTextVisualProduct.Location = new Point(291, 182);
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
            labelTextVisualCountProduct.Location = new Point(291, 257);
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
            // labelTextVisualPrice
            // 
            labelTextVisualPrice.Anchor = AnchorStyles.None;
            labelTextVisualPrice.AutoSize = true;
            labelTextVisualPrice.BackColor = Color.Transparent;
            labelTextVisualPrice.Font = new Font("Segoe UI", 15.75F);
            labelTextVisualPrice.ForeColor = Color.Black;
            labelTextVisualPrice.Location = new Point(291, 324);
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
            labelTextVisualSelling.Location = new Point(291, 361);
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
            nudTotalPrice.Location = new Point(464, 340);
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
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1650, 849);
            Controls.Add(nudTotalPrice);
            Controls.Add(labelTextVisualSelling);
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
        private Label labelTextVisualSelling;
        private NumericUpDown nudTotalPrice;
    }
}