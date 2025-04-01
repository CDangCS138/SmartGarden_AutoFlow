using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartGarden_AutoFlow.Forms
{
    public partial class frmEditGarden : Form
    {
        public string PlantType { get; set; }
        public DateTime PlantingDate { get; set; }
        public DateTime HarvestDate { get; set; }
        public string Status { get; set; }
        public List<string> SelectedSensors { get; set; } = new List<string>();
        public frmEditGarden()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEditGarden_Load(object sender, EventArgs e)
        {
            txtPlantType.Text = PlantType;
            dtpPlantingDate.Value = PlantingDate;
            dtpHarvestDat.Value = HarvestDate;
            if (!string.IsNullOrEmpty(Status))
                cboStatus.SelectedItem = Status;

            for (int i = 0; i < checkedListSensor.Items.Count; i++)
            {
                if (SelectedSensors.Contains(checkedListSensor.Items[i].ToString()))
                {
                    checkedListSensor.SetItemChecked(i, true);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlantType.Text) || cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlantType = txtPlantType.Text;
            PlantingDate = dtpPlantingDate.Value;
            HarvestDate = dtpHarvestDat.Value;
            Status = cboStatus.SelectedItem.ToString();

            SelectedSensors.Clear();
            foreach (object item in checkedListSensor.CheckedItems)
            {
                SelectedSensors.Add(item.ToString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
