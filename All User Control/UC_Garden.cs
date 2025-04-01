using SmartGarden_AutoFlow.Forms;
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
    public partial class UC_Garden : UserControl
    {
        public UC_Garden()
        {
            InitializeComponent();
        }

        private void btnAddGarden_Click(object sender, EventArgs e)
        {
            frmAddGarden formAdd = new frmAddGarden();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                UC_GardenCard card = new UC_GardenCard();
                card.SetData(
                    formAdd.PlantType,
                    formAdd.PlantingDate,
                    formAdd.HarvestDate,
                    formAdd.Status,
                    formAdd.SelectedSensors
                );

                card.btnRemoveGarden.Click += (s, args) =>
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa garden này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        flowLayoutGarden.Controls.Remove(card);
                    }
                };
                card.btnEditGarden.Click += (s, args) =>
                {
                    frmEditGarden editForm = new frmEditGarden();
                    editForm.PlantType = card.CurrentPlantType;
                    editForm.PlantingDate = card.CurrentPlantingDate;
                    editForm.HarvestDate = card.CurrentHarvestDate;
                    editForm.Status = card.CurrentStatus;
                    editForm.SelectedSensors = new List<string>(card.CurrentSensors);

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        card.SetData(
                            editForm.PlantType,
                            editForm.PlantingDate,
                            editForm.HarvestDate,
                            editForm.Status,
                            editForm.SelectedSensors
                        );
                    }
                };
                flowLayoutGarden.Controls.Add(card);
            }
        }

        private void UC_Garden_Load(object sender, EventArgs e)
        {

        }

        private void uC_GardenCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
