﻿namespace SmartGarden_AutoFlow
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDevice = new Guna.UI2.WinForms.Guna2Button();
            this.btnGarden = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnControl = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_History1 = new SmartGarden_AutoFlow.All_User_Control.UC_History();
            this.uC_User1 = new SmartGarden_AutoFlow.All_User_Control.UC_User();
            this.uC_Devices1 = new SmartGarden_AutoFlow.All_User_Control.UC_Devices();
            this.uC_Garden1 = new SmartGarden_AutoFlow.All_User_Control.UC_Garden();
            this.uC_Control1 = new SmartGarden_AutoFlow.All_User_Control.UC_Control();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnDevice);
            this.panel1.Controls.Add(this.btnGarden);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnControl);
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(14, 128);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(233, 14);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.BorderRadius = 18;
            this.btnUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(74)))));
            this.btnUser.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(1302, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(284, 116);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Người dùng";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.BorderRadius = 18;
            this.btnDevice.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDevice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDevice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDevice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDevice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDevice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(74)))));
            this.btnDevice.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevice.ForeColor = System.Drawing.Color.White;
            this.btnDevice.Location = new System.Drawing.Point(966, 6);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(284, 116);
            this.btnDevice.TabIndex = 3;
            this.btnDevice.Text = "Thiết bị";
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // btnGarden
            // 
            this.btnGarden.BorderRadius = 18;
            this.btnGarden.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGarden.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGarden.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGarden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGarden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGarden.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(74)))));
            this.btnGarden.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarden.ForeColor = System.Drawing.Color.White;
            this.btnGarden.Location = new System.Drawing.Point(641, 6);
            this.btnGarden.Name = "btnGarden";
            this.btnGarden.Size = new System.Drawing.Size(284, 116);
            this.btnGarden.TabIndex = 2;
            this.btnGarden.Text = "Khu vườn";
            this.btnGarden.Click += new System.EventHandler(this.btnGarden_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BorderRadius = 18;
            this.btnHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(74)))));
            this.btnHistory.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(323, 6);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(284, 116);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "Lịch sử";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnControl
            // 
            this.btnControl.BorderRadius = 18;
            this.btnControl.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(74)))));
            this.btnControl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.Color.White;
            this.btnControl.Location = new System.Drawing.Point(4, 6);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(284, 116);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "Bảng điều khiển";
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_Control1);
            this.panel2.Controls.Add(this.uC_History1);
            this.panel2.Controls.Add(this.uC_User1);
            this.panel2.Controls.Add(this.uC_Devices1);
            this.panel2.Controls.Add(this.uC_Garden1);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 852);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_History1
            // 
            this.uC_History1.BackColor = System.Drawing.Color.White;
            this.uC_History1.Location = new System.Drawing.Point(-1, -1);
            this.uC_History1.Name = "uC_History1";
            this.uC_History1.Size = new System.Drawing.Size(1882, 835);
            this.uC_History1.TabIndex = 1;
            // 
            // uC_User1
            // 
            this.uC_User1.BackColor = System.Drawing.Color.White;
            this.uC_User1.Location = new System.Drawing.Point(-1, -1);
            this.uC_User1.Name = "uC_User1";
            this.uC_User1.Size = new System.Drawing.Size(1882, 835);
            this.uC_User1.TabIndex = 4;
            // 
            // uC_Devices1
            // 
            this.uC_Devices1.BackColor = System.Drawing.Color.White;
            this.uC_Devices1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Devices1.Name = "uC_Devices1";
            this.uC_Devices1.Size = new System.Drawing.Size(1882, 835);
            this.uC_Devices1.TabIndex = 3;
            // 
            // uC_Garden1
            // 
            this.uC_Garden1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_Garden1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Garden1.Name = "uC_Garden1";
            this.uC_Garden1.Size = new System.Drawing.Size(1882, 835);
            this.uC_Garden1.TabIndex = 2;
            // 
            // uC_Control1
            // 
            this.uC_Control1.BackColor = System.Drawing.Color.White;
            this.uC_Control1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Control1.Name = "uC_Control1";
            this.uC_Control1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Control1.TabIndex = 0;
            this.uC_Control1.Tag = "Nhiệt";
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.PanelMoving.Location = new System.Drawing.Point(62, 148);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(300, 7);
            this.PanelMoving.TabIndex = 0;
            this.PanelMoving.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMoving_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::SmartGarden_AutoFlow.Properties.Resources.exit;
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnControl;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnGarden;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnDevice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private All_User_Control.UC_Control uC_Control1;
        private All_User_Control.UC_History uC_History1;
        private All_User_Control.UC_Garden uC_Garden1;
        private All_User_Control.UC_Devices uC_Devices1;
        private All_User_Control.UC_User uC_User1;
    }
}