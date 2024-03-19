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
    public partial class Shift : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        int count = 0;

        public Shift()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\naick\OneDrive\Desktop\Projects\C#\Vikela\Shift.accdb"";Persist Security Info=True;";
        }

        private void Shift_Load(object sender, EventArgs e)
        {

            lblUsername.Text = ClassUser.uname;
            timer1.Start();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Exit The Vikela Auto Heavy PPO Fitment Capturing System?",
             "Exit The Vikela Auto Fitment Capturing System?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Score(Dates,Vessel,Fitment,JobNumber,SerialVinNumber,Fitters) values ('" + label1.Text + "','" + txtVessel.Text + "','" + cboFitments.Text + "','" + txtJobNumber.Text + "','" + txtSerialVinNumber.Text + "','" + txtFitters.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from VesselJobNumbers where JobNumbers = '" + txtJobNumber.Text + "'";
            int rc = cmd.ExecuteNonQuery();
            if (rc > 0)
            {
                MessageBox.Show("Job Number Has Been Deleted Successfully.", "Operation Successful.");
            }
            else
            {
                MessageBox.Show("Job Number Does Not Exist!", "Incorrect Job Number.");
            }
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            cboFitments.Text = String.Empty;
            txtJobNumber.Text = String.Empty;
            txtSerialVinNumber.Text = String.Empty;
            txtFitters.Text = String.Empty;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToString();
        }
    }
}
