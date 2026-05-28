using System.Drawing;


namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegister = new Button();
            buttonLogin = new Button();
            labelError = new Label();
            labelTextVisualAuth = new Label();
            labelTextVisualEmail = new Label();
            labelTextVisualPassword = new Label();
            labelWithoutAccount = new Label();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 16F);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(507, 292);
            textBoxEmail.Margin = new Padding(2, 3, 2, 3);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.RightToLeft = RightToLeft.No;
            textBoxEmail.Size = new Size(377, 56);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 16F);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(506, 385);
            textBoxPassword.Margin = new Padding(2, 3, 2, 3);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(377, 55);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.BackColor = Color.Black;
            buttonRegister.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = SystemColors.Control;
            buttonRegister.Location = new Point(563, 519);
            buttonRegister.Margin = new Padding(2, 3, 2, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(307, 61);
            buttonRegister.TabIndex = 2;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.Black;
            buttonLogin.FlatAppearance.BorderSize = 20;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(325, 596);
            buttonLogin.Margin = new Padding(2, 3, 2, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(558, 101);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelError.AutoSize = true;
            labelError.BackColor = SystemColors.ScrollBar;
            labelError.Cursor = Cursors.Hand;
            labelError.ForeColor = Color.Fuchsia;
            labelError.Location = new Point(327, 696);
            labelError.Margin = new Padding(2, 0, 2, 0);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 4;
            // 
            // labelTextVisualAuth
            // 
            labelTextVisualAuth.Anchor = AnchorStyles.None;
            labelTextVisualAuth.AutoSize = true;
            labelTextVisualAuth.BackColor = Color.Transparent;
            labelTextVisualAuth.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualAuth.ForeColor = Color.Black;
            labelTextVisualAuth.Location = new Point(437, 168);
            labelTextVisualAuth.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualAuth.Name = "labelTextVisualAuth";
            labelTextVisualAuth.Size = new Size(307, 54);
            labelTextVisualAuth.TabIndex = 8;
            labelTextVisualAuth.Text = "Авторизация";
            // 
            // labelTextVisualEmail
            // 
            labelTextVisualEmail.Anchor = AnchorStyles.None;
            labelTextVisualEmail.BackColor = Color.Transparent;
            labelTextVisualEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualEmail.ForeColor = Color.Black;
            labelTextVisualEmail.Location = new Point(278, 295);
            labelTextVisualEmail.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualEmail.Name = "labelTextVisualEmail";
            labelTextVisualEmail.Size = new Size(187, 67);
            labelTextVisualEmail.TabIndex = 9;
            labelTextVisualEmail.Text = "Электронная почта";
            // 
            // labelTextVisualPassword
            // 
            labelTextVisualPassword.Anchor = AnchorStyles.None;
            labelTextVisualPassword.AutoSize = true;
            labelTextVisualPassword.BackColor = Color.Transparent;
            labelTextVisualPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextVisualPassword.ForeColor = Color.Black;
            labelTextVisualPassword.Location = new Point(278, 388);
            labelTextVisualPassword.Margin = new Padding(2, 0, 2, 0);
            labelTextVisualPassword.Name = "labelTextVisualPassword";
            labelTextVisualPassword.Size = new Size(108, 31);
            labelTextVisualPassword.TabIndex = 11;
            labelTextVisualPassword.Text = "Пароль";
            // 
            // labelWithoutAccount
            // 
            labelWithoutAccount.Anchor = AnchorStyles.None;
            labelWithoutAccount.AutoSize = true;
            labelWithoutAccount.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWithoutAccount.ForeColor = SystemColors.ActiveCaptionText;
            labelWithoutAccount.Location = new Point(329, 534);
            labelWithoutAccount.Name = "labelWithoutAccount";
            labelWithoutAccount.Size = new Size(218, 32);
            labelWithoutAccount.TabIndex = 12;
            labelWithoutAccount.Text = "Нет аккаунта?";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1183, 847);
            Controls.Add(labelWithoutAccount);
            Controls.Add(labelTextVisualPassword);
            Controls.Add(labelTextVisualEmail);
            Controls.Add(labelTextVisualAuth);
            Controls.Add(labelError);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            DoubleBuffered = true;
            ForeColor = Color.Crimson;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormLogin";
            Text = "Sign-in";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelTextVisualAuth;
        private System.Windows.Forms.Label labelTextVisualEmail;
        private System.Windows.Forms.Label labelTextVisualPassword;
        private Label labelWithoutAccount;
    }
}