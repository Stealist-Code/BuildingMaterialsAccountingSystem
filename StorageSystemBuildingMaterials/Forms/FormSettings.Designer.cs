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
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.LightGray;
            panelSettings.Controls.Add(buttonBack);
            panelSettings.Controls.Add(textBoxDecorLine1);
            panelSettings.Controls.Add(buttonSettings);
            panelSettings.Controls.Add(textBoxDecorLine2);
            panelSettings.Controls.Add(pictureBox1);
            panelSettings.Dock = DockStyle.Left;
            panelSettings.Location = new Point(0, 0);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(198, 497);
            panelSettings.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Transparent;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBack.ImageAlign = ContentAlignment.TopCenter;
            buttonBack.Location = new Point(35, 15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(140, 53);
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
            textBoxDecorLine1.Location = new Point(35, 71);
            textBoxDecorLine1.Name = "textBoxDecorLine1";
            textBoxDecorLine1.Size = new Size(125, 2);
            textBoxDecorLine1.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.Transparent;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSettings.Location = new Point(35, 79);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(125, 44);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "Общие";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // textBoxDecorLine2
            // 
            textBoxDecorLine2.BackColor = SystemColors.MenuText;
            textBoxDecorLine2.BorderStyle = BorderStyle.None;
            textBoxDecorLine2.Font = new Font("Segoe UI", 1F);
            textBoxDecorLine2.Location = new Point(35, 129);
            textBoxDecorLine2.Name = "textBoxDecorLine2";
            textBoxDecorLine2.Size = new Size(125, 2);
            textBoxDecorLine2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Arrow;
            pictureBox1.Location = new Point(12, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 30);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelGeneral
            // 
            labelGeneral.AutoSize = true;
            labelGeneral.BackColor = Color.Transparent;
            labelGeneral.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGeneral.Location = new Point(217, 15);
            labelGeneral.Name = "labelGeneral";
            labelGeneral.Size = new Size(143, 50);
            labelGeneral.TabIndex = 1;
            labelGeneral.Text = "Общие";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(376, 94);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(220, 33);
            comboBoxLanguage.TabIndex = 2;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.BackColor = Color.Transparent;
            labelLanguage.Font = new Font("Segoe UI", 20F);
            labelLanguage.Location = new Point(217, 87);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(77, 37);
            labelLanguage.TabIndex = 3;
            labelLanguage.Text = "Язык";
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.BackColor = Color.Transparent;
            labelCurrency.Font = new Font("Segoe UI", 20F);
            labelCurrency.Location = new Point(217, 155);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(107, 37);
            labelCurrency.TabIndex = 4;
            labelCurrency.Text = "Валюта";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(376, 162);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(220, 33);
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
            btnSave.Location = new Point(230, 396);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(276, 49);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить изменения";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.Fon;
            ClientSize = new Size(813, 497);
            Controls.Add(btnSave);
            Controls.Add(comboBoxCurrency);
            Controls.Add(labelCurrency);
            Controls.Add(labelLanguage);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelGeneral);
            Controls.Add(panelSettings);
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
    }
}