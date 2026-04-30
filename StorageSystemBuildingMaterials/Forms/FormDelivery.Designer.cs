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
            labelDelivery.AutoSize = true;
            labelDelivery.BackColor = Color.Transparent;
            labelDelivery.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDelivery.Location = new Point(263, 34);
            labelDelivery.Name = "labelDelivery";
            labelDelivery.Size = new Size(272, 37);
            labelDelivery.TabIndex = 0;
            labelDelivery.Text = "Оформить поставку";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.BackColor = Color.Transparent;
            labelProduct.Font = new Font("Segoe UI", 16F);
            labelProduct.Location = new Point(197, 105);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(74, 30);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "Товар";
            // 
            // cbProducts
            // 
            cbProducts.Font = new Font("Segoe UI", 15F);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(359, 106);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(247, 36);
            cbProducts.TabIndex = 2;
            // 
            // labelExpirationDate
            // 
            labelExpirationDate.AutoSize = true;
            labelExpirationDate.BackColor = Color.Transparent;
            labelExpirationDate.Font = new Font("Segoe UI", 16F);
            labelExpirationDate.Location = new Point(197, 165);
            labelExpirationDate.Name = "labelExpirationDate";
            labelExpirationDate.Size = new Size(104, 30);
            labelExpirationDate.TabIndex = 3;
            labelExpirationDate.Text = "Годен до";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.BackColor = Color.Transparent;
            labelAmount.Font = new Font("Segoe UI", 16F);
            labelAmount.Location = new Point(197, 225);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(132, 30);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Количество";
            // 
            // labelPurchasePrice
            // 
            labelPurchasePrice.AutoSize = true;
            labelPurchasePrice.BackColor = Color.Transparent;
            labelPurchasePrice.Font = new Font("Segoe UI", 16F);
            labelPurchasePrice.Location = new Point(197, 285);
            labelPurchasePrice.Name = "labelPurchasePrice";
            labelPurchasePrice.Size = new Size(151, 30);
            labelPurchasePrice.TabIndex = 7;
            labelPurchasePrice.Text = "Цена закупки";
            // 
            // labelOr
            // 
            labelOr.AutoSize = true;
            labelOr.BackColor = Color.Transparent;
            labelOr.Font = new Font("Segoe UI", 16F);
            labelOr.Location = new Point(369, 338);
            labelOr.Name = "labelOr";
            labelOr.Size = new Size(51, 30);
            labelOr.TabIndex = 9;
            labelOr.Text = "или";
            // 
            // labelUploadFile
            // 
            labelUploadFile.AutoSize = true;
            labelUploadFile.BackColor = Color.Transparent;
            labelUploadFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUploadFile.Location = new Point(263, 438);
            labelUploadFile.Name = "labelUploadFile";
            labelUploadFile.Size = new Size(266, 25);
            labelUploadFile.TabIndex = 11;
            labelUploadFile.Text = "Загрузите файл с поставками";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.DownloadFon;
            pictureBox1.Location = new Point(240, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 108);
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
            btnUpload.Location = new Point(310, 394);
            btnUpload.Margin = new Padding(2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(165, 35);
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
            btnCancel.Location = new Point(30, 499);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(295, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
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
            btnCreate.Location = new Point(473, 499);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(295, 40);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpExpirationDate.Font = new Font("Segoe UI", 15F);
            dtpExpirationDate.Location = new Point(359, 165);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(247, 34);
            dtpExpirationDate.TabIndex = 16;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 15F);
            nudQuantity.Location = new Point(359, 227);
            nudQuantity.Margin = new Padding(2);
            nudQuantity.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(247, 30);
            nudQuantity.TabIndex = 44;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.None;
            nudPrice.Font = new Font("Microsoft Sans Serif", 15F);
            nudPrice.Location = new Point(359, 287);
            nudPrice.Margin = new Padding(2);
            nudPrice.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(247, 30);
            nudPrice.TabIndex = 45;
            // 
            // FormDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.Fon;
            ClientSize = new Size(813, 560);
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
            Name = "FormDelivery";
            Text = "Поставки";
            Load += FormDelivery_Load;
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