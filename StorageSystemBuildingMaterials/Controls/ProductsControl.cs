using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Enums;
using StorageSystemBuildingMaterials.Forms;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System;

namespace StorageSystemBuildingMaterials.Controls
{
    public partial class ProductsControl : UserControl
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsControl(IProductService productService, ICategoryService categoryService)
        {
            InitializeComponent();

            _productService = productService;
            _categoryService = categoryService;

            Load += OnLoad;
            productBtn.Click += OnProductBtnClick;
            categoryBtn.Click += OnCategoryBtnClick;
        }

        private async Task LoadData()
        {
            var products = await _productService.GetActualProducts();

            dgvProducts.DataSource = products;
            dgvProducts.Columns["Id"].Visible = false;
            dgvProducts.Columns["CategoryId"].Visible = false;

            dgvProducts.Columns["Article"].HeaderText = Resources.Article;
            dgvProducts.Columns["Name"].HeaderText = Resources.Name;
            dgvProducts.Columns["CategoryName"].HeaderText = Resources.Category;
            dgvProducts.Columns["Unit"].HeaderText = Resources.Unit;
            dgvProducts.Columns["PurchasePrice"].HeaderText = Resources.PurchasePrice;
            dgvProducts.Columns["CurrentStock"].HeaderText = Resources.CurrentStock;
            dgvProducts.Columns["ExpirationDate"].HeaderText = Resources.ExpirationDate;
            dgvProducts.Columns["DaysLeft"].HeaderText = Resources.DaysLeft;
            dgvProducts.Columns["ReceivedDate"].Visible = false;
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvProducts = new DataGridView();
            cmsProduct = new ContextMenuStrip(components);
            addProductToolStripMenuItem = new ToolStripMenuItem();
            editProductToolStripMenuItem = new ToolStripMenuItem();
            deleteProductToolStripMenuItem = new ToolStripMenuItem();
            productBtn = new Button();
            categoryBtn = new Button();
            cmsCategory = new ContextMenuStrip(components);
            addCategoryToolStripMenuItem = new ToolStripMenuItem();
            editCategoryToolStripMenuItem = new ToolStripMenuItem();
            deleteCategoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            cmsProduct.SuspendLayout();
            cmsCategory.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Location = new Point(0, 50);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(846, 494);
            dgvProducts.TabIndex = 0;
            // 
            // cmsProduct
            // 
            cmsProduct.Items.AddRange(new ToolStripItem[] { addProductToolStripMenuItem, editProductToolStripMenuItem, deleteProductToolStripMenuItem });
            cmsProduct.Name = "cmsProduct";
            cmsProduct.Size = new Size(155, 70);
            cmsProduct.Text = Resources.Product;
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(154, 22);
            addProductToolStripMenuItem.Text = Resources.Add;
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // editProductToolStripMenuItem
            // 
            editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            editProductToolStripMenuItem.Size = new Size(154, 22);
            editProductToolStripMenuItem.Text = Resources.Edit;
            editProductToolStripMenuItem.Click += editProductToolStripMenuItem_Click;
            // 
            // deleteProductToolStripMenuItem
            // 
            deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            deleteProductToolStripMenuItem.Size = new Size(154, 22);
            deleteProductToolStripMenuItem.Text = Resources.Delete;
            deleteProductToolStripMenuItem.Click += deleteProductToolStripMenuItem_Click;
            // 
            // productBtn
            // 
            productBtn.Location = new Point(3, 14);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(148, 30);
            productBtn.TabIndex = 1;
            productBtn.Text = Resources.Product;
            productBtn.UseVisualStyleBackColor = true;
            // 
            // categoryBtn
            // 
            categoryBtn.Location = new Point(170, 14);
            categoryBtn.Name = "categoryBtn";
            categoryBtn.Size = new Size(148, 30);
            categoryBtn.TabIndex = 2;
            categoryBtn.Text = Resources.Category;
            categoryBtn.UseVisualStyleBackColor = true;
            // 
            // cmsCategory
            // 
            cmsCategory.Items.AddRange(new ToolStripItem[] { addCategoryToolStripMenuItem, editCategoryToolStripMenuItem, deleteCategoryToolStripMenuItem });
            cmsCategory.Name = "cmsCategory";
            cmsCategory.Size = new Size(155, 70);
            // 
            // addCategoryToolStripMenuItem
            // 
            addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            addCategoryToolStripMenuItem.Size = new Size(154, 22);
            addCategoryToolStripMenuItem.Text = Resources.Add;
            addCategoryToolStripMenuItem.Click += addCategoryToolStripMenuItem_Click;
            // 
            // editCategoryToolStripMenuItem
            // 
            editCategoryToolStripMenuItem.Name = "editCategoryToolStripMenuItem";
            editCategoryToolStripMenuItem.Size = new Size(154, 22);
            editCategoryToolStripMenuItem.Text = Resources.Edit;
            editCategoryToolStripMenuItem.Click += editCategoryToolStripMenuItem_Click;
            // 
            // deleteCategoryToolStripMenuItem
            // 
            deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            deleteCategoryToolStripMenuItem.Size = new Size(154, 22);
            deleteCategoryToolStripMenuItem.Text = Resources.Delete;
            deleteCategoryToolStripMenuItem.Click += deleteCategoryToolStripMenuItem_Click;
            // 
            // ProductsControl
            // 
            Controls.Add(categoryBtn);
            Controls.Add(productBtn);
            Controls.Add(dgvProducts);
            Name = "ProductsControl";
            Size = new Size(846, 544);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            cmsProduct.ResumeLayout(false);
            cmsCategory.ResumeLayout(false);
            ResumeLayout(false);

        }

