namespace SmartGarden_AutoFlow.All_User_Control
{
    partial class UC_Devices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAddDevice = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataDevices = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BorderRadius = 10;
            this.btnAddDevice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDevice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDevice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDevice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDevice.FillColor = System.Drawing.Color.Navy;
            this.btnAddDevice.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.ForeColor = System.Drawing.Color.White;
            this.btnAddDevice.Location = new System.Drawing.Point(39, 65);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(123, 37);
            this.btnAddDevice.TabIndex = 2;
            this.btnAddDevice.Text = "Thêm thiết bị";
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý thiết bị";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.dataDevices);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1804, 658);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dataDevices
            // 
            this.dataDevices.BackgroundColor = System.Drawing.Color.White;
            this.dataDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevices.Location = new System.Drawing.Point(3, 3);
            this.dataDevices.Name = "dataDevices";
            this.dataDevices.ReadOnly = true;
            this.dataDevices.Size = new System.Drawing.Size(1789, 586);
            this.dataDevices.TabIndex = 2;
            this.dataDevices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDevices_CellContentClick);
            // 
            // UC_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.label1);
            this.Name = "UC_Devices";
            this.Size = new System.Drawing.Size(1882, 835);
            this.Load += new System.EventHandler(this.UC_Devices_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnAddDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataDevices;
    }
}
