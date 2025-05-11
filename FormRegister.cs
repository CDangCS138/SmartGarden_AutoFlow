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
            var email = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblRegisterError.Text = "Vui lòng nhập email và mật khẩu.";
                lblRegisterError.Visible = true;
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var payload = $"{{\"email\":\"{email}\",\"password\":\"{password}\"}}";
                    var content = new StringContent(payload, Encoding.UTF8, "application/json");
                    var resp = await client.PostAsync("http://localhost:3000/signup", content);

                    var message = await resp.Content.ReadAsStringAsync();
                    if (resp.IsSuccessStatusCode)
                    {
                        MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Form1().Show();
                    }
                    else
                    {
                        lblRegisterError.Text = message;
                        lblRegisterError.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblRegisterError.Text = $"Lỗi kết nối:\n{ex.Message}";
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
