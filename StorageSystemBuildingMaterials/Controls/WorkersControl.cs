namespace StorageSystemBuildingMaterials.Controls
{
    /// <summary>
    /// Контроль рабочих
    /// </summary>
    public partial class WorkersControl : UserControl
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="userService">сервис пользователей</param>
        public WorkersControl(IUserService userService)
        {
            InitializeComponent();

            _userService = userService;

            Load += async (s, e) => await LoadUsers();
        }

        private async Task LoadUsers()
        {
            var users = await _userService.GetAllUsers();

            dgvWorkers.DataSource = users.Select(x => new
            {
                x.Id,
                x.FirstName,
                x.LastName,
                x.MiddleName,
                x.Email,
                x.IsActive,
                Role = x.Role?.Title
            }).ToList();

            dgvWorkers.Columns["Id"].Visible = false;

            dgvWorkers.Columns["FirstName"].HeaderText = Resources.FirstName;
            dgvWorkers.Columns["LastName"].HeaderText = Resources.LastName;
            dgvWorkers.Columns["MiddleName"].HeaderText = Resources.MiddleName;
            dgvWorkers.Columns["Email"].HeaderText = Resources.Email;
            dgvWorkers.Columns["IsActive"].HeaderText = Resources.IsActive;
            dgvWorkers.Columns["Role"].HeaderText = Resources.Role;
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvWorkers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvWorkers).BeginInit();
            SuspendLayout();
            // 
            // dgvWorkers
            // 
            dgvWorkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkers.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWorkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWorkers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWorkers.Dock = DockStyle.Fill;
            dgvWorkers.Location = new Point(0, 0);
            dgvWorkers.MultiSelect = false;
            dgvWorkers.Name = "dgvWorkers";
            dgvWorkers.ReadOnly = true;
            dgvWorkers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkers.Size = new Size(846, 544);
            dgvWorkers.TabIndex = 0;
            // 
            // WorkersControl
            // 
            BackColor = Color.LightGray;
            Controls.Add(dgvWorkers);
            Name = "WorkersControl";
            Size = new Size(846, 544);
            ((System.ComponentModel.ISupportInitialize)dgvWorkers).EndInit();
            ResumeLayout(false);

        }

        private DataGridView dgvWorkers;
    }
}