namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormLogInApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogInApp));
            labelText = new Label();
            buttonOpen = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.Anchor = AnchorStyles.None;
            labelText.AutoSize = true;
            labelText.BackColor = Color.Transparent;
            labelText.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            labelText.Location = new Point(23, 111);
            labelText.Name = "labelText";
            labelText.Size = new Size(880, 60);
            labelText.TabIndex = 0;
            labelText.Text = "Система учета строительных материалов";
            // 
            // buttonOpen
            // 
            buttonOpen.Anchor = AnchorStyles.None;
            buttonOpen.BackColor = Color.Black;
            buttonOpen.Font = new Font("Segoe UI", 12F);
            buttonOpen.ForeColor = Color.White;
            buttonOpen.Location = new Point(258, 199);
            buttonOpen.Margin = new Padding(10);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(328, 81);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть приложение";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.None;
            buttonClose.BackColor = Color.Black;
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(258, 340);
            buttonClose.Name = "buttonClose";
            buttonClose.RightToLeft = RightToLeft.No;
            buttonClose.Size = new Size(328, 81);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Закрыть приложение";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormLogInApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(906, 529);
            Controls.Add(buttonClose);
            Controls.Add(buttonOpen);
            Controls.Add(labelText);
            ForeColor = Color.Black;
            Name = "FormLogInApp";
            Text = "Вход в приложение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private Button buttonOpen;
        private Button buttonClose;
    }
}