        private ContextMenuStrip cmsProduct;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem editProductToolStripMenuItem;
        private ToolStripMenuItem deleteProductToolStripMenuItem;
        private Button productBtn;
        private Button categoryBtn;
        private ContextMenuStrip cmsCategory;
        private ToolStripMenuItem addCategoryToolStripMenuItem;
        private ToolStripMenuItem editCategoryToolStripMenuItem;
        private ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private DataGridView dgvProducts;

        private async void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new FormAddProduct(FormAddProductsModeEnum.Create, _categoryService);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _productService.CreateProduct(addForm.ResultProduct);

                    MessageBox.Show(Resources.AddProductSuccessfully);
                    await LoadData(); // обновить таблицу
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
                }
            }
        }

        private async void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow is null)
            {
                MessageBox.Show(Resources.ProductIsNotChosen);
                return;
            }

            var selectedProduct = dgvProducts.CurrentRow.DataBoundItem as ProductDto;

            if (selectedProduct is null)
            {
                MessageBox.Show(Resources.ProductNotFound);
                return;
            }

            var product = new Product
            {
                Id = selectedProduct.Id,
                Name = selectedProduct.Name,
                Article = selectedProduct.Article,
                CategoryId = selectedProduct.CategoryId,
                Unit = selectedProduct.Unit,
                PurchasePrice = selectedProduct.PurchasePrice,
                CurrentStock = selectedProduct.CurrentStock,
                ExpirationDate = selectedProduct.ExpirationDate
            };

            try
            {
                var form = new FormAddProduct(FormAddProductsModeEnum.Edit, _categoryService, product);


                if (form.ShowDialog() == DialogResult.OK)
                {
                    await _productService.UpdateProduct(product.Id, form.ResultProduct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        private async void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow is null)
            {
                return;
            }

            var selectedProduct = (ProductDto)dgvProducts.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(Resources.DeleteProduct, Resources.Confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                await _productService.DeleteProduct(selectedProduct.Id);

                await LoadData();

                MessageBox.Show(Resources.ProductWasDeleted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        private async void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox(Resources.WriteNameOfCategory, Resources.AddCategory, String.Empty);

            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }

            try
            {
                await _categoryService.AddCategory(name.Trim());

                MessageBox.Show(Resources.AddCategorySuccessfully);

                await LoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        private void editCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormEditCategory(_categoryService, CategoryFormMode.Edit);

            form.ShowDialog();
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormEditCategory(_categoryService, CategoryFormMode.Delete);

            form.ShowDialog();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Load -= OnLoad;
                productBtn.Click -= OnProductBtnClick;
                categoryBtn.Click -= OnCategoryBtnClick;

                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void OnProductBtnClick(object sender, EventArgs e)
        {
            cmsProduct.Show(productBtn, new Point(0, productBtn.Height));
        }

        private void OnCategoryBtnClick(object sender, EventArgs e)
        {
            cmsCategory.Show(categoryBtn, new Point(0, categoryBtn.Height));
        }
    }
}