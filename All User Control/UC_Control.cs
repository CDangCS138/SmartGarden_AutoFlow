using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_Control : UserControl
    {
        private Timer refreshTimer;
        private readonly HttpClient _client = new HttpClient();
        private const string BLYNK_TOKEN = "yj2Ygd32qCZ_5q-SY37VmJ1fxHdEoDDa";
        //private const string BLYNK_TOKEN = "yj2Ygd32qCZ_5q-7VmJ1fxHdEoDDa";
        private const string BASE_GET = "https://blynk.cloud/external/api/get";
        private const string BASE_UPDATE = "https://blynk.cloud/external/api/update";
        private bool isAdjustingPump = false;

        private Timer debounceTimer;
        private const int DebounceInterval = 500; // 500 ms, điều chỉnh tuỳ ý


        public UC_Control()
        {
            InitializeComponent();
            this.Load += UC_Control_Load;

            numWaterHour.ValueChanged += async (s, e) => await SafeCall(() => UpdatePinAsync("V5", (int)numWaterHour.Value));
            numWaterPeriod.ValueChanged += async (s, e) => await SafeCall(() => UpdatePinAsync("V6", (int)numWaterPeriod.Value));
            autoPump.CheckedChanged += async (s, e) => await SafeCall(() => UpdatePinAsync("V7", autoPump.Checked ? 1 : 0));
            trackBarPumpIntensity.Scroll += trackBarPumpIntensity_Scroll;

            debounceTimer = new Timer();
            debounceTimer.Interval = DebounceInterval;
            debounceTimer.Tick += DebounceTimer_Tick;

        }
        private async void UC_Control_Load(object sender, EventArgs e)
        {
            await FetchAndDisplayAllAsync();
            refreshTimer = new Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += async (s, ev) => await FetchAndDisplayAllAsync();
            refreshTimer.Start();
        }
        private async Task FetchAndDisplayAllAsync()
        {
            try
            {
                double humidity = await GetPinValueAsync("V1");
                double temperature = await GetPinValueAsync("V2");
                double soilHumidity = await GetPinValueAsync("V4");
                int pumpIntensity = (int)await GetPinValueAsync("V3");
                int waterHour = (int)await GetPinValueAsync("V5");
                int waterPeriod = (int)await GetPinValueAsync("V6");
                int modeAuto = (int)await GetPinValueAsync("V7");

                if (!isAdjustingPump && trackBarPumpIntensity.Value != pumpIntensity)
                {
                    trackBarPumpIntensity.Scroll -= trackBarPumpIntensity_Scroll;
                    trackBarPumpIntensity.Value = pumpIntensity;
                    trackBarPumpIntensity.Scroll += trackBarPumpIntensity_Scroll;
                }

                PopulateChart(temperature, humidity, soilHumidity);

                SetCircle(circleTemperature, temperature, "Nhiệt độ hôm nay", "°C");
                SetCircle(circleAir, humidity, "Độ ẩm không khí", "%");
                SetCircle(circleSoil, soilHumidity, "Độ ẩm đất", "%");

                numWaterHour.Value = Clamp(waterHour, (int)numWaterHour.Minimum, (int)numWaterHour.Maximum);
                numWaterPeriod.Value = Clamp(waterPeriod, (int)numWaterPeriod.Minimum, (int)numWaterPeriod.Maximum);
                autoPump.Checked = modeAuto == 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Không lấy được dữ liệu Blynk:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<double> GetPinValueAsync(string pin)
        {
            var url = $"{BASE_GET}?token={BLYNK_TOKEN}&{pin}";
            var s = await _client.GetStringAsync(url);
            if (double.TryParse(s, out var v))
                return v;
            throw new Exception($"Không parse được giá trị từ pin {pin}: '{s}'");
        }

        private async Task UpdatePinAsync(string pin, object value)
        {
            var url = $"{BASE_UPDATE}?token={BLYNK_TOKEN}&{pin}={value}";
            var resp = await _client.GetAsync(url);
            resp.EnsureSuccessStatusCode();
        }

        private void SetCircle(Guna.UI2.WinForms.Guna2CircleProgressBar circle, double value, string label, string unit)
        {
            int iv = (int)Math.Round(value);
            circle.Value = Clamp(iv, circle.Minimum, circle.Maximum);
            circle.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            circle.Text = $"{label}: {iv}{unit}";
        }

        private int Clamp(int v, int min, int max)
            => v < min ? min : v > max ? max : v;

        private void AddOrUpdateSeries(string name, double value)
        {
            Series series;
            if (!chartSensorData.Series.IsUniqueName(name))
            {
                series = chartSensorData.Series[name];
            }
            else
            {
                series = new Series(name) { ChartType = SeriesChartType.Line };
                chartSensorData.Series.Add(series);
            }

            series.Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), value);
            if (series.Points.Count > 30)
                series.Points.RemoveAt(0);
        }
        private void PopulateChart(double temp, double airHum, double soilHum)
        {
            chartSensorData.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            AddOrUpdateSeries("Nhiệt độ (°C)", temp);
            AddOrUpdateSeries("Độ ẩm không khí (%)", airHum);
            AddOrUpdateSeries("Độ ẩm đất (%)", soilHum);
        }

        private void AddSeries(string name, double currentValue)
        {
            var series = new Series(name)
            {
                ChartType = SeriesChartType.Line
            };
            series.Points.AddXY(DateTime.Now.ToString("HH:mm"), currentValue);
            chartSensorData.Series.Add(series);
        }

        private void circleTemperature_ValueChanged(object sender, EventArgs e) { }

        private void circleSoil_ValueChanged(object sender, EventArgs e) { }

        private void circleAir_ValueChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }



        private async Task SafeCall(Func<Task> fn)
        {
            try
            {
                await fn();
            }
            catch (Exception ex)
            {
             //   MessageBox.Show($"Lỗi khi gọi API:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void trackBarPumpIntensity_Scroll(object sender, ScrollEventArgs e)
        {
            //isAdjustingPump = true;
            //int intensity = trackBarPumpIntensity.Value;
            // label7.Text = $"{intensity}";
            //await SafeCall(() => UpdatePinAsync("V3", intensity));
            // isAdjustingPump = false;
            if (autoPump.Checked == false)
            {
                trackBarPumpIntensity.Value = 0;

                label7.Text = "0";
                return;
            }
            int intensity = trackBarPumpIntensity.Value;
            label7.Text = $"{intensity}";

            // Mỗi lần kéo reset timer
            debounceTimer.Stop();
            debounceTimer.Start();
        }
        private async void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();

            int intensity = trackBarPumpIntensity.Value;

            isAdjustingPump = true;
            await SafeCall(() => UpdatePinAsync("V3", intensity));
            isAdjustingPump = false;
        }

    }
}
