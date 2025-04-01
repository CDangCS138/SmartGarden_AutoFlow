using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_History : UserControl
    {
        // Dữ liệu mẫu
        private List<GardenData> gardenDataList = new List<GardenData>
        {
            new GardenData { GardenName = "Vườn A", DeviceCode = "A1", DeviceName = "Cảm biến nhiệt độ", MeasureTime = DateTime.Parse("2025-03-10"), Element = "Nhiệt độ", Value = "28.5°C" },
            new GardenData { GardenName = "Vườn A", DeviceCode = "A2", DeviceName = "Cảm biến độ ẩm", MeasureTime = DateTime.Parse("2025-03-11"), Element = "Độ ẩm không khí", Value = "65%" },
            new GardenData { GardenName = "Vườn B", DeviceCode = "B1", DeviceName = "Cảm biến ánh sáng", MeasureTime = DateTime.Parse("2025-03-12"), Element = "Cường độ ánh sáng", Value = "500 Lux" },
            new GardenData { GardenName = "Vườn B", DeviceCode = "B2", DeviceName = "Máy bơm nước", MeasureTime = DateTime.Parse("2025-03-13"), Element = "Máy bơm", Value = "Bật" }
        };

        // Lớp dữ liệu mẫu
        class GardenData
        {
            public string GardenName { get; set; }
            public string DeviceCode { get; set; }
            public string DeviceName { get; set; }
            public DateTime MeasureTime { get; set; }
            public string Element { get; set; }
            public string Value { get; set; }
        }

        public UC_History()
        {
            InitializeComponent();

            this.Load += UC_History_Load;
            gardenList.SelectedIndexChanged += gardenList_SelectedIndexChanged;
            elementList.SelectedIndexChanged += elementList_SelectedIndexChanged;
            startDatePicker.ValueChanged += startDatePicker_ValueChanged;
            endDatePicker.ValueChanged += endDatePicker_ValueChanged;
        }

        private void UC_History_Load(object sender, EventArgs e)
        {
            LoadGardenList();
            LoadElementList();
        }

        private void LoadGardenList()
        {
            var uniqueGardens = gardenDataList.Select(g => g.GardenName).Distinct().ToList();
            gardenList.Items.Clear();
            gardenList.Items.AddRange(uniqueGardens.ToArray());
            if (gardenList.Items.Count > 0)
                gardenList.SelectedIndex = 0;
        }

        private void LoadElementList()
        {
            var uniqueElements = gardenDataList.Select(g => g.Element).Distinct().ToList();
            elementList.Items.Clear();
            elementList.Items.AddRange(uniqueElements.ToArray());
            if (elementList.Items.Count > 0)
                elementList.SelectedIndex = 0;
        }

        private void LoadData()
        {
            if (gardenList.SelectedItem == null || elementList.SelectedItem == null) return;

            string selectedGarden = gardenList.SelectedItem.ToString();
            string selectedElement = elementList.SelectedItem.ToString();
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            var filteredData = gardenDataList
                .Where(g => g.GardenName == selectedGarden &&
                            g.Element == selectedElement &&
                            g.MeasureTime.Date >= startDate &&
                            g.MeasureTime.Date <= endDate)
                .ToList();

            SetupGridForAttribute(selectedElement);
            dataHistory.Rows.Clear();

            foreach (var item in filteredData)
            {
                if (selectedElement == "Nhiệt độ" || selectedElement == "Độ ẩm không khí")
                {
                    dataHistory.Rows.Add(item.DeviceName, item.DeviceCode, item.MeasureTime.ToString("yyyy-MM-dd"), item.Value);
                }
                else if (selectedElement == "Độ ẩm đất")
                {
                    dataHistory.Rows.Add(item.DeviceName, item.DeviceCode, item.MeasureTime.ToString("yyyy-MM-dd"), item.Value, "10cm");
                }
                else if (selectedElement == "Cường độ ánh sáng" || selectedElement == "Máy bơm" || selectedElement == "Đèn chiếu sáng" || selectedElement == "Màn hình hiển thị")
                {
                    dataHistory.Rows.Add(item.DeviceName, item.DeviceCode, item.MeasureTime.ToString("yyyy-MM-dd"), item.Value);
                }
            }
        }

        private void SetupGridForAttribute(string attributeName)
        {
            dataHistory.Columns.Clear();
            dataHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            switch (attributeName)
            {
                case "Nhiệt độ":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colValue", "Giá trị (°C)");
                    break;

                case "Độ ẩm không khí":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colValue", "Độ ẩm (%)");
                    break;

                case "Độ ẩm đất":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colSoilMoisture", "Độ ẩm đất (%)");
                    dataHistory.Columns.Add("colDepth", "Độ sâu (cm)");
                    break;

                case "Cường độ ánh sáng":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colLight", "Lux");
                    break;

                case "Máy bơm":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colPumpStatus", "Trạng thái");
                    break;

                case "Đèn chiếu sáng":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colLampStatus", "Trạng thái");
                    break;

                case "Màn hình hiển thị":
                    dataHistory.Columns.Add("colDeviceName", "Tên thiết bị");
                    dataHistory.Columns.Add("colDeviceCode", "Mã thiết bị");
                    dataHistory.Columns.Add("colMeasureTime", "Thời gian đo");
                    dataHistory.Columns.Add("colScreenStatus", "Nội dung hiển thị");
                    break;

                default:
                    break;
            }
        }

        private void gardenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void elementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
