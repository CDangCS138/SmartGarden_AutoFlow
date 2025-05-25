using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_History : UserControl
    {
        private static readonly HttpClient _client = new HttpClient();
        private List<IrrigationRecord> irrigationList = new List<IrrigationRecord>();

        public UC_History()
        {
            InitializeComponent();
            this.Load += UC_History_Load;
            startDatePicker.ValueChanged += DatePicker_ValueChanged;
            endDatePicker.ValueChanged += DatePicker_ValueChanged;
            btnRefresh.Click += btnRefresh_Click;
        }

        class IrrigationRecord
        {
            public string Date { get; set; }
            public string Hour { get; set; }
        }

        private async void UC_History_Load(object sender, EventArgs e)
        {
            startDatePicker.Value = new DateTime(2025, 1, 1);
            endDatePicker.Value = DateTime.Today;
            await FetchIrrigationHistoryAsync();
            DisplayFilteredData();
            gardenList.SelectedItem = "Khu vườn 1";
        }

        private async System.Threading.Tasks.Task FetchIrrigationHistoryAsync()
        {
            try
            {
                var response = await _client.GetAsync("http://localhost:3000/getIrrigation");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Không thể lấy lịch sử tưới nước.");
                    return;
                }
                string json = await response.Content.ReadAsStringAsync();
                var jss = new JavaScriptSerializer();
                irrigationList = jss.Deserialize<List<IrrigationRecord>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy lịch sử tưới:\n" + ex.Message);
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DisplayFilteredData();
        }

        private void DisplayFilteredData()
        {
            if (startDatePicker == null || endDatePicker == null) return;

            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            var filtered = irrigationList
                .Where(r => DateTime.TryParse(r.Date, out var date)
                         && date.Date >= startDate
                         && date.Date <= endDate)
                .ToList();

            dataHistory.Columns.Clear();
            dataHistory.Rows.Clear();
            dataHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataHistory.Columns.Add("colDate", "Ngày");
            dataHistory.Columns.Add("colHour", "Giờ");

            foreach (var record in filtered)
            {
                dataHistory.Rows.Add(record.Date, record.Hour);
            }
        }

        private void gardenList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await FetchIrrigationHistoryAsync();
            DisplayFilteredData();
        }
    }
}
