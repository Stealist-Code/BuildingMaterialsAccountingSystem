namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма регистрации нового пользователя
    /// </summary>
    public partial class FormRegister : Form, ILocalizable
    {
        private readonly IAuthService _authService;

        /// <summary>
        /// Конструктор формы регистрации
        /// </summary>
        public FormRegister(IAuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        /// <summary>
        /// Обработчик кнопки регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            var request = new RegisterRequest
            {
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                MiddleName = textBoxMiddleName.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
                Password = textBoxPassword.Text,
                ConfirmPassword = textBoxConfirmPassword.Text
            };

            try
            {
                await _authService.Register(request);

                MessageBox.Show(Resources.Success);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        /// <summary>
        /// Обработчик кнопки "Already have an account? Login" – возврат к форме входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.Register;

            buttonRegister.Text = Resources.SignUp;

            labelTextVisualFirstName.Text = Resources.FirstName;
            labelTextVisualLastName.Text = Resources.LastName;
            labelTextVisualPatronymic.Text = Resources.MiddleName;
            labelTextVisualEmail.Text = Resources.Email;
            labelTextVisualPassword.Text = Resources.Password;
            labelTextVisualCheckPassword.Text = Resources.ConfirmPassword;
            labelAccount.Text = Resources.AlreadyAccount;

            labeRegistration.Text = Resources.Registration;
            buttonRegisrationINAuth.Text = Resources.RegisrationINAuth;
        }

        /// <summary>
        /// Обработчик кнопки "Cancel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormRegister_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }
    }
}