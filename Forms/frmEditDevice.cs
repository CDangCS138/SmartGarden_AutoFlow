using SmartGarden_AutoFlow.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.Forms
{
    public partial class frmEditDevice : Form
    {
        private Device device;

        public frmEditDevice(Device device)
        {
            InitializeComponent();
            this.device = device;
            LoadDeviceData();
        }

        private void LoadDeviceData()
        {
            txtTenThietBi.Text = device.TenThietBi;
            cboLoaiThietBi.Text = device.LoaiThietBi;
            txtMaThietBi.Text = device.MaThietBi;
            cboKhuVuon.Text = device.KhuVuon;
            cboTrangThai.Text = device.TrangThai;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            device.TenThietBi = txtTenThietBi.Text;
            device.LoaiThietBi = cboLoaiThietBi.Text;
            device.MaThietBi = txtMaThietBi.Text;
            device.KhuVuon = cboKhuVuon.Text;
            device.TrangThai = cboTrangThai.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IsDeleted = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public bool IsDeleted { get; private set; } = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditDevice_Load(object sender, EventArgs e)
        {

        }
    }

}
