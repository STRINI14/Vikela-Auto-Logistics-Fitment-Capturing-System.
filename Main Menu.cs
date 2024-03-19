using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Logout Of The Vikela Auto Heavy PPO Fitment Capturing System? All Unsaved Progress Will Be Lost.",
            "Logout Of The Vikela Auto Heavy PPO Fitment Capturing System?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin fr = new frmLogin();
                fr.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Exit The Vikela Auto Heavy PPO Fitment Capturing System?",
              "Exit The Vikela Auto Fitment Capturing System?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            Shift ssm = new Shift();
            ssm.Show();
            this.Hide();

        }

        private void btnVessel_Click(object sender, EventArgs e)
        {
            Vessel ssm = new Vessel();
            ssm.Show();
            this.Hide();
        }

        private void btnDatabases_Click(object sender, EventArgs e)
        {
            Databases ssm = new Databases();
            ssm.Show();
            this.Hide();
        }
    }
}
