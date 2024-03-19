using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    public partial class VesselTable : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public VesselTable()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\naick\OneDrive\Desktop\Projects\C#\Vikela\Vessel.accdb"";Persist Security Info=True;";
        }

        private void btnDatabases_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Return To The Databases Menu? All Unsaved Progress Will Be Lost.",
           "Return To The Databases Menu?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Databases fr = new Databases();
                fr.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Return To The Main Menu? All Unsaved Progress Will Be Lost.",
         "Return To The Main Menu?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmMainMenu mm = new frmMainMenu();
                mm.Show();
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

        private void VesselTable_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Stock";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVessel.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void dgvVessel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
