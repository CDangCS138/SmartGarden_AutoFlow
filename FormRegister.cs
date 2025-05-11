using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;  

namespace SmartGarden_AutoFlow
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            lblRegisterError.Visible = false;
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblRegisterError.Text = "Vui lòng nhập đầy đủ thông tin.";
                lblRegisterError.Visible = true;
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var payload = JsonConvert.SerializeObject(new { email = username, password });
                    var content = new StringContent(payload, Encoding.UTF8, "application/json");

                    var resp = await client.PostAsync("http://localhost:3000/signup", content);
                    if (resp.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Form1().Show();
                    }
                    else
                    {
                        var err = await resp.Content.ReadAsStringAsync();
                        lblRegisterError.Text = $"Lỗi: {err}";
                        lblRegisterError.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblRegisterError.Text = $"Không kết nối được server.\n{ex.Message}";
                lblRegisterError.Visible = true;
            }
        }


        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
