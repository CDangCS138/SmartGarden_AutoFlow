namespace SmartGarden_AutoFlow.All_User_Control
{
    partial class UC_Control
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.circleTemperature = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleSoil = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleAir = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.chartSensorData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPumpIntensity = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.autoPump = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.numWaterPeriod = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numWaterHour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterHour)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // circleTemperature
            // 
            this.circleTemperature.BackColor = System.Drawing.Color.Transparent;
            this.circleTemperature.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleTemperature.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleTemperature.ForeColor = System.Drawing.Color.DarkGray;
            this.circleTemperature.Location = new System.Drawing.Point(1261, 49);
            this.circleTemperature.Maximum = 50;
            this.circleTemperature.Minimum = 0;
            this.circleTemperature.Name = "circleTemperature";
            this.circleTemperature.ProgressColor = System.Drawing.Color.PaleGreen;
            this.circleTemperature.ProgressColor2 = System.Drawing.Color.OrangeRed;
            this.circleTemperature.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleTemperature.ShowText = true;
            this.circleTemperature.Size = new System.Drawing.Size(228, 228);
            this.circleTemperature.TabIndex = 1;
            this.circleTemperature.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleTemperature.ValueChanged += new System.EventHandler(this.circleTemperature_ValueChanged);
            // 
            // circleSoil
            // 
            this.circleSoil.BackColor = System.Drawing.Color.Transparent;
            this.circleSoil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleSoil.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.circleSoil.ForeColor = System.Drawing.Color.DarkGray;
            this.circleSoil.Location = new System.Drawing.Point(1562, 49);
            this.circleSoil.Minimum = 0;
            this.circleSoil.Name = "circleSoil";
            this.circleSoil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleSoil.ShowText = true;
            this.circleSoil.Size = new System.Drawing.Size(228, 228);
            this.circleSoil.TabIndex = 2;
            this.circleSoil.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleSoil.ValueChanged += new System.EventHandler(this.circleSoil_ValueChanged);
            // 
            // circleAir
            // 
            this.circleAir.BackColor = System.Drawing.Color.Transparent;
            this.circleAir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleAir.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.circleAir.ForeColor = System.Drawing.Color.DarkGray;
            this.circleAir.Location = new System.Drawing.Point(1261, 330);
            this.circleAir.Minimum = 0;
            this.circleAir.Name = "circleAir";
            this.circleAir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleAir.ShowText = true;
            this.circleAir.Size = new System.Drawing.Size(228, 228);
            this.circleAir.TabIndex = 3;
            this.circleAir.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleAir.ValueChanged += new System.EventHandler(this.circleAir_ValueChanged);
            // 
            // chartSensorData
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Thời gian";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartSensorData.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.DarkGray;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartSensorData.Legends.Add(legend1);
            this.chartSensorData.Location = new System.Drawing.Point(93, 38);
            this.chartSensorData.Name = "chartSensorData";
            this.chartSensorData.Size = new System.Drawing.Size(1071, 533);
            this.chartSensorData.TabIndex = 5;
            this.chartSensorData.Text = "chart1";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.trackBarPumpIntensity);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.autoPump);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(93, 634);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(533, 112);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy bơm: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBarPumpIntensity
            // 
            this.trackBarPumpIntensity.LargeChange = 25;
            this.trackBarPumpIntensity.Location = new System.Drawing.Point(133, 3);
            this.trackBarPumpIntensity.Maximum = 255;
            this.trackBarPumpIntensity.Name = "trackBarPumpIntensity";
            this.trackBarPumpIntensity.Size = new System.Drawing.Size(300, 45);
            this.trackBarPumpIntensity.SmallChange = 5;
            this.trackBarPumpIntensity.TabIndex = 0;
            this.trackBarPumpIntensity.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarPumpIntensity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarPumpIntensity_Scroll);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thủ công: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoPump
            // 
            this.autoPump.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.autoPump.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.autoPump.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.autoPump.CheckedState.InnerColor = System.Drawing.Color.White;
            this.autoPump.Location = new System.Drawing.Point(133, 54);
            this.autoPump.Name = "autoPump";
            this.autoPump.Size = new System.Drawing.Size(133, 45);
            this.autoPump.TabIndex = 5;
            this.autoPump.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.autoPump.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.autoPump.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.autoPump.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(318, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numWaterPeriod
            // 
            this.numWaterPeriod.BackColor = System.Drawing.Color.Transparent;
            this.numWaterPeriod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numWaterPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numWaterPeriod.Location = new System.Drawing.Point(212, 54);
            this.numWaterPeriod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWaterPeriod.Name = "numWaterPeriod";
            this.numWaterPeriod.Size = new System.Drawing.Size(100, 45);
            this.numWaterPeriod.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian tưới:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(318, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "h";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numWaterHour
            // 
            this.numWaterHour.BackColor = System.Drawing.Color.Transparent;
            this.numWaterHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numWaterHour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numWaterHour.Location = new System.Drawing.Point(212, 3);
            this.numWaterHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWaterHour.Name = "numWaterHour";
            this.numWaterHour.Size = new System.Drawing.Size(100, 45);
            this.numWaterHour.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giờ tưới mỗi ngày: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.numWaterHour);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.numWaterPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1261, 639);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 112);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(439, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.chartSensorData);
            this.Controls.Add(this.circleAir);
            this.Controls.Add(this.circleSoil);
            this.Controls.Add(this.circleTemperature);
            this.Name = "UC_Control";
            this.Size = new System.Drawing.Size(1882, 835);
            this.Tag = "";
            this.Load += new System.EventHandler(this.UC_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWaterPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterHour)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleTemperature;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleSoil;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleAir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorData;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch autoPump;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numWaterHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown numWaterPeriod;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarPumpIntensity;
        private System.Windows.Forms.Label label7;
    }
}
