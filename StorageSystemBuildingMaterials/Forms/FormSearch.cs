using StorageSystemBuildingMaterials.Forms.Interfaces;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace StorageSystemBuildingMaterials.Forms
{

    /// <summary>
    /// Форма для расширенного поиска товаров (по артикулу, названию, категории)
    /// </summary>
    public partial class FormSearch : Form, ILocalizable
    {

        private ICategoryService _categoryService;

        /// <summary>
        /// Артикул (часть) для поиска
        /// </summary>
        public string Article { get; private set; }

        /// <summary>
        /// Название (часть) для поиска
        /// </summary>
        public string NameFilter { get; private set; }

        /// <summary>
        /// Идентификатор категории (null – любая)
        /// </summary>
        public Guid? CategoryId { get; private set; }

        public FormSearch(ICategoryService categoryService)
        {
            InitializeComponent();

            _categoryService = categoryService;

            Load += async (s, e) => await LoadCategories();
            btnSearch.Click += btnSearch_Click;
        }

        private async Task LoadCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Article = txtArticle.Text.Trim();
            NameFilter = txtName.Text.Trim();

            var selectedCategory = cbCategory.SelectedItem as Category;
            CategoryId = selectedCategory?.Id;

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.Search;
            labelTextVisualSearch.Text = Resources.Search;

            btnSearch.Text = Resources.Search;
            btnCancel.Text = Resources.Cancel;

            labelTextVisualArticle.Text = Resources.Article;
            labelTextVisualProductName.Text = Resources.Name;
            labelCategory.Text = Resources.Category;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }

        private void labelTextVisualArticle_Click(object sender, EventArgs e)
        {

        }
    }
}