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
    public partial class Databases : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int count = 0;
        public Databases()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\naick\OneDrive\Desktop\Projects\C#\Vikela\Shift.accdb"";Persist Security Info=True;";
        }

        private void btnShiftTable_Click(object sender, EventArgs e)
        {

            ShiftTable ssm = new ShiftTable();
            ssm.Show();
            this.Hide();
        }

        private void btnVesseltable_Click(object sender, EventArgs e)
        {

            VesselTable ssm = new VesselTable();
            ssm.Show();
            this.Hide();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            dgvSearchCar.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            count = 0;
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Score where JobNumber='" + txtSearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dgvSearchCar.DataSource = dt;

            connection.Close();

            if (count == 0)
            {
                MessageBox.Show("Job Number Was Not Found.", "Error.");
            }
        }

        private void Databases_Load(object sender, EventArgs e)
        {

            lblUsername.Text = ClassUser.uname;

        }
    }
}
