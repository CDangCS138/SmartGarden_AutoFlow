using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.All_User_Control
{
    public partial class UC_GardenCard : UserControl
    {
        public string CurrentPlantType { get; private set; }
        public DateTime CurrentPlantingDate { get; private set; }
        public DateTime CurrentHarvestDate { get; private set; }
        public string CurrentStatus { get; private set; }
        public List<string> CurrentSensors { get; private set; } = new List<string>();
        public UC_GardenCard()
        {
            InitializeComponent();
        }

        private void UC_GardenCard_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string plantType, DateTime plantingDate, DateTime harvestDate, string status, List<string> sensors)
        {
            CurrentPlantType = plantType;
            CurrentPlantingDate = plantingDate;
            CurrentHarvestDate = harvestDate;
            CurrentStatus = status;
            CurrentSensors = new List<string>(sensors);

            lblPlantType.Text = "Loại cây: " + plantType;
            lblPlantingDate.Text = "Ngày gieo trồng: " + plantingDate.ToShortDateString();
            lblHarvestDate.Text = "Ngày thu hoạch: " + harvestDate.ToShortDateString();
            lblStatus.Text = "Tình trạng: " + status;

            flowLayoutSensor.Controls.Clear();
            foreach (var sensor in sensors)
            {
                Button tagSensor = new Button();
                tagSensor.Text = sensor;
                tagSensor.AutoSize = true;
                flowLayoutSensor.Controls.Add(tagSensor);
            }
        }

        private void btnRemoveGarden_Click(object sender, EventArgs e)
        {

        }

        private void btnEditGarden_Click(object sender, EventArgs e)
        {

        }
    }
}
