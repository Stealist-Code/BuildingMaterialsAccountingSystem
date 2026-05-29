namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormRegister
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMiddleName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            buttonRegister = new Button();
            labelTextVisualFirstName = new Label();
            labelTextVisualLastName = new Label();
            labelTextVisualPatronymic = new Label();
            labelTextVisualEmail = new Label();
            labelTextVisualPassword = new Label();
            labelTextVisualCheckPassword = new Label();
            labeRegistration = new Label();
            buttonRegisrationINAuth = new Button();
            errorProvider = new ErrorProvider(components);
            labelAccount = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.None;
            textBoxFirstName.BackColor = Color.White;
            textBoxFirstName.Font = new Font("Microsoft Sans Serif", 15F);
            textBoxFirstName.Location = new Point(595, 192);
            textBoxFirstName.Margin = new Padding(2, 3, 2, 3);
            textBoxFirstName.Multiline = true;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(313, 52);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.None;
            textBoxLastName.BackColor = Color.White;
            textBoxLastName.Font = new Font("Microsoft Sans Serif", 15F);
            textBoxLastName.Location = new Point(595, 284);
            textBoxLastName.Margin = new Padding(2, 3, 2, 3);
            textBoxLastName.Multiline = true;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(313, 52);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Anchor = AnchorStyles.None;
            textBoxMiddleName.BackColor = Color.White;
            textBoxMiddleName.Font = new Font("Microsoft Sans Serif", 15F);
            textBoxMiddleName.Location = new Point(595, 376);
            textBoxMiddleName.Margin = new Padding(2, 3, 2, 3);
            textBoxMiddleName.Multiline = true;
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(313, 52);
            textBoxMiddleName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 15F);
            textBoxEmail.Location = new Point(595, 471);
            textBoxEmail.Margin = new Padding(2, 3, 2, 3);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(313, 52);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 15F);
            textBoxPassword.Location = new Point(595, 563);
            textBoxPassword.Margin = new Padding(2, 3, 2, 3);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(313, 52);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.None;
            textBoxConfirmPassword.BackColor = Color.White;
            textBoxConfirmPassword.Font = new Font("Microsoft Sans Serif", 15F);
            textBoxConfirmPassword.Location = new Point(595, 656);
            textBoxConfirmPassword.Margin = new Padding(2, 3, 2, 3);
            textBoxConfirmPassword.Multiline = true;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(313, 52);
            textBoxConfirmPassword.TabIndex = 5;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.BackColor = Color.Black;
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(373, 839);
            buttonRegister.Margin = new Padding(2, 3, 2, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(501, 91);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelTextVisualFirstName
            // 
            labelTextVisualFirstName.Anchor = AnchorStyles.None;
            labelTextVisualFirstName.AutoSize = true;
            labelTextVisualFirstName.BackColor = Color.Transparent;
            labelTextVisualFirstName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualFirstName.Location = new Point(299, 204);
            labelTextVisualFirstName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualFirstName.Name = "labelTextVisualFirstName";
            labelTextVisualFirstName.Size = new Size(63, 29);
            labelTextVisualFirstName.TabIndex = 7;
            labelTextVisualFirstName.Text = "Имя";
            labelTextVisualFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTextVisualLastName
            // 
            labelTextVisualLastName.Anchor = AnchorStyles.None;
            labelTextVisualLastName.AutoSize = true;
            labelTextVisualLastName.BackColor = Color.Transparent;
            labelTextVisualLastName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualLastName.Location = new Point(299, 297);
            labelTextVisualLastName.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualLastName.Name = "labelTextVisualLastName";
            labelTextVisualLastName.Size = new Size(122, 29);
            labelTextVisualLastName.TabIndex = 8;
            labelTextVisualLastName.Text = "Фамилия";
            labelTextVisualLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTextVisualPatronymic
            // 
            labelTextVisualPatronymic.Anchor = AnchorStyles.None;
            labelTextVisualPatronymic.AutoSize = true;
            labelTextVisualPatronymic.BackColor = Color.Transparent;
            labelTextVisualPatronymic.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualPatronymic.Location = new Point(299, 390);
            labelTextVisualPatronymic.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualPatronymic.Name = "labelTextVisualPatronymic";
            labelTextVisualPatronymic.Size = new Size(121, 29);
            labelTextVisualPatronymic.TabIndex = 9;
            labelTextVisualPatronymic.Text = "Отчество";
            labelTextVisualPatronymic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTextVisualEmail
            // 
            labelTextVisualEmail.Anchor = AnchorStyles.None;
            labelTextVisualEmail.AutoSize = true;
            labelTextVisualEmail.BackColor = Color.Transparent;
            labelTextVisualEmail.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualEmail.Location = new Point(299, 485);
            labelTextVisualEmail.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualEmail.Name = "labelTextVisualEmail";
            labelTextVisualEmail.Size = new Size(240, 29);
            labelTextVisualEmail.TabIndex = 10;
            labelTextVisualEmail.Text = "Электронная почта";
            labelTextVisualEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTextVisualPassword
            // 
            labelTextVisualPassword.Anchor = AnchorStyles.None;
            labelTextVisualPassword.AutoSize = true;
            labelTextVisualPassword.BackColor = Color.Transparent;
            labelTextVisualPassword.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualPassword.Location = new Point(299, 576);
            labelTextVisualPassword.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualPassword.Name = "labelTextVisualPassword";
            labelTextVisualPassword.Size = new Size(100, 29);
            labelTextVisualPassword.TabIndex = 12;
            labelTextVisualPassword.Text = "Пароль";
            labelTextVisualPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTextVisualCheckPassword
            // 
            labelTextVisualCheckPassword.Anchor = AnchorStyles.None;
            labelTextVisualCheckPassword.AutoSize = true;
            labelTextVisualCheckPassword.BackColor = Color.Transparent;
            labelTextVisualCheckPassword.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualCheckPassword.Location = new Point(299, 668);
            labelTextVisualCheckPassword.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualCheckPassword.Name = "labelTextVisualCheckPassword";
            labelTextVisualCheckPassword.Size = new Size(292, 29);
            labelTextVisualCheckPassword.TabIndex = 13;
            labelTextVisualCheckPassword.Text = "Подтверждение пароля";
            labelTextVisualCheckPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labeRegistration
            // 
            labeRegistration.Anchor = AnchorStyles.None;
            labeRegistration.AutoSize = true;
            labeRegistration.BackColor = Color.Transparent;
            labeRegistration.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labeRegistration.Location = new Point(483, 72);
            labeRegistration.Margin = new Padding(2, 0, 2, 0);
            labeRegistration.Name = "labeRegistration";
            labeRegistration.Size = new Size(281, 52);
            labeRegistration.TabIndex = 15;
            labeRegistration.Text = "Регистрация";
            // 
            // buttonRegisrationINAuth
            // 
            buttonRegisrationINAuth.Anchor = AnchorStyles.None;
            buttonRegisrationINAuth.BackColor = Color.Black;
            buttonRegisrationINAuth.FlatAppearance.BorderColor = Color.White;
            buttonRegisrationINAuth.FlatAppearance.BorderSize = 0;
            buttonRegisrationINAuth.FlatStyle = FlatStyle.Flat;
            buttonRegisrationINAuth.Font = new Font("Microsoft Sans Serif", 12.85714F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegisrationINAuth.ForeColor = Color.White;
            buttonRegisrationINAuth.Location = new Point(629, 755);
            buttonRegisrationINAuth.Margin = new Padding(2, 3, 2, 3);
            buttonRegisrationINAuth.Name = "buttonRegisrationINAuth";
            buttonRegisrationINAuth.Size = new Size(279, 63);
            buttonRegisrationINAuth.TabIndex = 16;
            buttonRegisrationINAuth.Text = "Авторизоваться";
            buttonRegisrationINAuth.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // labelAccount
            // 
            labelAccount.Anchor = AnchorStyles.None;
            labelAccount.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAccount.Location = new Point(37, 768);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(576, 32);
            labelAccount.TabIndex = 17;
            labelAccount.Text = "Уже есть аккаунт?";
            labelAccount.TextAlign = ContentAlignment.TopRight;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 1031);
            Controls.Add(labelAccount);
            Controls.Add(buttonRegisrationINAuth);
            Controls.Add(labeRegistration);
            Controls.Add(labelTextVisualCheckPassword);
            Controls.Add(labelTextVisualPassword);
            Controls.Add(labelTextVisualEmail);
            Controls.Add(labelTextVisualPatronymic);
            Controls.Add(labelTextVisualLastName);
            Controls.Add(labelTextVisualFirstName);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxMiddleName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormRegister";
            Text = "Sign-up";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelTextVisualFirstName;
        private System.Windows.Forms.Label labelTextVisualLastName;
        private System.Windows.Forms.Label labelTextVisualPatronymic;
        private System.Windows.Forms.Label labelTextVisualEmail;
        private System.Windows.Forms.Label labelTextVisualPassword;
        private System.Windows.Forms.Label labelTextVisualCheckPassword;
        private System.Windows.Forms.Label labeRegistration;
        private System.Windows.Forms.Button buttonRegisrationINAuth;
        private ErrorProvider errorProvider;
        private Label labelAccount;
    }
}