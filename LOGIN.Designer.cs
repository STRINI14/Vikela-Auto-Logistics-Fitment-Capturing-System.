namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pbLoginDetails = new PictureBox();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            cbShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbLoginDetails).BeginInit();
            SuspendLayout();
            // 
            // pbLoginDetails
            // 
            pbLoginDetails.Anchor = AnchorStyles.None;
            pbLoginDetails.BackColor = Color.SkyBlue;
            pbLoginDetails.Location = new Point(208, 248);
            pbLoginDetails.Name = "pbLoginDetails";
            pbLoginDetails.Size = new Size(649, 173);
            pbLoginDetails.TabIndex = 0;
            pbLoginDetails.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(242, 271);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(138, 26);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "USERNAME:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(242, 334);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(138, 26);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "PASSWORD:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(392, 271);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(392, 334);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(192, 255, 192);
            btnLogin.Font = new Font("Lucida Sans Typewriter", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(655, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 90);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(705, 24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 89);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.None;
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.FromArgb(255, 255, 128);
            lblDateTime.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateTime.Location = new Point(37, 24);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(137, 39);
            lblDateTime.TabIndex = 7;
            lblDateTime.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // cbShowPassword
            // 
            cbShowPassword.Anchor = AnchorStyles.None;
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(392, 377);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(132, 24);
            cbShowPassword.TabIndex = 8;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 720);
            Controls.Add(cbShowPassword);
            Controls.Add(lblDateTime);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(pbLoginDetails);
            Name = "frmLogin";
            Text = "LOGIN";
            Load += LOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)pbLoginDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLoginDetails;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private CheckBox cbShowPassword;
    }
}