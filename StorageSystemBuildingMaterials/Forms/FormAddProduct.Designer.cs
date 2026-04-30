namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            btnCancel = new Button();
            btnOK = new Button();
            nudPrice = new NumericUpDown();
            labelTextVisualAddProduct = new Label();
            labelTextVisualName = new Label();
            labelTextVisualCategory = new Label();
            labelTextVisualPrice = new Label();
            labelTextVisualUnit = new Label();
            labelTextVisualUnit2 = new Label();
            cbCategory = new ComboBox();
            txtName = new TextBox();
            dtpExpirationDate = new DateTimePicker();
            labelTextVisualDateTo = new Label();
            comboBoxUnit = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
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
            btnCancel.Location = new Point(119, 469);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(257, 55);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.None;
            btnOK.AutoSize = true;
            btnOK.BackColor = Color.Black;
            btnOK.FlatAppearance.BorderSize = 20;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(473, 468);
            btnOK.Margin = new Padding(2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(257, 56);
            btnOK.TabIndex = 6;
            btnOK.Text = "Добавить";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.None;
            nudPrice.Font = new Font("Microsoft Sans Serif", 16F);
            nudPrice.Location = new Point(400, 255);
            nudPrice.Margin = new Padding(2);
            nudPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(273, 32);
            nudPrice.TabIndex = 15;
            // 
            // labelTextVisualAddProduct
            // 
            labelTextVisualAddProduct.Anchor = AnchorStyles.None;
            labelTextVisualAddProduct.AutoSize = true;
            labelTextVisualAddProduct.BackColor = Color.Transparent;
            labelTextVisualAddProduct.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualAddProduct.ForeColor = Color.Black;
            labelTextVisualAddProduct.Location = new Point(292, 38);
            labelTextVisualAddProduct.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualAddProduct.Name = "labelTextVisualAddProduct";
            labelTextVisualAddProduct.Size = new Size(271, 39);
            labelTextVisualAddProduct.TabIndex = 17;
            labelTextVisualAddProduct.Text = "Добавить товар";
            // 
            // labelTextVisualName
            // 
            labelTextVisualName.Anchor = AnchorStyles.None;
            labelTextVisualName.AutoSize = true;
            labelTextVisualName.BackColor = Color.Transparent;
            labelTextVisualName.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualName.ForeColor = Color.Black;
            labelTextVisualName.Location = new Point(206, 132);
            labelTextVisualName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualName.Name = "labelTextVisualName";
            labelTextVisualName.Size = new Size(111, 26);
            labelTextVisualName.TabIndex = 19;
            labelTextVisualName.Text = "Название";
            // 
            // labelTextVisualCategory
            // 
            labelTextVisualCategory.Anchor = AnchorStyles.None;
            labelTextVisualCategory.AutoSize = true;
            labelTextVisualCategory.BackColor = Color.Transparent;
            labelTextVisualCategory.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualCategory.ForeColor = Color.Black;
            labelTextVisualCategory.Location = new Point(206, 193);
            labelTextVisualCategory.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCategory.Name = "labelTextVisualCategory";
            labelTextVisualCategory.Size = new Size(117, 26);
            labelTextVisualCategory.TabIndex = 20;
            labelTextVisualCategory.Text = "Категория";
            // 
            // labelTextVisualPrice
            // 
            labelTextVisualPrice.Anchor = AnchorStyles.None;
            labelTextVisualPrice.AutoSize = true;
            labelTextVisualPrice.BackColor = Color.Transparent;
            labelTextVisualPrice.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualPrice.ForeColor = Color.Black;
            labelTextVisualPrice.Location = new Point(206, 257);
            labelTextVisualPrice.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualPrice.Name = "labelTextVisualPrice";
            labelTextVisualPrice.Size = new Size(150, 26);
            labelTextVisualPrice.TabIndex = 21;
            labelTextVisualPrice.Text = "Цена закупки";
            // 
            // labelTextVisualUnit
            // 
            labelTextVisualUnit.Anchor = AnchorStyles.None;
            labelTextVisualUnit.AutoSize = true;
            labelTextVisualUnit.BackColor = Color.Transparent;
            labelTextVisualUnit.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualUnit.ForeColor = Color.Black;
            labelTextVisualUnit.Location = new Point(206, 324);
            labelTextVisualUnit.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualUnit.Name = "labelTextVisualUnit";
            labelTextVisualUnit.Size = new Size(163, 26);
            labelTextVisualUnit.TabIndex = 22;
            labelTextVisualUnit.Text = "Ед. измерения";
            // 
            // labelTextVisualUnit2
            // 
            labelTextVisualUnit2.Anchor = AnchorStyles.None;
            labelTextVisualUnit2.AutoSize = true;
            labelTextVisualUnit2.BackColor = Color.Transparent;
            labelTextVisualUnit2.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualUnit2.ForeColor = Color.Black;
            labelTextVisualUnit2.Location = new Point(206, 337);
            labelTextVisualUnit2.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualUnit2.Name = "labelTextVisualUnit2";
            labelTextVisualUnit2.Size = new Size(0, 26);
            labelTextVisualUnit2.TabIndex = 23;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Microsoft Sans Serif", 16F);
            cbCategory.FormattingEnabled = true;
            cbCategory.IntegralHeight = false;
            cbCategory.ItemHeight = 25;
            cbCategory.Location = new Point(400, 190);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(273, 33);
            cbCategory.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Microsoft Sans Serif", 16F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(400, 129);
            txtName.Margin = new Padding(2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(273, 33);
            txtName.TabIndex = 11;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.CalendarFont = new Font("Segoe UI", 16F);
            dtpExpirationDate.Font = new Font("Microsoft Sans Serif", 16F);
            dtpExpirationDate.Location = new Point(400, 384);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(275, 32);
            dtpExpirationDate.TabIndex = 24;
            // 
            // labelTextVisualDateTo
            // 
            labelTextVisualDateTo.Anchor = AnchorStyles.None;
            labelTextVisualDateTo.AutoSize = true;
            labelTextVisualDateTo.BackColor = Color.Transparent;
            labelTextVisualDateTo.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualDateTo.ForeColor = Color.Black;
            labelTextVisualDateTo.Location = new Point(206, 390);
            labelTextVisualDateTo.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualDateTo.Name = "labelTextVisualDateTo";
            labelTextVisualDateTo.Size = new Size(104, 26);
            labelTextVisualDateTo.TabIndex = 25;
            labelTextVisualDateTo.Text = "Годен до";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.Font = new Font("Microsoft Sans Serif", 16F);
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(400, 321);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(275, 33);
            comboBoxUnit.TabIndex = 26;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(848, 558);
            Controls.Add(comboBoxUnit);
            Controls.Add(labelTextVisualDateTo);
            Controls.Add(dtpExpirationDate);
            Controls.Add(txtName);
            Controls.Add(cbCategory);
            Controls.Add(labelTextVisualUnit2);
            Controls.Add(labelTextVisualUnit);
            Controls.Add(labelTextVisualPrice);
            Controls.Add(labelTextVisualCategory);
            Controls.Add(labelTextVisualName);
            Controls.Add(labelTextVisualAddProduct);
            Controls.Add(nudPrice);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormAddProduct";
            Text = "AddGood";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label labelTextVisualAddProduct;
        private System.Windows.Forms.Label labelTextVisualName;
        private System.Windows.Forms.Label labelTextVisualCategory;
        private System.Windows.Forms.Label labelTextVisualPrice;
        private System.Windows.Forms.Label labelTextVisualUnit;
        private System.Windows.Forms.Label labelTextVisualUnit2;
        private ComboBox cbCategory;
        private TextBox txtName;
        private DateTimePicker dtpExpirationDate;
        private Label labelTextVisualDateTo;
        private ComboBox comboBoxUnit;
    }
}