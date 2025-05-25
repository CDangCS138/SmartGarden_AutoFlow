namespace SmartGarden_AutoFlow.All_User_Control
{
    partial class UC_GardenCard
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGardenName = new System.Windows.Forms.Label();
            this.lblPlantType = new System.Windows.Forms.Label();
            this.lblPlantingDate = new System.Windows.Forms.Label();
            this.lblHarvestDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSensor = new System.Windows.Forms.Label();
            this.flowLayoutSensor = new System.Windows.Forms.FlowLayoutPanel();
            this.tagSensor = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditGarden = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveGarden = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutSensor.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblGardenName);
            this.flowLayoutPanel1.Controls.Add(this.lblPlantType);
            this.flowLayoutPanel1.Controls.Add(this.lblPlantingDate);
            this.flowLayoutPanel1.Controls.Add(this.lblHarvestDate);
            this.flowLayoutPanel1.Controls.Add(this.lblStatus);
            this.flowLayoutPanel1.Controls.Add(this.lblSensor);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutSensor);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(317, 249);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblGardenName
            // 
            this.lblGardenName.AutoSize = true;
            this.lblGardenName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGardenName.Location = new System.Drawing.Point(3, 0);
            this.lblGardenName.Name = "lblGardenName";
            this.lblGardenName.Size = new System.Drawing.Size(82, 23);
            this.lblGardenName.TabIndex = 0;
            this.lblGardenName.Text = "Khu vườn ";
            // 
            // lblPlantType
            // 
            this.lblPlantType.AutoSize = true;
            this.lblPlantType.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantType.Location = new System.Drawing.Point(3, 28);
            this.lblPlantType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblPlantType.Name = "lblPlantType";
            this.lblPlantType.Size = new System.Drawing.Size(73, 19);
            this.lblPlantType.TabIndex = 1;
            this.lblPlantType.Text = "Khu vườn:";
            // 
            // lblPlantingDate
            // 
            this.lblPlantingDate.AutoSize = true;
            this.lblPlantingDate.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantingDate.Location = new System.Drawing.Point(3, 49);
            this.lblPlantingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lblPlantingDate.Name = "lblPlantingDate";
            this.lblPlantingDate.Size = new System.Drawing.Size(116, 19);
            this.lblPlantingDate.TabIndex = 2;
            this.lblPlantingDate.Text = "Ngày gieo trồng: ";
            // 
            // lblHarvestDate
            // 
            this.lblHarvestDate.AutoSize = true;
            this.lblHarvestDate.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarvestDate.Location = new System.Drawing.Point(3, 70);
            this.lblHarvestDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lblHarvestDate.Name = "lblHarvestDate";
            this.lblHarvestDate.Size = new System.Drawing.Size(115, 19);
            this.lblHarvestDate.TabIndex = 3;
            this.lblHarvestDate.Text = "Ngày thu hoạch: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 91);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Tình trạng: ";
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor.Location = new System.Drawing.Point(3, 112);
            this.lblSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(75, 19);
            this.lblSensor.TabIndex = 5;
            this.lblSensor.Text = "Cảm biến: ";
            // 
            // flowLayoutSensor
            // 
            this.flowLayoutSensor.Controls.Add(this.tagSensor);
            this.flowLayoutSensor.Location = new System.Drawing.Point(3, 134);
            this.flowLayoutSensor.Name = "flowLayoutSensor";
            this.flowLayoutSensor.Size = new System.Drawing.Size(311, 67);
            this.flowLayoutSensor.TabIndex = 7;
            // 
            // tagSensor
            // 
            this.tagSensor.BorderRadius = 8;
            this.tagSensor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tagSensor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tagSensor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tagSensor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tagSensor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(106)))), ((int)(((byte)(51)))));
            this.tagSensor.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSensor.ForeColor = System.Drawing.Color.White;
            this.tagSensor.Location = new System.Drawing.Point(3, 3);
            this.tagSensor.Name = "tagSensor";
            this.tagSensor.Size = new System.Drawing.Size(97, 25);
            this.tagSensor.TabIndex = 6;
            this.tagSensor.Text = "Cảm biến ";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnEditGarden);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.btnRemoveGarden);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 207);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(311, 35);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // btnEditGarden
            // 
            this.btnEditGarden.BorderRadius = 8;
            this.btnEditGarden.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGarden.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGarden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditGarden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditGarden.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditGarden.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGarden.ForeColor = System.Drawing.Color.White;
            this.btnEditGarden.Location = new System.Drawing.Point(3, 3);
            this.btnEditGarden.Name = "btnEditGarden";
            this.btnEditGarden.Size = new System.Drawing.Size(97, 31);
            this.btnEditGarden.TabIndex = 6;
            this.btnEditGarden.Text = "Chỉnh sửa";
            this.btnEditGarden.Click += new System.EventHandler(this.btnEditGarden_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(106, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(98, 31);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // btnRemoveGarden
            // 
            this.btnRemoveGarden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveGarden.BorderRadius = 8;
            this.btnRemoveGarden.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveGarden.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveGarden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveGarden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveGarden.FillColor = System.Drawing.Color.Crimson;
            this.btnRemoveGarden.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGarden.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGarden.Location = new System.Drawing.Point(210, 3);
            this.btnRemoveGarden.Name = "btnRemoveGarden";
            this.btnRemoveGarden.Size = new System.Drawing.Size(97, 31);
            this.btnRemoveGarden.TabIndex = 8;
            this.btnRemoveGarden.Text = "Xóa";
            this.btnRemoveGarden.Click += new System.EventHandler(this.btnRemoveGarden_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_GardenCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_GardenCard";
            this.Size = new System.Drawing.Size(346, 288);
            this.Load += new System.EventHandler(this.UC_GardenCard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutSensor.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblGardenName;
        private System.Windows.Forms.Label lblPlantType;
        private System.Windows.Forms.Label lblPlantingDate;
        private System.Windows.Forms.Label lblHarvestDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSensor;
        private Guna.UI2.WinForms.Guna2Button tagSensor;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Guna.UI2.WinForms.Guna2Button btnEditGarden;
        public Guna.UI2.WinForms.Guna2Button btnRemoveGarden;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}
