namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormEditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCategory));
            labelTextVisualEditCategory = new Label();
            labelTextVisualNameCategory = new Label();
            cbCategory = new ComboBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // labelTextVisualEditCategory
            // 
            labelTextVisualEditCategory.Anchor = AnchorStyles.None;
            labelTextVisualEditCategory.AutoSize = true;
            labelTextVisualEditCategory.BackColor = Color.Transparent;
            labelTextVisualEditCategory.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualEditCategory.ForeColor = Color.Black;
            labelTextVisualEditCategory.Location = new Point(227, 89);
            labelTextVisualEditCategory.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualEditCategory.Name = "labelTextVisualEditCategory";
            labelTextVisualEditCategory.Size = new Size(451, 39);
            labelTextVisualEditCategory.TabIndex = 18;
            labelTextVisualEditCategory.Text = "Редактирование категории";
            labelTextVisualEditCategory.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTextVisualNameCategory
            // 
            labelTextVisualNameCategory.Anchor = AnchorStyles.None;
            labelTextVisualNameCategory.AutoSize = true;
            labelTextVisualNameCategory.BackColor = Color.Transparent;
            labelTextVisualNameCategory.Font = new Font("Microsoft Sans Serif", 19F);
            labelTextVisualNameCategory.ForeColor = Color.Black;
            labelTextVisualNameCategory.Location = new Point(196, 237);
            labelTextVisualNameCategory.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualNameCategory.Name = "labelTextVisualNameCategory";
            labelTextVisualNameCategory.Size = new Size(130, 30);
            labelTextVisualNameCategory.TabIndex = 20;
            labelTextVisualNameCategory.Text = "Название";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Microsoft Sans Serif", 17F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(352, 237);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(308, 37);
            cbCategory.TabIndex = 21;
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
            btnCancel.Location = new Point(31, 392);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(234, 54);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 20;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(608, 392);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(234, 54);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 20;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(608, 392);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(234, 54);
            btnSave.TabIndex = 25;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FormEditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 537);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(cbCategory);
            Controls.Add(labelTextVisualNameCategory);
            Controls.Add(labelTextVisualEditCategory);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormEditCategory";
            Text = "FormAddCategory";
            Load += FormEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextVisualEditCategory;
        private System.Windows.Forms.Label labelTextVisualNameCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}