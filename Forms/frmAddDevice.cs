using SmartGarden_AutoFlow.All_User_Control;
using System;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.Forms
{
    public partial class frmAddDevice : Form
    {
        public Device NewDevice { get; private set; }

        public frmAddDevice()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            cboLoaiThietBi.Items.AddRange(new string[] { "Thiết bị đầu vào", "Thiết bị đầu ra" });
            cboKhuVuon.Items.AddRange(new string[] { "Nhà kính 1", "Nhà kính 2", "Nhà kính 3" });
            cboTrangThai.Items.AddRange(new string[] { "Bật", "Tắt" });

            cboLoaiThietBi.SelectedIndex = 0;
            cboKhuVuon.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            NewDevice = new Device
            {
                TenThietBi = txtTenThietBi.Text.Trim(),
                LoaiThietBi = cboLoaiThietBi.SelectedItem.ToString(),
                MaThietBi = txtMaThietBi.Text.Trim(),
                KhuVuon = cboKhuVuon.SelectedItem.ToString(),
                TrangThai = cboTrangThai.SelectedItem.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddDevice_Load(object sender, EventArgs e)
        {

        }
    }
}
