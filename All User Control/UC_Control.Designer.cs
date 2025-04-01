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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.circleTemperature = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleSoil = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleAir = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleLight = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.chartSensorData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.togglePump = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleLight = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
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
            // circleLight
            // 
            this.circleLight.BackColor = System.Drawing.Color.Transparent;
            this.circleLight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleLight.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.circleLight.ForeColor = System.Drawing.Color.DarkGray;
            this.circleLight.Location = new System.Drawing.Point(1562, 330);
            this.circleLight.Maximum = 120;
            this.circleLight.Minimum = 0;
            this.circleLight.Name = "circleLight";
            this.circleLight.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleLight.ShowText = true;
            this.circleLight.Size = new System.Drawing.Size(228, 228);
            this.circleLight.TabIndex = 4;
            this.circleLight.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleLight.ValueChanged += new System.EventHandler(this.circleLight_ValueChanged);
            // 
            // chartSensorData
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Title = "Ngày";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartSensorData.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.DarkGray;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartSensorData.Legends.Add(legend2);
            this.chartSensorData.Location = new System.Drawing.Point(93, 38);
            this.chartSensorData.Name = "chartSensorData";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.DeepSkyBlue;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.SeaGreen;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Goldenrod;
            series8.Legend = "Legend1";
            series8.Name = "Series4";
            this.chartSensorData.Series.Add(series5);
            this.chartSensorData.Series.Add(series6);
            this.chartSensorData.Series.Add(series7);
            this.chartSensorData.Series.Add(series8);
            this.chartSensorData.Size = new System.Drawing.Size(1071, 533);
            this.chartSensorData.TabIndex = 5;
            this.chartSensorData.Text = "chart1";
            this.chartSensorData.Click += new System.EventHandler(this.chartSensorData_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.togglePump);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.toggleLight);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(93, 634);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 112);
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
            // togglePump
            // 
            this.togglePump.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.togglePump.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePump.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePump.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePump.CheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePump.Location = new System.Drawing.Point(133, 3);
            this.togglePump.Name = "togglePump";
            this.togglePump.Size = new System.Drawing.Size(133, 45);
            this.togglePump.TabIndex = 4;
            this.togglePump.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePump.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePump.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePump.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đèn: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleLight
            // 
            this.toggleLight.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLight.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLight.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLight.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLight.Location = new System.Drawing.Point(133, 54);
            this.toggleLight.Name = "toggleLight";
            this.toggleLight.Size = new System.Drawing.Size(133, 45);
            this.toggleLight.TabIndex = 5;
            this.toggleLight.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLight.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLight.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLight.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // UC_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.chartSensorData);
            this.Controls.Add(this.circleLight);
            this.Controls.Add(this.circleAir);
            this.Controls.Add(this.circleSoil);
            this.Controls.Add(this.circleTemperature);
            this.Name = "UC_Control";
            this.Size = new System.Drawing.Size(1882, 835);
            this.Tag = "";
            this.Load += new System.EventHandler(this.UC_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleTemperature;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleSoil;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleAir;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleLight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorData;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togglePump;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleLight;
    }
}
