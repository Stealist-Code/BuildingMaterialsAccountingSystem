namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormCheckTIN
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
            dgvTIN = new DataGridView();
            labelCheckTIN = new Label();
            labelTIN = new Label();
            tbTIN = new TextBox();
            buttonCancel = new Button();
            buttonSelect = new Button();
            buttonCheck = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTIN).BeginInit();
            SuspendLayout();
            // 
            // dgvTIN
            // 
            dgvTIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTIN.Location = new Point(12, 118);
            dgvTIN.Name = "dgvTIN";
            dgvTIN.RowHeadersWidth = 51;
            dgvTIN.Size = new Size(908, 319);
            dgvTIN.TabIndex = 0;
            // 
            // labelCheckTIN
            // 
            labelCheckTIN.AutoSize = true;
            labelCheckTIN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCheckTIN.Location = new Point(343, 19);
            labelCheckTIN.Name = "labelCheckTIN";
            labelCheckTIN.Size = new Size(247, 28);
            labelCheckTIN.TabIndex = 1;
            labelCheckTIN.Text = "Проверка на контрагента";
            labelCheckTIN.Click += label1_Click;
            // 
            // labelTIN
            // 
            labelTIN.AutoSize = true;
            labelTIN.Location = new Point(343, 70);
            labelTIN.Name = "labelTIN";
            labelTIN.Size = new Size(42, 20);
            labelTIN.TabIndex = 2;
            labelTIN.Text = "ИНН";
            // 
            // tbTIN
            // 
            tbTIN.Location = new Point(400, 67);
            tbTIN.Name = "tbTIN";
            tbTIN.Size = new Size(190, 27);
            tbTIN.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(112, 476);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(423, 476);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(94, 29);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "Выбрать";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(747, 476);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(94, 29);
            buttonCheck.TabIndex = 6;
            buttonCheck.Text = "Проверить";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // FormCheckTIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 531);
            Controls.Add(buttonCheck);
            Controls.Add(buttonSelect);
            Controls.Add(buttonCancel);
            Controls.Add(tbTIN);
            Controls.Add(labelTIN);
            Controls.Add(labelCheckTIN);
            Controls.Add(dgvTIN);
            Name = "FormCheckTIN";
            Text = "FormCheckTIN";
            ((System.ComponentModel.ISupportInitialize)dgvTIN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTIN;
        private Label labelCheckTIN;
        private Label labelTIN;
        private TextBox tbTIN;
        private Button buttonCancel;
        private Button buttonSelect;
        private Button buttonCheck;
    }
}