namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            textBoxVisualAdmin = new TextBox();
            textBoxVisualFon = new TextBox();
            textBoxDecor = new TextBox();
            btnWorkers = new Button();
            btnProducts = new Button();
            btnShipments = new Button();
            pnlContent = new Panel();
            SuspendLayout();
            // 
            // textBoxVisualAdmin
            // 
            textBoxVisualAdmin.BackColor = Color.FromArgb(217, 217, 217);
            textBoxVisualAdmin.BorderStyle = BorderStyle.None;
            textBoxVisualAdmin.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVisualAdmin.Location = new Point(-10, 14);
            textBoxVisualAdmin.Margin = new Padding(2);
            textBoxVisualAdmin.Multiline = true;
            textBoxVisualAdmin.Name = "textBoxVisualAdmin";
            textBoxVisualAdmin.ReadOnly = true;
            textBoxVisualAdmin.Size = new Size(159, 36);
            textBoxVisualAdmin.TabIndex = 1;
            textBoxVisualAdmin.Text = "АДМИН-ПАНЕЛЬ";
            textBoxVisualAdmin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVisualFon
            // 
            textBoxVisualFon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVisualFon.BackColor = Color.LightGray;
            textBoxVisualFon.BorderStyle = BorderStyle.None;
            textBoxVisualFon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVisualFon.Location = new Point(-10, -6);
            textBoxVisualFon.Margin = new Padding(2);
            textBoxVisualFon.Multiline = true;
            textBoxVisualFon.Name = "textBoxVisualFon";
            textBoxVisualFon.ReadOnly = true;
            textBoxVisualFon.Size = new Size(159, 551);
            textBoxVisualFon.TabIndex = 2;
            textBoxVisualFon.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDecor
            // 
            textBoxDecor.BackColor = Color.Black;
            textBoxDecor.BorderStyle = BorderStyle.None;
            textBoxDecor.Location = new Point(18, 48);
            textBoxDecor.Margin = new Padding(2);
            textBoxDecor.Multiline = true;
            textBoxDecor.Name = "textBoxDecor";
            textBoxDecor.ReadOnly = true;
            textBoxDecor.Size = new Size(121, 2);
            textBoxDecor.TabIndex = 24;
            // 
            // btnWorkers
            // 
            btnWorkers.BackColor = Color.LightGray;
            btnWorkers.FlatAppearance.BorderSize = 0;
            btnWorkers.FlatStyle = FlatStyle.Flat;
            btnWorkers.Location = new Point(8, 70);
            btnWorkers.Margin = new Padding(2);
            btnWorkers.Name = "btnWorkers";
            btnWorkers.Size = new Size(141, 31);
            btnWorkers.TabIndex = 25;
            btnWorkers.Text = "Список работников";
            btnWorkers.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.LightGray;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(8, 105);
            btnProducts.Margin = new Padding(2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(141, 29);
            btnProducts.TabIndex = 26;
            btnProducts.Text = "Список товаров";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnShipments
            // 
            btnShipments.BackColor = Color.LightGray;
            btnShipments.FlatAppearance.BorderSize = 0;
            btnShipments.FlatStyle = FlatStyle.Flat;
            btnShipments.Location = new Point(8, 138);
            btnShipments.Margin = new Padding(2);
            btnShipments.Name = "btnShipments";
            btnShipments.Size = new Size(141, 29);
            btnShipments.TabIndex = 27;
            btnShipments.Text = "История отгрузок";
            btnShipments.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.LightGray;
            pnlContent.Location = new Point(153, -6);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(846, 544);
            pnlContent.TabIndex = 28;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(135, 135, 135);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 536);
            Controls.Add(pnlContent);
            Controls.Add(btnShipments);
            Controls.Add(btnProducts);
            Controls.Add(btnWorkers);
            Controls.Add(textBoxDecor);
            Controls.Add(textBoxVisualAdmin);
            Controls.Add(textBoxVisualFon);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormAdmin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxVisualAdmin;
        private System.Windows.Forms.TextBox textBoxVisualFon;
        private System.Windows.Forms.TextBox textBoxDecor;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnShipments;
        private System.Windows.Forms.Panel pnlContent;
    }
}