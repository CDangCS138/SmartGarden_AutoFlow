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
    public partial class UC_Profile : UserControl
    {
        private string originalName;
        private string originalEmail;
        private string originalPhone;
        private string originalAddress;
        private string originalGender;
        private Image originalAvatar;
        private User currentUser;
        public UC_Profile()
        {
            InitializeComponent();
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            currentUser = new User
            {
                Name = "Nguyễn Văn A",
                Email = "vana@example.com",
                PhoneNumber = "0123456789",
                Address = "123 Đường ABC, Quận 1",
                Gender = "Nữ",
                Password = "123456"
            };

            LoadUserData(currentUser);
            SetEditingMode(false);
            SetPasswordEditingMode(false);
        }

        private void LoadUserData(User user)
        {
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtAddress.Text = user.Address;

            // Set giới tính
            cboGender.Items.Clear();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            // Chọn item khớp với user.Gender
            cboGender.SelectedItem = user.Gender;

            // Set avatar
            if (user.Avatar != null)
            {
                picAvatar.Image = user.Avatar;
            }
            else
            {
                // Nếu chưa có avatar, lấy default theo giới tính
                SetDefaultAvatar(user.Gender);
            }
        }

        private void SetDefaultAvatar(string gender)
        {
            if (gender == "Nữ")
            {
                picAvatar.Image = Properties.Resources.female;
            }
            else
            {
                picAvatar.Image = Properties.Resources.male;
            }
        }

        private void SetEditingMode(bool isEditing)
        {
            // TextBox => ReadOnly
            txtName.ReadOnly = !isEditing;
            txtEmail.ReadOnly = !isEditing;
            txtPhoneNumber.ReadOnly = !isEditing;
            txtAddress.ReadOnly = !isEditing;

            // ComboBox => có cho thay đổi không
            cboGender.Enabled = isEditing;

            // Đổi nút
            btnEdit.Visible = !isEditing;
            btnSave.Visible = isEditing;
            btnCancel.Visible = isEditing;

            // Nếu là chế độ xem => màu xám, chế độ sửa => màu trắng
            Color viewColor = SystemColors.Control;
            Color editColor = Color.White;

            txtName.BackColor = isEditing ? editColor : viewColor;
            txtEmail.BackColor = isEditing ? editColor : viewColor;
            txtPhoneNumber.BackColor = isEditing ? editColor : viewColor;
            txtAddress.BackColor = isEditing ? editColor : viewColor;
        }
        private void StoreOriginalData()
        {
            originalName = txtName.Text;
            originalEmail = txtEmail.Text;
            originalPhone = txtPhoneNumber.Text;
            originalAddress = txtAddress.Text;
            originalGender = cboGender.SelectedItem?.ToString() ?? "Nam";
            originalAvatar = picAvatar.Image;
        }
        private void RestoreOriginalData()
        {
            txtName.Text = originalName;
            txtEmail.Text = originalEmail;
            txtPhoneNumber.Text = originalPhone;
            txtAddress.Text = originalAddress;
            cboGender.SelectedItem = originalGender;
            picAvatar.Image = originalAvatar;
        }

        private void SaveUserData(User user)
        {
            user.Name = txtName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.PhoneNumber = txtPhoneNumber.Text.Trim();
            user.Address = txtAddress.Text.Trim();
            user.Gender = cboGender.SelectedItem?.ToString() ?? "Nam"; // mặc định Nam
            user.Avatar = picAvatar.Image;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            if (!btnSave.Visible)
            {
                // Nếu chưa ấn Edit thì không cho đổi ảnh
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image newImage = Image.FromFile(ofd.FileName);
                        picAvatar.Image = newImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở file ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StoreOriginalData();

            // Chuyển sang chế độ chỉnh sửa
            SetEditingMode(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUserData(currentUser);

            // Chuyển về chế độ xem
            SetEditingMode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RestoreOriginalData();

            // Chuyển về chế độ xem
            SetEditingMode(false);
        }

        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string Gender { get; set; }
            public string Password { get; set; }
            public Image Avatar { get; set; }
        }
        private void SetPasswordEditingMode(bool isEditing)
        {
            // Cho phép nhập liệu nếu isEditing == true, ngược lại không cho nhập
            txtCurrPass.ReadOnly = !isEditing;
            txtNewPass.ReadOnly = !isEditing;
            txtConfirmPass.ReadOnly = !isEditing;

            // Cập nhật hiển thị các nút
            btnEditPass.Visible = !isEditing;
            btnSavePass.Visible = isEditing;
            btnCancelPass.Visible = isEditing;

            // Nếu không ở chế độ sửa, xóa sạch các ô nhập
            if (!isEditing)
            {
                txtCurrPass.Text = "";
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
            }
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {
            SetPasswordEditingMode(true);
        }

        private void btnCancelPass_Click(object sender, EventArgs e)
        {
            SetPasswordEditingMode(false);
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu hiện tại
            if (txtCurrPass.Text.Trim() != currentUser.Password)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu mới và xác nhận
            if (string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới và xác nhận mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // (Tuỳ chọn) Kiểm tra độ mạnh của mật khẩu mới nếu cần
            // Ví dụ: kiểm tra độ dài, chữ số, ký tự đặc biệt, v.v...

            // Nếu mọi thứ đều hợp lệ, cập nhật mật khẩu
            currentUser.Password = txtNewPass.Text;
            MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Thoát chế độ chỉnh sửa
            SetPasswordEditingMode(false);
        }

    }
}
