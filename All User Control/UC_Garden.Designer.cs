namespace SmartGarden_AutoFlow.All_User_Control
{
    partial class UC_Garden
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
            this.flowLayoutGarden = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGarden = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // flowLayoutGarden
            // 
            this.flowLayoutGarden.AutoScroll = true;
            this.flowLayoutGarden.Location = new System.Drawing.Point(35, 119);
            this.flowLayoutGarden.Name = "flowLayoutGarden";
            this.flowLayoutGarden.Size = new System.Drawing.Size(1804, 658);
            this.flowLayoutGarden.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khu vườn";
            // 
            // btnAddGarden
            // 
            this.btnAddGarden.BorderRadius = 10;
            this.btnAddGarden.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGarden.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGarden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGarden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddGarden.FillColor = System.Drawing.Color.Navy;
            this.btnAddGarden.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGarden.ForeColor = System.Drawing.Color.White;
            this.btnAddGarden.Location = new System.Drawing.Point(35, 65);
            this.btnAddGarden.Name = "btnAddGarden";
            this.btnAddGarden.Size = new System.Drawing.Size(147, 37);
            this.btnAddGarden.TabIndex = 0;
            this.btnAddGarden.Text = "Thêm khu vườn";
            this.btnAddGarden.Click += new System.EventHandler(this.btnAddGarden_Click);
            // 
            // UC_Garden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddGarden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutGarden);
            this.Name = "UC_Garden";
            this.Size = new System.Drawing.Size(1882, 835);
            this.Load += new System.EventHandler(this.UC_Garden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutGarden;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddGarden;
    }
}
