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
                new Device
                {
                    TenThietBi  = "Sensor nhiệt độ",
                    LoaiThietBi = "Thiết bị đầu vào",
                    MaThietBi   = "DHT11",
                    KhuVuon     = "Nhà kính 1",
                    TrangThai   = "Bật"
                },
                new Device
                {
                    TenThietBi  = "Sensor độ ẩm",
                    LoaiThietBi = "Thiết bị đầu vào",
                    MaThietBi   = "DHT22",
                    KhuVuon     = "Nhà kính 2",
                    TrangThai   = "Tắt"
                },
                new Device
                {
                    TenThietBi  = "Bơm nước",
                    LoaiThietBi = "Thiết bị đầu ra",
                    MaThietBi   = "PUMP01",
                    KhuVuon     = "Nhà kính 3",
                    TrangThai   = "Bật"
                }
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