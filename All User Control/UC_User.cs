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
    
        public partial class UC_User : UserControl
    {
        BindingList<User> users;
        public UC_User()
        {
            InitializeComponent();
        }
        private void SetupDataGridView()
        {
            dataUsers.Columns.Clear();
            dataUsers.AutoGenerateColumns = false;

            var colTenNguoiDung=new DataGridViewTextBoxColumn();
            colTenNguoiDung.HeaderText = "Tên người dùng";
            colTenNguoiDung.Name = "TenNguoiDung";
            colTenNguoiDung.DataPropertyName = "TenNguoiDung";
            dataUsers.Columns.Add(colTenNguoiDung);

            var colViTri = new DataGridViewTextBoxColumn();
            colViTri.HeaderText = "Vị trí";
            colViTri.Name = "ViTri";
            colViTri.DataPropertyName = "ViTri";
            dataUsers.Columns.Add(colViTri);

            var colNgayThue = new DataGridViewTextBoxColumn();
            colNgayThue.HeaderText = "Ngày thuê";
            colNgayThue.Name = "NgayThue";
            colNgayThue.DataPropertyName = "NgayThue";
            dataUsers.Columns.Add(colNgayThue);

            var colSoDienThoai = new DataGridViewTextBoxColumn();
            colSoDienThoai.HeaderText = "Số điện thoại";
            colSoDienThoai.Name = "SoDienThoai";
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            dataUsers.Columns.Add(colSoDienThoai);

            var colEmail = new DataGridViewTextBoxColumn();
            colEmail.HeaderText = "Email";
            colEmail.Name = "Email";
            colEmail.DataPropertyName = "Email";
            dataUsers.Columns.Add(colEmail);

            var colAction = new DataGridViewButtonColumn();
            colAction.HeaderText = "Action";
            colAction.Name = "colAction";
            colAction.Text = "Chỉnh sửa";
            colAction.UseColumnTextForButtonValue = true;
            dataUsers.Columns.Add(colAction);
        }
        private void UC_User_Load(object sender, EventArgs e)
        {
            users = new BindingList<User>
            {
                new User { TenNguoiDung = "Nguyễn Văn A", ViTri = "Công nhân", NgayThue = DateTime.Now.AddDays(-10), SoDienThoai = "0123456789", Email = "nguyenvana@example.com" },
                new User { TenNguoiDung = "Trần Thị B", ViTri = "Quản lý", NgayThue = DateTime.Now.AddDays(-20), SoDienThoai = "0987654321", Email = "tranthib@example.com" },
                new User { TenNguoiDung = "Lê Văn C", ViTri = "Quản lý", NgayThue = DateTime.Now.AddDays(-5), SoDienThoai = "0345678901", Email = "levanc@example.com" }
            };

            SetupDataGridView();
            dataUsers.DataSource = users;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataUsers.Columns[e.ColumnIndex].Name == "colAction")
            {
                User user = dataUsers.Rows[e.RowIndex].DataBoundItem as User;
                if (user != null)
                {
                    using (frmEditUser editForm = new frmEditUser(user))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            if (editForm.IsDeleted)
                            {
                                users.Remove(user);
                            }
                            dataUsers.Refresh();
                        }
                    }
                }
            }
        }

    }
    public class User
    {
        public string TenNguoiDung { get; set; }
        public string ViTri { get; set; }
        public DateTime NgayThue { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}
