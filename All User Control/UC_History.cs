using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_History : UserControl
    {
        private List<GardenData> gardenDataList = new List<GardenData>
        {
            new GardenData { GardenName = "Vườn A", DeviceCode = "A1", DeviceName = "Cảm biến nhiệt độ", MeasureTime = DateTime.Parse("2025-03-10"), Element = "Nhiệt độ", Value = "28.5°C" },
            new GardenData { GardenName = "Vườn A", DeviceCode = "A2", DeviceName = "Cảm biến độ ẩm", MeasureTime = DateTime.Parse("2025-03-11"), Element = "Độ ẩm không khí", Value = "65%" },
            new GardenData { GardenName = "Vườn B", DeviceCode = "B1", DeviceName = "Cảm biến ánh sáng", MeasureTime = DateTime.Parse("2025-03-12"), Element = "Cường độ ánh sáng", Value = "500 Lux" },
            new GardenData { GardenName = "Vườn B", DeviceCode = "B2", DeviceName = "Máy bơm nước", MeasureTime = DateTime.Parse("2025-03-13"), Element = "Máy bơm", Value = "Bật" }
        };

        private List<IrrigationRecord> irrigationList = new List<IrrigationRecord>();
        private static readonly HttpClient _client = new HttpClient();

        public UC_History()
        {
            InitializeComponent();
            this.Load += UC_History_Load;
            gardenList.SelectedIndexChanged += gardenList_SelectedIndexChanged;
            elementList.SelectedIndexChanged += elementList_SelectedIndexChanged;
            startDatePicker.ValueChanged += startDatePicker_ValueChanged;
            endDatePicker.ValueChanged += endDatePicker_ValueChanged;
        }

        class GardenData
        {
            public string GardenName { get; set; }
            public string DeviceCode { get; set; }
            public string DeviceName { get; set; }
            public DateTime MeasureTime { get; set; }
            public string Element { get; set; }
            public string Value { get; set; }
        }

        class IrrigationRecord
        {
            public string Date { get; set; }
            public string Hour { get; set; }
        }

        private async void UC_History_Load(object sender, EventArgs e)
        {
            await FetchIrrigationHistoryAsync();
            LoadGardenList();
            LoadElementList();
        }

        private async Task FetchIrrigationHistoryAsync()
        {
            try
            {
                var response = await _client.GetAsync("http://localhost:3000/getIrrigation");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Lỗi server HTTP: {response.StatusCode}");
                    return;
                }
                string json = await response.Content.ReadAsStringAsync();
                var jss = new JavaScriptSerializer();
                irrigationList = jss.Deserialize<List<IrrigationRecord>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối hoặc parse JSON:\n{ex.Message}");
            }
        }

        private void LoadGardenList()
        {
            var uniqueGardens = gardenDataList.Select(g => g.GardenName).Distinct().ToArray();
            gardenList.Items.Clear();
            gardenList.Items.AddRange(uniqueGardens);
            if (gardenList.Items.Count > 0)
                gardenList.SelectedIndex = 0;
        }

        private void LoadElementList()
        {
            var uniqueElements = gardenDataList.Select(g => g.Element).Distinct().ToList();
            uniqueElements.Add("Lịch sử tưới");
            elementList.Items.Clear();
            elementList.Items.AddRange(uniqueElements.ToArray());
            if (elementList.Items.Count > 0)
                elementList.SelectedIndex = 0;
        }

        private void LoadData()
        {
            if (gardenList.SelectedItem == null || elementList.SelectedItem == null) return;

            string selGarden = gardenList.SelectedItem.ToString();
            string selElement = elementList.SelectedItem.ToString();
            DateTime start = startDatePicker.Value.Date;
            DateTime end = endDatePicker.Value.Date;

            dataHistory.Columns.Clear();
            dataHistory.Rows.Clear();
            dataHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (selElement == "Lịch sử tưới")
            {
                dataHistory.Columns.Add("colDate", "Ngày");
                dataHistory.Columns.Add("colHour", "Giờ");
                foreach (var rec in irrigationList)
                    dataHistory.Rows.Add(rec.Date, rec.Hour);
            }
            else
            {
                var filtered = gardenDataList
                    .Where(g => g.GardenName == selGarden &&
                                g.Element == selElement &&
                                g.MeasureTime.Date >= start &&
                                g.MeasureTime.Date <= end)
                    .ToList();

                SetupGridForAttribute(selElement);
                foreach (var item in filtered)
                {
                    if (selElement == "Độ ẩm đất")
                        dataHistory.Rows.Add(item.DeviceName, item.DeviceCode, item.MeasureTime.ToString("yyyy-MM-dd"), item.Value, "10cm");
                    else
                        dataHistory.Rows.Add(item.DeviceName, item.DeviceCode, item.MeasureTime.ToString("yyyy-MM-dd"), item.Value);
                }
            }
        }

        private void SetupGridForAttribute(string attributeName)
        {
            dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
            dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
            dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
            switch (attributeName)
            {
                case "Nhiệt độ": dataHistory.Columns.Add("colValue", "Giá trị (°C)"); break;
                case "Độ ẩm không khí": dataHistory.Columns.Add("colValue", "Độ ẩm (%)"); break;
                case "Độ ẩm đất": /* thêm trong LoadData */ break;
                case "Cường độ ánh sáng": dataHistory.Columns.Add("colValue", "Lux"); break;
                case "Máy bơm": dataHistory.Columns.Add("colValue", "Trạng thái"); break;
                case "Đèn chiếu sáng": dataHistory.Columns.Add("colValue", "Trạng thái"); break;
                case "Màn hình hiển thị": dataHistory.Columns.Add("colValue", "Nội dung hiển thị"); break;
            }
        }

        private void gardenList_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
        private void elementList_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
        private void startDatePicker_ValueChanged(object sender, EventArgs e) => LoadData();
        private void endDatePicker_ValueChanged(object sender, EventArgs e) => LoadData();
    }
}
