using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_Control : UserControl
    {
        public UC_Control()
        {
            InitializeComponent();
        
        }

        private void chartSensorData_Click(object sender, EventArgs e)
        {

        }

        private void AddSeries(string name, double currentValue, int min, int max)
        {
            Random rand = new Random();
            Series series = new Series(name)
            {
                ChartType = SeriesChartType.Line
            };

            for (int j = 0; j < 10; j++)
                series.Points.AddXY(DateTime.Today.AddDays(-9 + j).ToShortDateString(), rand.Next(min, max));

            series.Points.AddXY(DateTime.Today.ToShortDateString(), currentValue);
            chartSensorData.Series.Add(series);
        }
        private void LoadSampleData()
        {
            Random rand = new Random();
            chartSensorData.Series.Clear();

            int tempValue = rand.Next(15, 36);
            int airHumidityValue = rand.Next(40, 81);
            int soilHumidityValue = rand.Next(10, 61);
            int lightIntensityValue = rand.Next(1, 120);

            AddSeries("Nhiệt độ (°C)", tempValue, 15, 36);
            AddSeries("Độ ẩm không khí (%)", airHumidityValue, 40, 81);
            AddSeries("Độ ẩm đất (%)", soilHumidityValue, 10, 61);
            AddSeries("Cường độ ánh sáng (kLux)", lightIntensityValue, 0, 100);

            circleTemperature.Value = tempValue;
            circleTemperature.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            circleTemperature.Text = $"Nhiệt độ hôm nay: {tempValue}°C";

            circleAir.Value = airHumidityValue;
            circleAir.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            circleAir.Text = $"Độ ẩm không khí: {airHumidityValue}%";

            circleSoil.Value = soilHumidityValue;
            circleSoil.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            circleSoil.Text = $"Độ ẩm đất: {soilHumidityValue}%";

            circleLight.Value = lightIntensityValue;
            circleLight.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            circleLight.Text = $"Cường độ ánh sáng: {lightIntensityValue} kLux";

        }

        private void UC_Control_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        private void circleTemperature_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circleSoil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circleLight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circleAir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
