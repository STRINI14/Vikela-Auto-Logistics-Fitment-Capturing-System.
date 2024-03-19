namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    partial class Shift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shift));
            lblCurrentUser = new Label();
            lblUsername = new Label();
            btnFitters = new Label();
            btnSerialVinNumber = new Label();
            btnJobNumber = new Label();
            btnFitment = new Label();
            btnVessel = new Label();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnMainMenu = new Button();
            button1 = new Button();
            btnExit = new Button();
            btnInsert = new Button();
            button3 = new Button();
            button4 = new Button();
            txtVessel = new TextBox();
            txtJobNumber = new TextBox();
            txtSerialVinNumber = new TextBox();
            txtFitters = new TextBox();
            cboFitments = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.None;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.FromArgb(255, 255, 192);
            lblCurrentUser.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentUser.Location = new Point(54, 34);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(267, 34);
            lblCurrentUser.TabIndex = 0;
            lblCurrentUser.Text = "CURRENT USER: ";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(255, 192, 192);
            lblUsername.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(352, 34);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(33, 34);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "?";
            // 
            // btnFitters
            // 
            btnFitters.Anchor = AnchorStyles.None;
            btnFitters.AutoSize = true;
            btnFitters.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnFitters.Location = new Point(54, 571);
            btnFitters.Name = "btnFitters";
            btnFitters.Size = new Size(177, 34);
            btnFitters.TabIndex = 2;
            btnFitters.Text = "FITTERS: ";
            // 
            // btnSerialVinNumber
            // 
            btnSerialVinNumber.Anchor = AnchorStyles.None;
            btnSerialVinNumber.AutoSize = true;
            btnSerialVinNumber.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerialVinNumber.Location = new Point(54, 471);
            btnSerialVinNumber.Name = "btnSerialVinNumber";
            btnSerialVinNumber.Size = new Size(357, 34);
            btnSerialVinNumber.TabIndex = 3;
            btnSerialVinNumber.Text = "SERIAL/VIN NUMBER: ";
            // 
            // btnJobNumber
            // 
            btnJobNumber.Anchor = AnchorStyles.None;
            btnJobNumber.AutoSize = true;
            btnJobNumber.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnJobNumber.Location = new Point(54, 386);
            btnJobNumber.Name = "btnJobNumber";
            btnJobNumber.Size = new Size(231, 34);
            btnJobNumber.TabIndex = 4;
            btnJobNumber.Text = "JOB NUMBER: ";
            // 
            // btnFitment
            // 
            btnFitment.Anchor = AnchorStyles.None;
            btnFitment.AutoSize = true;
            btnFitment.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnFitment.Location = new Point(54, 293);
            btnFitment.Name = "btnFitment";
            btnFitment.Size = new Size(177, 34);
            btnFitment.TabIndex = 5;
            btnFitment.Text = "FITMENT: ";
            // 
            // btnVessel
            // 
            btnVessel.Anchor = AnchorStyles.None;
            btnVessel.AutoSize = true;
            btnVessel.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVessel.Location = new Point(54, 206);
            btnVessel.Name = "btnVessel";
            btnVessel.Size = new Size(141, 34);
            btnVessel.TabIndex = 6;
            btnVessel.Text = "VESSEL:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(54, 121);
            label6.Name = "label6";
            label6.Size = new Size(285, 34);
            label6.TabIndex = 7;
            label6.Text = "DATE AND TIME: ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Anchor = AnchorStyles.None;
            btnMainMenu.BackColor = Color.SeaGreen;
            btnMainMenu.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.Location = new Point(381, 615);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(181, 69);
            btnMainMenu.TabIndex = 9;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(700, 615);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 10;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(729, 34);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 89);
            btnExit.TabIndex = 11;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.SandyBrown;
            btnInsert.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(700, 455);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(181, 69);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "CLEAR ALL";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.SandyBrown;
            button3.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(497, 318);
            button3.Name = "button3";
            button3.Size = new Size(384, 69);
            button3.TabIndex = 13;
            button3.Text = "REMOVE FROM DATABASE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.SandyBrown;
            button4.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(497, 190);
            button4.Name = "button4";
            button4.Size = new Size(384, 69);
            button4.TabIndex = 14;
            button4.Text = "INSERT INTO DATABASE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtVessel
            // 
            txtVessel.Anchor = AnchorStyles.None;
            txtVessel.BackColor = SystemColors.InactiveCaption;
            txtVessel.Location = new Point(226, 206);
            txtVessel.Name = "txtVessel";
            txtVessel.Size = new Size(209, 27);
            txtVessel.TabIndex = 15;
            // 
            // txtJobNumber
            // 
            txtJobNumber.Anchor = AnchorStyles.None;
            txtJobNumber.BackColor = SystemColors.InactiveCaption;
            txtJobNumber.Location = new Point(330, 393);
            txtJobNumber.Name = "txtJobNumber";
            txtJobNumber.Size = new Size(209, 27);
            txtJobNumber.TabIndex = 16;
            // 
            // txtSerialVinNumber
            // 
            txtSerialVinNumber.Anchor = AnchorStyles.None;
            txtSerialVinNumber.BackColor = SystemColors.InactiveCaption;
            txtSerialVinNumber.Location = new Point(447, 471);
            txtSerialVinNumber.Name = "txtSerialVinNumber";
            txtSerialVinNumber.Size = new Size(209, 27);
            txtSerialVinNumber.TabIndex = 17;
            // 
            // txtFitters
            // 
            txtFitters.Anchor = AnchorStyles.None;
            txtFitters.BackColor = SystemColors.InactiveCaption;
            txtFitters.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFitters.Location = new Point(270, 571);
            txtFitters.Name = "txtFitters";
            txtFitters.Size = new Size(209, 27);
            txtFitters.TabIndex = 18;
            // 
            // cboFitments
            // 
            cboFitments.Anchor = AnchorStyles.None;
            cboFitments.BackColor = SystemColors.InactiveCaption;
            cboFitments.FormattingEnabled = true;
            cboFitments.Items.AddRange(new object[] { "COASTER ALARM", "COASTER AUDIO", "COASTER 100 SIGNS", "COASTER DECALS", "COASTER DRIVER GUARD", "COASTER FIRE EXTINGUISHER", "COASTER FLAGS", "COASTER REFLECTORS", "COROLLA GR AUDIO AND REVERSE CAMERA", "COROLLA GR VIN LABEL", "GR86 ALARM", "GR86 AUDIO", "HIACE AUDIO", "HIACE TOWBAR", "LAND CRUISER ALARM", "LAND CRUISER IMMOBILIZER", "LAND CRUISER AUDIO", "LAND CRUISER TOWBAR", "LAND CRUISER BUMPER REPLACEMENT", "LAND CRUISER CATTLE RAIL", "LAND CRUISER ROLLBAR", "LC300 AUDIO AND REVERSE CAMERA", "PRADO TOWBAR", "QUANTUM AUDIO", "QUANTUM TOWBAR", "RAV4 TOWBAR", "RUMION ALARM", "VITZ ALARM", "VITZ AUDIO AND SPEAKERS", "YARIS GR AUDIO ", "YARIS GR REVERSE CAMERA AND SENSOR" });
            cboFitments.Location = new Point(270, 293);
            cboFitments.Name = "cboFitments";
            cboFitments.Size = new Size(209, 28);
            cboFitments.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(352, 121);
            label1.Name = "label1";
            label1.Size = new Size(123, 34);
            label1.TabIndex = 22;
            label1.Text = "label1";
            // 
            // Shift
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(906, 715);
            Controls.Add(label1);
            Controls.Add(cboFitments);
            Controls.Add(txtFitters);
            Controls.Add(txtSerialVinNumber);
            Controls.Add(txtJobNumber);
            Controls.Add(txtVessel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnInsert);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(btnMainMenu);
            Controls.Add(label6);
            Controls.Add(btnVessel);
            Controls.Add(btnFitment);
            Controls.Add(btnJobNumber);
            Controls.Add(btnSerialVinNumber);
            Controls.Add(btnFitters);
            Controls.Add(lblUsername);
            Controls.Add(lblCurrentUser);
            Name = "Shift";
            Text = "Shift";
            Load += Shift_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentUser;
        private Label lblUsername;
        private Label btnFitters;
        private Label btnSerialVinNumber;
        private Label btnJobNumber;
        private Label btnFitment;
        private Label btnVessel;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private Button btnMainMenu;
        private Button button1;
        private Button btnExit;
        private Button btnInsert;
        private Button button3;
        private Button button4;
        private TextBox txtVessel;
        private TextBox txtJobNumber;
        private TextBox txtSerialVinNumber;
        private TextBox txtFitters;
        private ComboBox cboFitments;
        private Label label1;
    }
}