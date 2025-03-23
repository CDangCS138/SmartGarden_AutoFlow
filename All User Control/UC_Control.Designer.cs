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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.circleTemperature = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleSoil = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleAir = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleLight = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.chartSensorData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).BeginInit();
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
            chartArea10.AxisX.Interval = 1D;
            chartArea10.AxisX.IsLabelAutoFit = false;
            chartArea10.AxisX.LabelStyle.Angle = -45;
            chartArea10.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.Title = "Ngày";
            chartArea10.AxisX.TitleFont = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea10.BackSecondaryColor = System.Drawing.Color.White;
            chartArea10.BorderColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.chartSensorData.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.Color.Transparent;
            legend10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend10.ForeColor = System.Drawing.Color.DarkGray;
            legend10.IsTextAutoFit = false;
            legend10.Name = "Legend1";
            this.chartSensorData.Legends.Add(legend10);
            this.chartSensorData.Location = new System.Drawing.Point(93, 38);
            this.chartSensorData.Name = "chartSensorData";
            series37.BorderWidth = 3;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Color = System.Drawing.Color.Red;
            series37.Legend = "Legend1";
            series37.Name = "Series1";
            series38.BorderWidth = 3;
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Color = System.Drawing.Color.DeepSkyBlue;
            series38.Legend = "Legend1";
            series38.Name = "Series2";
            series39.BorderWidth = 3;
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Color = System.Drawing.Color.SeaGreen;
            series39.Legend = "Legend1";
            series39.Name = "Series3";
            series40.BorderWidth = 3;
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series40.Color = System.Drawing.Color.Goldenrod;
            series40.Legend = "Legend1";
            series40.Name = "Series4";
            this.chartSensorData.Series.Add(series37);
            this.chartSensorData.Series.Add(series38);
            this.chartSensorData.Series.Add(series39);
            this.chartSensorData.Series.Add(series40);
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
            // UC_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleTemperature;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleSoil;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleAir;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleLight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorData;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
