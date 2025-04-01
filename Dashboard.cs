using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden_AutoFlow
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Control1.Visible=false;
            uC_History1.Visible=false;
            uC_Garden1.Visible = false;
            uC_Devices1.Visible=false;
            btnControl.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelMoving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnControl.Left + 57;
            uC_Control1.Visible = true;
            uC_Control1.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnHistory.Left + 60;
            uC_History1.Visible = true;
            uC_History1.BringToFront();
        }

        private void btnGarden_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnHistory.Left + 380;
            uC_Garden1.Visible = true;
            uC_Garden1.BringToFront();
        }

        
        private void btnUser_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnHistory.Left + 1040;
            uC_User1.Visible = true;
            uC_User1.BringToFront();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnControl.Left + 1022;
            uC_Devices1.Visible = true;
            uC_Devices1.BringToFront();
        }
    }
}
