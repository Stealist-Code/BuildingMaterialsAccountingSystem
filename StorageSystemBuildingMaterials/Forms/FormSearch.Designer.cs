namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            btnCancel = new Button();
            btnSearch = new Button();
            labelTextVisualSearch = new Label();
            txtArticle = new TextBox();
            txtName = new TextBox();
            cbCategory = new ComboBox();
            labelTextVisualArticle = new Label();
            labelTextVisualProductName = new Label();
            labelCategory = new Label();
            labelART = new Label();
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
            btnCancel.Location = new Point(55, 421);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(298, 54);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatAppearance.BorderSize = 20;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(499, 421);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(305, 54);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // labelTextVisualSearch
            // 
            labelTextVisualSearch.Anchor = AnchorStyles.None;
            labelTextVisualSearch.AutoSize = true;
            labelTextVisualSearch.BackColor = Color.Transparent;
            labelTextVisualSearch.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualSearch.ForeColor = Color.Black;
            labelTextVisualSearch.Location = new Point(373, 23);
            labelTextVisualSearch.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualSearch.Name = "labelTextVisualSearch";
            labelTextVisualSearch.Size = new Size(114, 39);
            labelTextVisualSearch.TabIndex = 9;
            labelTextVisualSearch.Text = "Поиск";
            // 
            // txtArticle
            // 
            txtArticle.Anchor = AnchorStyles.None;
            txtArticle.BackColor = Color.White;
            txtArticle.Font = new Font("Microsoft Sans Serif", 15F);
            txtArticle.ForeColor = Color.Black;
            txtArticle.Location = new Point(346, 154);
            txtArticle.Margin = new Padding(2);
            txtArticle.Multiline = true;
            txtArticle.Name = "txtArticle";
            txtArticle.RightToLeft = RightToLeft.No;
            txtArticle.Size = new Size(304, 33);
            txtArticle.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Microsoft Sans Serif", 15F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(346, 226);
            txtName.Margin = new Padding(2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(304, 33);
            txtName.TabIndex = 11;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Microsoft Sans Serif", 15F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(346, 298);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(304, 33);
            cbCategory.TabIndex = 12;
            // 
            // labelTextVisualArticle
            // 
            labelTextVisualArticle.Anchor = AnchorStyles.None;
            labelTextVisualArticle.AutoSize = true;
            labelTextVisualArticle.BackColor = Color.Transparent;
            labelTextVisualArticle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualArticle.ForeColor = Color.Black;
            labelTextVisualArticle.Location = new Point(190, 157);
            labelTextVisualArticle.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualArticle.Name = "labelTextVisualArticle";
            labelTextVisualArticle.Size = new Size(96, 26);
            labelTextVisualArticle.TabIndex = 13;
            labelTextVisualArticle.Text = "Артикул";
            // 
            // labelTextVisualProductName
            // 
            labelTextVisualProductName.Anchor = AnchorStyles.None;
            labelTextVisualProductName.AutoSize = true;
            labelTextVisualProductName.BackColor = Color.Transparent;
            labelTextVisualProductName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualProductName.ForeColor = Color.Black;
            labelTextVisualProductName.Location = new Point(190, 229);
            labelTextVisualProductName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualProductName.Name = "labelTextVisualProductName";
            labelTextVisualProductName.Size = new Size(111, 26);
            labelTextVisualProductName.TabIndex = 14;
            labelTextVisualProductName.Text = "Название";
            // 
            // labelCategory
            // 
            labelCategory.Anchor = AnchorStyles.None;
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCategory.ForeColor = Color.Black;
            labelCategory.Location = new Point(190, 301);
            labelCategory.Margin = new Padding(2, 0, 2, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(117, 26);
            labelCategory.TabIndex = 15;
            labelCategory.Text = "Категория";
            // 
            // labelART
            // 
            labelART.Anchor = AnchorStyles.None;
            labelART.AutoSize = true;
            labelART.BackColor = Color.Transparent;
            labelART.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelART.ForeColor = Color.Black;
            labelART.Location = new Point(280, 157);
            labelART.Margin = new Padding(2, 0, 2, 0);
            labelART.Name = "labelART";
            labelART.Size = new Size(62, 26);
            labelART.TabIndex = 16;
            labelART.Text = "ART-";
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 567);
            Controls.Add(labelART);
            Controls.Add(labelCategory);
            Controls.Add(labelTextVisualProductName);
            Controls.Add(labelTextVisualArticle);
            Controls.Add(cbCategory);
            Controls.Add(txtName);
            Controls.Add(txtArticle);
            Controls.Add(labelTextVisualSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnCancel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormSearch";
            Text = "Search";
            Load += FormSearch_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelTextVisualSearch;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label labelTextVisualArticle;
        private System.Windows.Forms.Label labelTextVisualProductName;
        private System.Windows.Forms.Label labelCategory;
        private Label labelART;
    }
}