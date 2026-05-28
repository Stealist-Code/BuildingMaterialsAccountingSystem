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
    /// Форма для редактирования или удаления категории.
    /// </summary>
    public partial class FormEditCategory : Form, ILocalizable
    {
        private readonly ICategoryService _categoryService;
        private Guid currentCategoryId;


        /// <summary>
        /// Новое название категории (если было сохранение).
        /// </summary>
        public string NewName { get; private set; }

        public FormEditCategory(ICategoryService categoryService, CategoryFormMode mode)
        {
            InitializeComponent();

            _categoryService = categoryService;

            cbCategory.DropDownStyle = mode == CategoryFormMode.Delete
                ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;

            btnSave.Visible = mode == CategoryFormMode.Edit;
            btnDelete.Visible = mode == CategoryFormMode.Delete || mode == CategoryFormMode.Edit;

            LoadCategories();

            cbCategory.SelectedIndexChanged += CbCategory_SelectedIndexChanged;
        }

        /// <summary>
        /// Загружает категории в выпадающий список.
        /// </summary>
        private async void LoadCategories()
        {
            var categories = await _categoryService.GetAllCategories();

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";

            if (cbCategory.Items.Count > 0)
            {
                cbCategory.SelectedIndex = 0;
            }
            else
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Обработчик выбора категории: обновляем текстовое поле.
        /// </summary>
        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem is Category category)
            {
                currentCategoryId = category.Id;

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.EditCategory;

            labelTextVisualNameCategory.Text = Resources.Name;
            btnSave.Text = Resources.Save;
            btnDelete.Text = Resources.Delete;
            btnCancel.Text = Resources.Cancel;
            labelTextVisualEditCategory.Text = Resources.EditCategory;
        }

        /// <summary>
        /// Сохранить изменения названия категории.
        /// </summary>
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCategoryId == Guid.Empty)
            {
                MessageBox.Show(Resources.CategoryIsNotChosen);
                return;
            }

            var newName = cbCategory.Text.Trim();

            try
            {
                await _categoryService.UpdateCategory(currentCategoryId, newName);

                MessageBox.Show(Resources.CategorySaved);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        /// <summary>
        /// Удалить выбранную категорию.
        /// </summary>
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentCategoryId == Guid.Empty)
            {
                MessageBox.Show(Resources.CategoryIsNotChosen);
                return;
            }

            if (MessageBox.Show(Resources.DeleteCategory, Resources.Confirm, MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                await _categoryService.DeleteCategory(currentCategoryId);

                MessageBox.Show(Resources.CategoryWasDeleted);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }
        /// <summary>
        /// Кнопка "Отмена" – просто закрывает форму.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }
    }
}