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
            label1 = new Label();
            buttonOpen = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 115);
            label1.Name = "label1";
            label1.Size = new Size(506, 35);
            label1.TabIndex = 0;
            label1.Text = "Система учета строительных материалов";
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.Black;
            buttonOpen.Font = new Font("Segoe UI", 12F);
            buttonOpen.ForeColor = Color.White;
            buttonOpen.Location = new Point(60, 241);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(328, 81);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть приложение";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Black;
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(525, 241);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(328, 81);
            buttonClose.TabIndex = 2;
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
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "FormLogInApp";
            Text = "FormLogInApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOpen;
        private Button buttonClose;
    }
}