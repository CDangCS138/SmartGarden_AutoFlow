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
    public partial class frmEditUser : Form
    {
        private User user;
        public frmEditUser(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            txtTenNguoiDung.Text = user.TenNguoiDung;
            cboViTri.Text = user.ViTri;
            txtSoDienThoai.Text = user.SoDienThoai;
            txtEmail.Text = user.Email;
            dateNgayThue.Value = user.NgayThue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.TenNguoiDung = txtTenNguoiDung.Text;
            user.ViTri = cboViTri.Text;
            user.SoDienThoai = txtSoDienThoai.Text;
            user.Email = txtEmail.Text;
            user.NgayThue = dateNgayThue.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

    }
}
