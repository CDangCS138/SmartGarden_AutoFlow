namespace SmartGarden_AutoFlow.All_User_Control
{
    partial class UC_History
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
            this.gardenList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.elementList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.startDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.endDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // gardenList
            // 
            this.gardenList.BackColor = System.Drawing.Color.Transparent;
            this.gardenList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gardenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gardenList.FocusedColor = System.Drawing.Color.Empty;
            this.gardenList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gardenList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gardenList.ItemHeight = 30;
            this.gardenList.Items.AddRange(new object[] {
            "Khu vườn 1",
            "Khu vườn 2",
            "Khu vườn 3"});
            this.gardenList.Location = new System.Drawing.Point(275, 3);
            this.gardenList.Name = "gardenList";
            this.gardenList.Size = new System.Drawing.Size(200, 36);
            this.gardenList.TabIndex = 2;
            this.gardenList.SelectedIndexChanged += new System.EventHandler(this.gardenList_SelectedIndexChanged);
            // 
            // dataHistory
            // 
            this.dataHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Location = new System.Drawing.Point(54, 223);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.Size = new System.Drawing.Size(1763, 572);
            this.dataHistory.TabIndex = 1;
            // 
            // elementList
            // 
            this.elementList.BackColor = System.Drawing.Color.Transparent;
            this.elementList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.elementList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementList.FocusedColor = System.Drawing.Color.Empty;
            this.elementList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.elementList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.elementList.ItemHeight = 30;
            this.elementList.Items.AddRange(new object[] {
            "Nhiệt độ",
            "Độ ẩm không khí",
            "Độ ẩm đất",
            "Cường độ ánh sáng",
            "Máy bơm",
            "Đèn chiếu sáng",
            "Màn hình hiển thị"});
            this.elementList.Location = new System.Drawing.Point(275, 3);
            this.elementList.Name = "elementList";
            this.elementList.Size = new System.Drawing.Size(200, 36);
            this.elementList.TabIndex = 3;
            this.elementList.SelectedIndexChanged += new System.EventHandler(this.elementList_SelectedIndexChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Checked = true;
            this.startDatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.startDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDatePicker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDatePicker.Location = new System.Drawing.Point(275, 3);
            this.startDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 36);
            this.startDatePicker.TabIndex = 4;
            this.startDatePicker.Value = new System.DateTime(2025, 3, 25, 19, 35, 26, 998);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Checked = true;
            this.endDatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.endDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDatePicker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDatePicker.Location = new System.Drawing.Point(275, 3);
            this.endDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 36);
            this.endDatePicker.TabIndex = 5;
            this.endDatePicker.Value = new System.DateTime(2025, 3, 25, 19, 35, 40, 22);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lịch sử";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1378, 116);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn khu vườn: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.gardenList);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(611, 48);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.elementList);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(620, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(611, 48);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn thuộc tính: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.startDatePicker);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(611, 48);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày bắt đầu dữ liệu: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.endDatePicker);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(620, 57);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(611, 48);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày kết thúc dữ liệu: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataHistory);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(1882, 835);
            this.Load += new System.EventHandler(this.UC_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView dataHistory;
        private Guna.UI2.WinForms.Guna2ComboBox gardenList;
        private Guna.UI2.WinForms.Guna2ComboBox elementList;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
    }
}
