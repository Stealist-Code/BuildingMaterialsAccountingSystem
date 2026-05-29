namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormDelivery
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
            labelDelivery = new Label();
            labelProduct = new Label();
            cbProducts = new ComboBox();
            labelExpirationDate = new Label();
            labelAmount = new Label();
            labelPurchasePrice = new Label();
            labelOr = new Label();
            labelUploadFile = new Label();
            pictureBox1 = new PictureBox();
            btnUpload = new Button();
            btnCancel = new Button();
            btnCreate = new Button();
            dtpExpirationDate = new DateTimePicker();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // labelDelivery
            // 
            labelDelivery.Anchor = AnchorStyles.None;
            labelDelivery.AutoSize = true;
            labelDelivery.BackColor = Color.Transparent;
            labelDelivery.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDelivery.Location = new Point(328, 55);
            labelDelivery.Name = "labelDelivery";
            labelDelivery.Size = new Size(341, 46);
            labelDelivery.TabIndex = 0;
            labelDelivery.Text = "Оформить поставку";
            // 
            // labelProduct
            // 
            labelProduct.Anchor = AnchorStyles.None;
            labelProduct.BackColor = Color.Transparent;
            labelProduct.Font = new Font("Segoe UI", 16F);
            labelProduct.Location = new Point(182, 179);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(274, 37);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "Товар";
            labelProduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbProducts
            // 
            cbProducts.Anchor = AnchorStyles.None;
            cbProducts.Font = new Font("Segoe UI", 15F);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(502, 173);
            cbProducts.Margin = new Padding(3, 4, 3, 4);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(282, 43);
            cbProducts.TabIndex = 2;
            // 
            // labelExpirationDate
            // 
            labelExpirationDate.Anchor = AnchorStyles.None;
            labelExpirationDate.BackColor = Color.Transparent;
            labelExpirationDate.Font = new Font("Segoe UI", 16F);
            labelExpirationDate.Location = new Point(156, 243);
            labelExpirationDate.Name = "labelExpirationDate";
            labelExpirationDate.Size = new Size(300, 37);
            labelExpirationDate.TabIndex = 3;
            labelExpirationDate.Text = "Годен до";
            labelExpirationDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.None;
            labelAmount.BackColor = Color.Transparent;
            labelAmount.Font = new Font("Segoe UI", 16F);
            labelAmount.Location = new Point(156, 314);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(316, 37);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Количество";
            labelAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPurchasePrice
            // 
            labelPurchasePrice.Anchor = AnchorStyles.None;
            labelPurchasePrice.BackColor = Color.Transparent;
            labelPurchasePrice.Font = new Font("Segoe UI", 16F);
            labelPurchasePrice.Location = new Point(135, 384);
            labelPurchasePrice.Name = "labelPurchasePrice";
            labelPurchasePrice.Size = new Size(337, 37);
            labelPurchasePrice.TabIndex = 7;
            labelPurchasePrice.Text = "Цена закупки";
            labelPurchasePrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelOr
            // 
            labelOr.Anchor = AnchorStyles.None;
            labelOr.AutoSize = true;
            labelOr.BackColor = Color.Transparent;
            labelOr.Font = new Font("Segoe UI", 16F);
            labelOr.Location = new Point(442, 463);
            labelOr.Name = "labelOr";
            labelOr.Size = new Size(63, 37);
            labelOr.TabIndex = 9;
            labelOr.Text = "или";
            // 
            // labelUploadFile
            // 
            labelUploadFile.Anchor = AnchorStyles.None;
            labelUploadFile.AutoSize = true;
            labelUploadFile.BackColor = Color.Transparent;
            labelUploadFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUploadFile.Location = new Point(328, 629);
            labelUploadFile.Name = "labelUploadFile";
            labelUploadFile.Size = new Size(338, 32);
            labelUploadFile.TabIndex = 11;
            labelUploadFile.Text = "Загрузите файл с поставками";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.DownloadFon;
            pictureBox1.Location = new Point(307, 526);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 144);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.None;
            btnUpload.AutoSize = true;
            btnUpload.BackColor = Color.FromArgb(44, 44, 44);
            btnUpload.FlatAppearance.BorderSize = 20;
            btnUpload.FlatStyle = FlatStyle.Popup;
            btnUpload.Font = new Font("Segoe UI", 14F);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(363, 556);
            btnUpload.Margin = new Padding(2, 3, 2, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(189, 47);
            btnUpload.TabIndex = 13;
            btnUpload.Text = "Загрузить";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(44, 44, 44);
            btnCancel.FlatAppearance.BorderSize = 20;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 16F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(17, 712);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(393, 47);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.AutoSize = true;
            btnCreate.BackColor = Color.FromArgb(44, 44, 44);
            btnCreate.FlatAppearance.BorderSize = 20;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 16F);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(513, 712);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(393, 47);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Anchor = AnchorStyles.None;
            dtpExpirationDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpExpirationDate.Font = new Font("Segoe UI", 15F);
            dtpExpirationDate.Location = new Point(502, 240);
            dtpExpirationDate.Margin = new Padding(3, 4, 3, 4);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(282, 41);
            dtpExpirationDate.TabIndex = 16;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 15F);
            nudQuantity.Location = new Point(502, 318);
            nudQuantity.Margin = new Padding(2, 3, 2, 3);
            nudQuantity.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(282, 36);
            nudQuantity.TabIndex = 44;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.None;
            nudPrice.Font = new Font("Microsoft Sans Serif", 15F);
            nudPrice.Location = new Point(502, 388);
            nudPrice.Margin = new Padding(2, 3, 2, 3);
            nudPrice.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(282, 36);
            nudPrice.TabIndex = 45;
            // 
            // FormDelivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(929, 795);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(dtpExpirationDate);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(btnUpload);
            Controls.Add(labelUploadFile);
            Controls.Add(labelOr);
            Controls.Add(labelPurchasePrice);
            Controls.Add(labelAmount);
            Controls.Add(labelExpirationDate);
            Controls.Add(cbProducts);
            Controls.Add(labelProduct);
            Controls.Add(labelDelivery);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDelivery";
            Text = "Поставки";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDelivery;
        private Label labelProduct;
        private ComboBox cbProducts;
        private Label labelExpirationDate;
        private Label labelAmount;
        private Label labelPurchasePrice;
        private Label labelOr;
        private Label labelUploadFile;
        private PictureBox pictureBox1;
        private Button btnUpload;
        private Button btnCancel;
        private Button btnCreate;
        private DateTimePicker dtpExpirationDate;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
    }
}