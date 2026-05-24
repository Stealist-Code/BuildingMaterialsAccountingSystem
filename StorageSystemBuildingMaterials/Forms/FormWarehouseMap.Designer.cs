namespace StorageSystemBuildingMaterials.Forms
{
    partial class FormWarehouseMap
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
            dataGridViewWarehouseMap = new DataGridView();
            labelWarehouseMap = new Label();
            labelShipment1 = new Label();
            labelShpment2 = new Label();
            labelShipment3 = new Label();
            textBoxDecor = new TextBox();
            labelShimpent4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWarehouseMap).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWarehouseMap
            // 
            dataGridViewWarehouseMap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewWarehouseMap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWarehouseMap.BackgroundColor = SystemColors.Control;
            dataGridViewWarehouseMap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWarehouseMap.GridColor = SystemColors.ControlDarkDark;
            dataGridViewWarehouseMap.Location = new Point(222, 56);
            dataGridViewWarehouseMap.Name = "dataGridViewWarehouseMap";
            dataGridViewWarehouseMap.ReadOnly = true;
            dataGridViewWarehouseMap.RowHeadersWidth = 51;
            dataGridViewWarehouseMap.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewWarehouseMap.Size = new Size(799, 527);
            dataGridViewWarehouseMap.TabIndex = 0;
            // 
            // labelWarehouseMap
            // 
            labelWarehouseMap.AutoSize = true;
            labelWarehouseMap.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWarehouseMap.Location = new Point(31, 19);
            labelWarehouseMap.Name = "labelWarehouseMap";
            labelWarehouseMap.Size = new Size(124, 22);
            labelWarehouseMap.TabIndex = 1;
            labelWarehouseMap.Text = "Карта склада";
            // 
            // labelShipment1
            // 
            labelShipment1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelShipment1.Location = new Point(55, 94);
            labelShipment1.Name = "labelShipment1";
            labelShipment1.Size = new Size(146, 42);
            labelShipment1.TabIndex = 2;
            labelShipment1.Text = "Отгрузка в первую очередь";
            // 
            // labelShpment2
            // 
            labelShpment2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelShpment2.Location = new Point(55, 152);
            labelShpment2.Name = "labelShpment2";
            labelShpment2.Size = new Size(146, 41);
            labelShpment2.TabIndex = 3;
            labelShpment2.Text = "План отгрузки на следующую неделю";
            // 
            // labelShipment3
            // 
            labelShipment3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelShipment3.Location = new Point(55, 210);
            labelShipment3.Name = "labelShipment3";
            labelShipment3.Size = new Size(146, 43);
            labelShipment3.TabIndex = 4;
            labelShipment3.Text = "Стандартная ротация (FIFO)";
            // 
            // textBoxDecor
            // 
            textBoxDecor.BackColor = Color.Black;
            textBoxDecor.BorderStyle = BorderStyle.None;
            textBoxDecor.Location = new Point(23, 56);
            textBoxDecor.Margin = new Padding(2, 3, 2, 3);
            textBoxDecor.Multiline = true;
            textBoxDecor.Name = "textBoxDecor";
            textBoxDecor.ReadOnly = true;
            textBoxDecor.Size = new Size(138, 3);
            textBoxDecor.TabIndex = 25;
            // 
            // labelShimpent4
            // 
            labelShimpent4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelShimpent4.Location = new Point(55, 271);
            labelShimpent4.Name = "labelShimpent4";
            labelShimpent4.Size = new Size(146, 43);
            labelShimpent4.TabIndex = 26;
            labelShimpent4.Text = "Учёт по остаткам без срочности";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(23, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(19, 20);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(23, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(19, 20);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Location = new Point(23, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 20);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Location = new Point(23, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(19, 20);
            panel4.TabIndex = 30;
            // 
            // FormWarehouseMap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1033, 595);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelShimpent4);
            Controls.Add(textBoxDecor);
            Controls.Add(labelShipment3);
            Controls.Add(labelShpment2);
            Controls.Add(labelShipment1);
            Controls.Add(labelWarehouseMap);
            Controls.Add(dataGridViewWarehouseMap);
            Name = "FormWarehouseMap";
            Text = "FormWarehouseMap";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWarehouseMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewWarehouseMap;
        private Label labelWarehouseMap;
        private Label labelShipment1;
        private Label labelShpment2;
        private Label labelShipment3;
        private TextBox textBoxDecor;
        private Label labelShimpent4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}