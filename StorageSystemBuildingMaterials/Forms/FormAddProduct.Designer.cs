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
            labelInsurance = new Label();
            labelThermal = new Label();
            comboBoxInsurance = new ComboBox();
            comboBoxThermal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            btnCancel.Location = new Point(38, 583);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(399, 49);
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
            btnOK.Location = new Point(537, 583);
            btnOK.Margin = new Padding(2, 3, 2, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(399, 49);
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
            labelTextVisualAddProduct.Location = new Point(329, 35);
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
            labelTextVisualName.Location = new Point(236, 121);
            labelTextVisualName.Location = new Point(228, 135);
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
            labelTextVisualCategory.Location = new Point(229, 207);
            labelTextVisualCategory.Location = new Point(228, 202);
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
            labelTextVisualUnit.Location = new Point(220, 284);
            labelTextVisualUnit.Location = new Point(228, 271);
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
            labelTextVisualUnit2.Location = new Point(235, 442);
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
            cbCategory.Location = new Point(458, 204);
            cbCategory.Location = new Point(454, 194);
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
            txtName.Location = new Point(458, 121);
            txtName.Location = new Point(454, 112);
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
            comboBoxUnit.Location = new Point(455, 276);
            comboBoxUnit.Location = new Point(454, 271);
            comboBoxUnit.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(314, 39);
            comboBoxUnit.TabIndex = 26;
            // 
            // labelInsurance
            // 
            labelInsurance.Anchor = AnchorStyles.None;
            labelInsurance.AutoSize = true;
            labelInsurance.BackColor = Color.Transparent;
            labelInsurance.Font = new Font("Microsoft Sans Serif", 16F);
            labelInsurance.ForeColor = Color.Black;
            labelInsurance.Location = new Point(235, 364);
            labelInsurance.Margin = new Padding(2, 0, 2, 0);
            labelInsurance.Name = "labelInsurance";
            labelInsurance.Size = new Size(147, 31);
            labelInsurance.TabIndex = 27;
            labelInsurance.Text = "Страховка";
            // 
            // labelThermal
            // 
            labelThermal.Anchor = AnchorStyles.None;
            labelThermal.AutoSize = true;
            labelThermal.BackColor = Color.Transparent;
            labelThermal.Font = new Font("Microsoft Sans Serif", 16F);
            labelThermal.ForeColor = Color.Black;
            labelThermal.Location = new Point(195, 433);
            labelThermal.Margin = new Padding(2, 0, 2, 0);
            labelThermal.Name = "labelThermal";
            labelThermal.Size = new Size(226, 31);
            labelThermal.TabIndex = 28;
            labelThermal.Text = "Термоконтейнер";
            // 
            // comboBoxInsurance
            // 
            comboBoxInsurance.Anchor = AnchorStyles.None;
            comboBoxInsurance.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInsurance.Font = new Font("Microsoft Sans Serif", 16F);
            comboBoxInsurance.FormattingEnabled = true;
            comboBoxInsurance.IntegralHeight = false;
            comboBoxInsurance.ItemHeight = 31;
            comboBoxInsurance.Location = new Point(455, 356);
            comboBoxInsurance.Margin = new Padding(2, 3, 2, 3);
            comboBoxInsurance.Name = "comboBoxInsurance";
            comboBoxInsurance.Size = new Size(311, 39);
            comboBoxInsurance.TabIndex = 29;
            // 
            // comboBoxThermal
            // 
            comboBoxThermal.Anchor = AnchorStyles.None;
            comboBoxThermal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThermal.Font = new Font("Microsoft Sans Serif", 16F);
            comboBoxThermal.FormattingEnabled = true;
            comboBoxThermal.IntegralHeight = false;
            comboBoxThermal.ItemHeight = 31;
            comboBoxThermal.Location = new Point(455, 433);
            comboBoxThermal.Margin = new Padding(2, 3, 2, 3);
            comboBoxThermal.Name = "comboBoxThermal";
            comboBoxThermal.Size = new Size(311, 39);
            comboBoxThermal.TabIndex = 30;
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(192, 344);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 27;
            label1.Text = "Термоконтейнер";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(235, 406);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 31);
            label2.TabIndex = 28;
            label2.Text = "Страховка";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 16F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 31;
            comboBox1.Location = new Point(454, 341);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 39);
            comboBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Microsoft Sans Serif", 16F);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.ItemHeight = 31;
            comboBox2.Location = new Point(454, 406);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(314, 39);
            comboBox2.TabIndex = 30;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(969, 731);
            Controls.Add(comboBoxThermal);
            Controls.Add(comboBoxInsurance);
            Controls.Add(labelThermal);
            Controls.Add(labelInsurance);
            ClientSize = new Size(969, 597);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label labelInsurance;
        private Label labelThermal;
        private ComboBox comboBoxInsurance;
        private ComboBox comboBoxThermal;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}