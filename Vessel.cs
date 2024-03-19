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


    public partial class Vessel : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int count = 0;

        public Vessel()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\naick\OneDrive\Desktop\Projects\C#\Vikela\Vessel.accdb"";Persist Security Info=True;";
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cboFitmentsStock.Text = string.Empty;
            lblSelection.Text = string.Empty;
            txtQuantity.Text = string.Empty;
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

        private void Vessel_Load(object sender, EventArgs e)
        {
            lblUsername.Text = ClassUser.uname;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Stock(Dates,Vessel,Fitment,Quantity) values ('" + dateTimePicker1.Text + "','" + txtVesselStock.Text + "','" + cboFitmentsStock.Text + "','" + txtQuantity.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void cboFitmentsStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelection.Text = cboFitmentsStock.Text;
        }
    }
}
