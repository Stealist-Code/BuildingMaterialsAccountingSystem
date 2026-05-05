using StorageSystemBuildingMaterials.Enums;
using StorageSystemBuildingMaterials.Forms.Interfaces;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма для добавления нового товара.
    /// </summary>
    public partial class FormAddProduct : Form, ILocalizable
    {
        private readonly FormAddProductsModeEnum _mode;
        private ICategoryService _categoryService;
        private readonly Product _product;

        /// <summary>
        /// Товар, полученный из формы после подтверждения пользователем
        /// </summary>
        public Product ResultProduct { get; private set; }

        public FormAddProduct(FormAddProductsModeEnum mode, ICategoryService categoryService, Product product = null)
        {
            InitializeComponent();
            _mode = mode;
            _categoryService = categoryService;
            _product = product;
            this.Load += FormAddProduct_Load;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить"
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue is null)
            {
                MessageBox.Show(Resources.CategoryIsNotChosen);
                return;
            }

            if (comboBoxUnit.SelectedItem is null)
            {
                MessageBox.Show(Resources.ChooseUnit);
                return;
            }

            ResultProduct = new Product
            {
                Name = txtName.Text.Trim(),
                Unit = comboBoxUnit.SelectedItem?.ToString(),
                CategoryId = (Guid)cbCategory.SelectedValue,
                CurrentStock = 0
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void FormAddProduct_Load(object sender, EventArgs e)
        {
            var categories = await _categoryService.GetAllCategories();

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            ApplyLocalization();
            SetupForm();
        }

        private void FillFields()
        {
            if (_product is null) return;

            txtName.Text = _product.Name;
            cbCategory.SelectedValue = _product.CategoryId;
            comboBoxUnit.SelectedItem = _product.Unit;
        }

        private void SetupForm()
        {
            comboBoxUnit.Items.AddRange(new object[]
            {
                "шт (штуки)",
                "л (литры)",
                "м³ (куб. метры)",
                "кг (килограммы)",
                "т (тонны)",
                "гр (граммы)",
                "пог. м (погонные метры)",
                "м (метры)"
            });

            if (_mode == FormAddProductsModeEnum.Create)
            {
                this.Text = Resources.AddProduct;
                labelTextVisualAddProduct.Text = Resources.AddProduct;
                btnOK.Text = Resources.Create;
            }

            else
            {
                this.Text = Resources.EditProduct;
                labelTextVisualAddProduct.Text = Resources.EditProduct;
                btnOK.Text = Resources.Save;

                FillFields();
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            labelTextVisualName.Text = Resources.Name;
            labelTextVisualCategory.Text = Resources.Category;
            labelTextVisualPrice.Text = Resources.PurchasePrice;
            labelTextVisualUnit.Text = Resources.Unit;
            labelTextVisualDateTo.Text = Resources.ExpirationDate;

            if (_mode == FormAddProductsModeEnum.Create)
            {
                this.Text = Resources.AddProduct;
                labelTextVisualAddProduct.Text = Resources.AddProduct;
                btnOK.Text = Resources.Create;
            }
            else
            {
                this.Text = Resources.EditProduct;
                labelTextVisualAddProduct.Text = Resources.EditProduct;
                btnOK.Text = Resources.Save;
            }

            btnCancel.Text = Resources.Cancel;
        }
    }
}