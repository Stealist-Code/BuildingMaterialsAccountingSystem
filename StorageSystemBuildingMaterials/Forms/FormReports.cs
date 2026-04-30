using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace StorageSystemBuildingMaterials.Forms
{
    public partial class FormReports : Form
    {
        private readonly IReportService _reportService;
        private bool _isUpdating = false;

        public FormReports(IReportService reportService)
        {
            InitializeComponent();

            _reportService = reportService;

            dateTimePickerFrom.ValueChanged += dateTimePicker_ValueChanged;
            dateTimePickerTo.ValueChanged += dateTimePicker_ValueChanged;
        }

        private async void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            var picker = sender as DateTimePicker;

            if (picker.Value > DateTime.Now)
            {
                _isUpdating = true;

                picker.Value = DateTime.Now;

                MessageBox.Show(Resources.IncorrectDate);

                _isUpdating = false;
                return;
            }

            await LoadReport();
        }

        private async Task LoadReport()
        {
            try
            {
                dgvReport.DataSource = await _reportService.GetReports(
                    dateTimePickerFrom.Value,
                    dateTimePickerTo.Value
                );
                dgvReport.Columns["Date"].HeaderText = Resources.ReportDate;
                dgvReport.Columns["CustomerName"].HeaderText = Resources.ReportCustomer;
                dgvReport.Columns["ShipmentAmount"].HeaderText = Resources.ReportShipmentAmount;
                dgvReport.Columns["Profit"].HeaderText = Resources.ReportProfit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private async void FormReports_Load(object sender, EventArgs e)
        {
            await LoadReport();
        }

        private async void btnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                var reports = await _reportService.GetReports(
                    dateTimePickerFrom.Value,
                    dateTimePickerTo.Value
                );

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = "report.csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var lines = new List<string>();

                        lines.Add("Дата;Клиент;Сумма;Прибыль;Email");

                        foreach (var r in reports)
                        {
                            lines.Add($"{r.Date:dd.MM.yyyy};{r.CustomerName};{r.ShipmentAmount};{r.Profit};{r.CustomerEmail}");
                        }

                        File.WriteAllLines(sfd.FileName, lines, System.Text.Encoding.UTF8);

                        MessageBox.Show("Отчет успешно экспортирован!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.Reporting;

            labelDate.Text = Resources.Date;
            labelReport.Text = Resources.Reporting;
            btnExportReport.Text = Resources.ExportReport;
        }
    }
}