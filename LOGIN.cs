namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblDateTime.Text = datetime.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if ((username == "STRINI" && password == "140290"))
            {
                ClassUser.uname = txtUsername.Text;
                MessageBox.Show("Welcome " + txtUsername.Text + "", "Access Granted!");
                this.Hide();
                frmMainMenu fr = new frmMainMenu();
                fr.Show();

            }
            else MessageBox.Show("Incorrect Details Have Been Entered.", "Access Denied!!!");
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
                txtPassword.UseSystemPasswordChar = true;
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
    }
}