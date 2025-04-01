using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow.Forms
{
    public partial class frmAddGarden : Form
    {
        public string PlantType { get; private set; }
        public DateTime PlantingDate { get; private set; }
        public DateTime HarvestDate { get; private set; }
        public string Status { get; private set; }
        public List<string> SelectedSensors { get; private set; } = new List<string>();
        public frmAddGarden()
        {
            InitializeComponent();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlantType_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddGarden_Load(object sender, EventArgs e)
        {

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
            Status = cboStatus.SelectedItem?.ToString();

            foreach (object item in checkedListSensor.CheckedItems)
            {
                SelectedSensors.Add(item.ToString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
