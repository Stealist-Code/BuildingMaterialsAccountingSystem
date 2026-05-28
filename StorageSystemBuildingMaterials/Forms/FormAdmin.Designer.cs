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
            textBoxVisualAdmin.BackColor = Color.Gold;
            textBoxVisualAdmin.BorderStyle = BorderStyle.None;
            textBoxVisualAdmin.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVisualAdmin.Location = new Point(-11, 19);
            textBoxVisualAdmin.Margin = new Padding(2, 3, 2, 3);
            textBoxVisualAdmin.Multiline = true;
            textBoxVisualAdmin.Name = "textBoxVisualAdmin";
            textBoxVisualAdmin.ReadOnly = true;
            textBoxVisualAdmin.Size = new Size(182, 48);
            textBoxVisualAdmin.TabIndex = 1;
            textBoxVisualAdmin.Text = "АДМИН-ПАНЕЛЬ";
            textBoxVisualAdmin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVisualFon
            // 
            textBoxVisualFon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVisualFon.BackColor = Color.Gold;
            textBoxVisualFon.BorderStyle = BorderStyle.None;
            textBoxVisualFon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVisualFon.Location = new Point(-11, -8);
            textBoxVisualFon.Margin = new Padding(2, 3, 2, 3);
            textBoxVisualFon.Multiline = true;
            textBoxVisualFon.Name = "textBoxVisualFon";
            textBoxVisualFon.ReadOnly = true;
            textBoxVisualFon.Size = new Size(182, 735);
            textBoxVisualFon.TabIndex = 2;
            textBoxVisualFon.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDecor
            // 
            textBoxDecor.BackColor = Color.Black;
            textBoxDecor.BorderStyle = BorderStyle.None;
            textBoxDecor.Location = new Point(21, 64);
            textBoxDecor.Margin = new Padding(2, 3, 2, 3);
            textBoxDecor.Multiline = true;
            textBoxDecor.Name = "textBoxDecor";
            textBoxDecor.ReadOnly = true;
            textBoxDecor.Size = new Size(138, 3);
            textBoxDecor.TabIndex = 24;
            // 
            // btnWorkers
            // 
            btnWorkers.BackColor = Color.Gold;
            btnWorkers.FlatAppearance.BorderSize = 0;
            btnWorkers.FlatStyle = FlatStyle.Flat;
            btnWorkers.Location = new Point(9, 93);
            btnWorkers.Margin = new Padding(2, 3, 2, 3);
            btnWorkers.Name = "btnWorkers";
            btnWorkers.Size = new Size(161, 41);
            btnWorkers.TabIndex = 25;
            btnWorkers.Text = "Список работников";
            btnWorkers.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Gold;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(9, 140);
            btnProducts.Margin = new Padding(2, 3, 2, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(161, 39);
            btnProducts.TabIndex = 26;
            btnProducts.Text = "Список товаров";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnShipments
            // 
            btnShipments.AutoEllipsis = true;
            btnShipments.BackColor = Color.Gold;
            btnShipments.FlatAppearance.BorderSize = 0;
            btnShipments.FlatStyle = FlatStyle.Flat;
            btnShipments.Location = new Point(9, 184);
            btnShipments.Margin = new Padding(2, 3, 2, 3);
            btnShipments.Name = "btnShipments";
            btnShipments.Size = new Size(161, 39);
            btnShipments.TabIndex = 27;
            btnShipments.Text = "История отгрузок";
            btnShipments.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.White;
            pnlContent.BackgroundImageLayout = ImageLayout.None;
            pnlContent.Location = new Point(175, 2);
            pnlContent.Margin = new Padding(2, 3, 2, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(967, 725);
            pnlContent.TabIndex = 28;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1139, 715);
            Controls.Add(pnlContent);
            Controls.Add(btnShipments);
            Controls.Add(btnProducts);
            Controls.Add(btnWorkers);
            Controls.Add(textBoxDecor);
            Controls.Add(textBoxVisualAdmin);
            Controls.Add(textBoxVisualFon);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
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