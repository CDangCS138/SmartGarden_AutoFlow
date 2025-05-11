using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            var email = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Vui lòng nhập email và mật khẩu.";
                labelError.Visible = true;
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var payload = $"{{\"email\":\"{email}\",\"password\":\"{password}\"}}";
                    var content = new StringContent(payload, Encoding.UTF8, "application/json");
                    var resp = await client.PostAsync("http://localhost:3000/signin", content);

                    var token = await resp.Content.ReadAsStringAsync();
                    if (resp.IsSuccessStatusCode)
                    {
                        Program.UserToken = token;
                        this.Hide();
                        new Dashboard().Show();
                    }
                    else
                    {
                        labelError.Text = token;
                        labelError.Visible = true;
                        txtPassword.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                labelError.Text = $"Lỗi kết nối:\n{ex.Message}";
                labelError.Visible = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }
    }
}
