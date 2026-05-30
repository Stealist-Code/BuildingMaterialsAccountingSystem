namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormSettings
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
            panelSettings = new Panel();
            buttonBack = new Button();
            textBoxDecorLine1 = new TextBox();
            buttonSettings = new Button();
            textBoxDecorLine2 = new TextBox();
            pictureBox1 = new PictureBox();
            labelGeneral = new Label();
            comboBoxLanguage = new ComboBox();
            labelLanguage = new Label();
            labelCurrency = new Label();
            comboBoxCurrency = new ComboBox();
            btnSave = new Button();
            btnClose = new Button();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.Gold;
            panelSettings.Controls.Add(buttonBack);
            panelSettings.Controls.Add(textBoxDecorLine1);
            panelSettings.Controls.Add(buttonSettings);
            panelSettings.Controls.Add(textBoxDecorLine2);
            panelSettings.Controls.Add(pictureBox1);
            panelSettings.Dock = DockStyle.Left;
            panelSettings.Location = new Point(0, 0);
            panelSettings.Margin = new Padding(3, 4, 3, 4);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(226, 663);
            panelSettings.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.None;
            buttonBack.BackColor = Color.Transparent;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBack.ImageAlign = ContentAlignment.TopCenter;
            buttonBack.Location = new Point(40, 20);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(160, 71);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxDecorLine1
            // 
            textBoxDecorLine1.BackColor = SystemColors.MenuText;
            textBoxDecorLine1.BorderStyle = BorderStyle.None;
            textBoxDecorLine1.Font = new Font("Segoe UI", 1F);
            textBoxDecorLine1.Location = new Point(40, 95);
            textBoxDecorLine1.Margin = new Padding(3, 4, 3, 4);
            textBoxDecorLine1.Name = "textBoxDecorLine1";
            textBoxDecorLine1.Size = new Size(143, 3);
            textBoxDecorLine1.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.None;
            buttonSettings.BackColor = Color.Transparent;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSettings.Location = new Point(40, 105);
            buttonSettings.Margin = new Padding(3, 4, 3, 4);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(143, 59);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "Общие";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // textBoxDecorLine2
            // 
            textBoxDecorLine2.BackColor = SystemColors.MenuText;
            textBoxDecorLine2.BorderStyle = BorderStyle.None;
            textBoxDecorLine2.Font = new Font("Segoe UI", 1F);
            textBoxDecorLine2.Location = new Point(40, 172);
            textBoxDecorLine2.Margin = new Padding(3, 4, 3, 4);
            textBoxDecorLine2.Name = "textBoxDecorLine2";
            textBoxDecorLine2.Size = new Size(143, 3);
            textBoxDecorLine2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Resources.Arrow;
            pictureBox1.Location = new Point(14, 47);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 40);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelGeneral
            // 
            labelGeneral.Anchor = AnchorStyles.None;
            labelGeneral.AutoSize = true;
            labelGeneral.BackColor = Color.Transparent;
            labelGeneral.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGeneral.Location = new Point(248, 20);
            labelGeneral.Name = "labelGeneral";
            labelGeneral.Size = new Size(180, 62);
            labelGeneral.TabIndex = 1;
            labelGeneral.Text = "Общие";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.Anchor = AnchorStyles.None;
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(430, 125);
            comboBoxLanguage.Margin = new Padding(3, 4, 3, 4);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(251, 40);
            comboBoxLanguage.TabIndex = 2;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // labelLanguage
            // 
            labelLanguage.Anchor = AnchorStyles.None;
            labelLanguage.AutoSize = true;
            labelLanguage.BackColor = Color.Transparent;
            labelLanguage.Font = new Font("Segoe UI", 20F);
            labelLanguage.Location = new Point(248, 116);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(96, 46);
            labelLanguage.TabIndex = 3;
            labelLanguage.Text = "Язык";
            // 
            // labelCurrency
            // 
            labelCurrency.Anchor = AnchorStyles.None;
            labelCurrency.AutoSize = true;
            labelCurrency.BackColor = Color.Transparent;
            labelCurrency.Font = new Font("Segoe UI", 20F);
            labelCurrency.Location = new Point(248, 207);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(133, 46);
            labelCurrency.TabIndex = 4;
            labelCurrency.Text = "Валюта";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.Anchor = AnchorStyles.None;
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(430, 216);
            comboBoxCurrency.Margin = new Padding(3, 4, 3, 4);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(251, 40);
            comboBoxCurrency.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.FromArgb(44, 44, 44);
            btnSave.FlatAppearance.BorderSize = 20;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(574, 529);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(322, 65);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить изменения";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(44, 44, 44);
            btnClose.FlatAppearance.BorderSize = 20;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(248, 529);
            btnClose.Margin = new Padding(2, 3, 2, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(259, 65);
            btnClose.TabIndex = 8;
            btnClose.Text = "Отменить";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(929, 663);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(comboBoxCurrency);
            Controls.Add(labelCurrency);
            Controls.Add(labelLanguage);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelGeneral);
            Controls.Add(panelSettings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSettings";
            Text = "Настройки";
            Load += FormSettings_Load;
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSettings;
        private TextBox textBoxDecorLine1;
        private TextBox textBoxDecorLine2;
        private Button buttonSettings;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private Label labelGeneral;
        private ComboBox comboBoxLanguage;
        private Label labelLanguage;
        private Label labelCurrency;
        private ComboBox comboBoxCurrency;
        private Button btnSave;
        private Button btnClose;
    }
}