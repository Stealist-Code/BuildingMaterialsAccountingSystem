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
            labelTextVisualAddProduct = new Label();
            labelTextVisualName = new Label();
            labelTextVisualCategory = new Label();
            labelTextVisualUnit = new Label();
            labelTextVisualUnit2 = new Label();
            cbCategory = new ComboBox();
            txtName = new TextBox();
            comboBoxUnit = new ComboBox();
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
            btnCancel.Location = new Point(136, 452);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(294, 61);
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
            btnOK.Location = new Point(541, 452);
            btnOK.Margin = new Padding(2, 3, 2, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(294, 62);
            btnOK.TabIndex = 6;
            btnOK.Text = "Добавить";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // labelTextVisualAddProduct
            // 
            labelTextVisualAddProduct.Anchor = AnchorStyles.None;
            labelTextVisualAddProduct.AutoSize = true;
            labelTextVisualAddProduct.BackColor = Color.Transparent;
            labelTextVisualAddProduct.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualAddProduct.ForeColor = Color.Black;
            labelTextVisualAddProduct.Location = new Point(328, 57);
            labelTextVisualAddProduct.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualAddProduct.Name = "labelTextVisualAddProduct";
            labelTextVisualAddProduct.Size = new Size(330, 48);
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
            labelTextVisualName.Location = new Point(229, 182);
            labelTextVisualName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualName.Name = "labelTextVisualName";
            labelTextVisualName.Size = new Size(137, 31);
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
            labelTextVisualCategory.Location = new Point(229, 263);
            labelTextVisualCategory.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCategory.Name = "labelTextVisualCategory";
            labelTextVisualCategory.Size = new Size(144, 31);
            labelTextVisualCategory.TabIndex = 20;
            labelTextVisualCategory.Text = "Категория";
            // 
            // labelTextVisualUnit
            // 
            labelTextVisualUnit.Anchor = AnchorStyles.None;
            labelTextVisualUnit.AutoSize = true;
            labelTextVisualUnit.BackColor = Color.Transparent;
            labelTextVisualUnit.Font = new Font("Microsoft Sans Serif", 16F);
            labelTextVisualUnit.ForeColor = Color.Black;
            labelTextVisualUnit.Location = new Point(229, 338);
            labelTextVisualUnit.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualUnit.Name = "labelTextVisualUnit";
            labelTextVisualUnit.Size = new Size(201, 31);
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
            labelTextVisualUnit2.Location = new Point(235, 355);
            labelTextVisualUnit2.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualUnit2.Name = "labelTextVisualUnit2";
            labelTextVisualUnit2.Size = new Size(0, 31);
            labelTextVisualUnit2.TabIndex = 23;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Microsoft Sans Serif", 16F);
            cbCategory.FormattingEnabled = true;
            cbCategory.IntegralHeight = false;
            cbCategory.ItemHeight = 31;
            cbCategory.Location = new Point(451, 259);
            cbCategory.Margin = new Padding(2, 3, 2, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(311, 39);
            cbCategory.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Microsoft Sans Serif", 16F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(451, 178);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(311, 43);
            txtName.TabIndex = 11;
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.Anchor = AnchorStyles.None;
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.Font = new Font("Microsoft Sans Serif", 16F);
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.IntegralHeight = false;
            comboBoxUnit.ItemHeight = 31;
            comboBoxUnit.Location = new Point(451, 330);
            comboBoxUnit.Margin = new Padding(2, 3, 2, 3);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(311, 39);
            comboBoxUnit.TabIndex = 27;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(969, 556);
            Controls.Add(comboBoxUnit);
            Controls.Add(txtName);
            Controls.Add(cbCategory);
            Controls.Add(labelTextVisualUnit2);
            Controls.Add(labelTextVisualUnit);
            Controls.Add(labelTextVisualCategory);
            Controls.Add(labelTextVisualName);
            Controls.Add(labelTextVisualAddProduct);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormAddProduct";
            Text = "AddGood";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelTextVisualAddProduct;
        private System.Windows.Forms.Label labelTextVisualName;
        private System.Windows.Forms.Label labelTextVisualCategory;
        private System.Windows.Forms.Label labelTextVisualUnit;
        private System.Windows.Forms.Label labelTextVisualUnit2;
        private ComboBox cbCategory;
        private TextBox txtName;
        private ComboBox comboBoxUnit;
    }
}