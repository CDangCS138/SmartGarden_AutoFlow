using SmartGarden_AutoFlow.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_Devices : UserControl
    {

        BindingList<Device> devices;

        public UC_Devices()
        {
            InitializeComponent();
        }

        private void UC_Devices_Load(object sender, EventArgs e)
        {

            SetupDataGridView();

            devices = new BindingList<Device>()
            {
                new Device { TenThietBi = "Cảm biến độ ẩm không khí", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "DHT11", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Cảm biến nhiệt độ", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "DHT22", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Cảm biến độ ẩm đất", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "SoilMoisture01", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Cảm biến mưa", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "RainSensor", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Máy bơm nước chính", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "Pump01", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Van tưới khu A", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "ValveA", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Van tưới khu B", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "ValveB", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Cảm biến ánh sáng", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "LDR01", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Relay điều khiển đèn", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "RelayLight", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Hệ thống quạt gió", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "FanSys", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Cảm biến CO2", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "CO2Sensor", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Đồng hồ thời gian tưới", LoaiThietBi = "Thiết bị điều khiển", MaThietBi = "Timer01", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Điều khiển độ ẩm", LoaiThietBi = "Thiết bị điều khiển", MaThietBi = "HumidityCtrl", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Cảm biến pH đất", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "pHSensor", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Cảm biến nhiệt độ nước", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "WaterTemp", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Camera giám sát", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "Camera01", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Relay máy phun sương", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "RelayMist", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" },
                new Device { TenThietBi = "Máy tạo ẩm", LoaiThietBi = "Thiết bị đầu ra", MaThietBi = "Humidifier", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Bộ thu thập dữ liệu trung tâm", LoaiThietBi = "Thiết bị trung tâm", MaThietBi = "DataHub", KhuVuon = "Khu vườn 1", TrangThai = "Bật" },
                new Device { TenThietBi = "Cảm biến gió", LoaiThietBi = "Thiết bị đầu vào", MaThietBi = "WindSensor", KhuVuon = "Khu vườn 1", TrangThai = "Tắt" }
            };

            dataDevices.DataSource = devices;

            dataDevices.CellFormatting += dataDevices_CellFormatting;
        }

        private void SetupDataGridView()
        {

            dataDevices.Columns.Clear();

            dataDevices.AutoGenerateColumns = false;

            var colTenThietBi = new DataGridViewTextBoxColumn();
            colTenThietBi.HeaderText = "Tên thiết bị";
            colTenThietBi.Name = "TenThietBi";
            colTenThietBi.DataPropertyName = "TenThietBi";
            dataDevices.Columns.Add(colTenThietBi);

            var colLoaiThietBi = new DataGridViewTextBoxColumn();
            colLoaiThietBi.HeaderText = "Loại thiết bị";
            colLoaiThietBi.Name = "LoaiThietBi";
            colLoaiThietBi.DataPropertyName = "LoaiThietBi";
            dataDevices.Columns.Add(colLoaiThietBi);

            var colMaThietBi = new DataGridViewTextBoxColumn();
            colMaThietBi.HeaderText = "Mã thiết bị";
            colMaThietBi.Name = "MaThietBi";
            colMaThietBi.DataPropertyName = "MaThietBi";
            dataDevices.Columns.Add(colMaThietBi);

            var colKhuVuon = new DataGridViewTextBoxColumn();
            colKhuVuon.HeaderText = "Khu vườn";
            colKhuVuon.Name = "KhuVuon";
            colKhuVuon.DataPropertyName = "KhuVuon";
            dataDevices.Columns.Add(colKhuVuon);

            var colTrangThai = new DataGridViewTextBoxColumn();
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.Name = "TrangThai";
            colTrangThai.DataPropertyName = "TrangThai";
            dataDevices.Columns.Add(colTrangThai);

            var colAction = new DataGridViewButtonColumn();
            colAction.HeaderText = "Action";
            colAction.Name = "colAction";
            colAction.Text = "Chỉnh sửa";
            colAction.UseColumnTextForButtonValue = true;
            dataDevices.Columns.Add(colAction);

            dataDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDevices.AllowUserToAddRows = false;
        }

        private void dataDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataDevices.Columns[e.ColumnIndex].Name == "colAction")
            {
                Device device = dataDevices.Rows[e.RowIndex].DataBoundItem as Device;
                if (device != null)
                {
                    using (frmEditDevice editForm = new frmEditDevice(device))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            if (editForm.IsDeleted)
                            {
                                devices.Remove(device);
                            }
                            dataDevices.Refresh();
                        }
                    }
                }
            }

        }
        private void dataDevices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            using (frmAddDevice addForm = new frmAddDevice())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewDevice != null)
                {
                    devices.Add(addForm.NewDevice);
                    dataDevices.Refresh();
                }
            }
        }
    }

    public class Device
    {
        public string TenThietBi { get; set; }
        public string LoaiThietBi { get; set; }
        public string MaThietBi { get; set; }
        public string KhuVuon { get; set; }
        public string TrangThai { get; set; }
    }
}