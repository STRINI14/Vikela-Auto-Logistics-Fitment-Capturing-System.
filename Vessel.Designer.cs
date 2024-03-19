namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    partial class Vessel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vessel));
            cboFitmentsStock = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtQuantity = new TextBox();
            txtVesselStock = new TextBox();
            label6 = new Label();
            btnVessel = new Label();
            lblFitment = new Label();
            btnSelection = new Label();
            lblUsername = new Label();
            lblCurrentUser = new Label();
            btnQuantity = new Label();
            lblSelection = new Label();
            button4 = new Button();
            btnInsert = new Button();
            btnExit = new Button();
            button1 = new Button();
            btnMainMenu = new Button();
            SuspendLayout();
            // 
            // cboFitmentsStock
            // 
            cboFitmentsStock.Anchor = AnchorStyles.None;
            cboFitmentsStock.FormattingEnabled = true;
            cboFitmentsStock.Items.AddRange(new object[] { "COASTER ALARM", "COASTER AUDIO", "COASTER 100 SIGNS", "COASTER DECALS", "COASTER DRIVER GUARD", "COASTER FIRE EXTINGUISHER", "COASTER FLAGS", "COASTER REFLECTORS", "COROLLA GR AUDIO AND REVERSE CAMERA", "COROLLA GR VIN LABEL", "GR86 ALARM", "GR86 AUDIO", "HIACE AUDIO", "HIACE TOWBAR", "LAND CRUISER ALARM", "LAND CRUISER IMMOBILIZER", "LAND CRUISER AUDIO", "LAND CRUISER TOWBAR", "LAND CRUISER BUMPER REPLACEMENT", "LAND CRUISER CATTLE RAIL", "LAND CRUISER ROLLBAR", "LC300 AUDIO AND REVERSE CAMERA", "PRADO TOWBAR", "QUANTUM AUDIO", "QUANTUM TOWBAR", "RAV4 TOWBAR", "RUMION ALARM", "VITZ ALARM", "VITZ AUDIO AND SPEAKERS", "YARIS GR AUDIO ", "YARIS GR REVERSE CAMERA AND SENSOR" });
            cboFitmentsStock.Location = new Point(252, 304);
            cboFitmentsStock.Name = "cboFitmentsStock";
            cboFitmentsStock.Size = new Size(209, 28);
            cboFitmentsStock.TabIndex = 31;
            cboFitmentsStock.SelectedIndexChanged += cboFitmentsStock_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(334, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.None;
            txtQuantity.Location = new Point(252, 515);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(209, 27);
            txtQuantity.TabIndex = 29;
            // 
            // txtVesselStock
            // 
            txtVesselStock.Anchor = AnchorStyles.None;
            txtVesselStock.Location = new Point(208, 217);
            txtVesselStock.Name = "txtVesselStock";
            txtVesselStock.Size = new Size(209, 27);
            txtVesselStock.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 132);
            label6.Name = "label6";
            label6.Size = new Size(285, 34);
            label6.TabIndex = 27;
            label6.Text = "DATE AND TIME: ";
            // 
            // btnVessel
            // 
            btnVessel.Anchor = AnchorStyles.None;
            btnVessel.AutoSize = true;
            btnVessel.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVessel.Location = new Point(36, 217);
            btnVessel.Name = "btnVessel";
            btnVessel.Size = new Size(141, 34);
            btnVessel.TabIndex = 26;
            btnVessel.Text = "VESSEL:";
            // 
            // lblFitment
            // 
            lblFitment.Anchor = AnchorStyles.None;
            lblFitment.AutoSize = true;
            lblFitment.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFitment.Location = new Point(36, 304);
            lblFitment.Name = "lblFitment";
            lblFitment.Size = new Size(177, 34);
            lblFitment.TabIndex = 25;
            lblFitment.Text = "FITMENT: ";
            // 
            // btnSelection
            // 
            btnSelection.Anchor = AnchorStyles.None;
            btnSelection.AutoSize = true;
            btnSelection.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelection.Location = new Point(36, 397);
            btnSelection.Name = "btnSelection";
            btnSelection.Size = new Size(303, 34);
            btnSelection.TabIndex = 24;
            btnSelection.Text = "YOUR SELECTION: ";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(255, 192, 192);
            lblUsername.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(334, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(33, 34);
            lblUsername.TabIndex = 23;
            lblUsername.Text = "?";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.None;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.FromArgb(255, 255, 192);
            lblCurrentUser.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentUser.Location = new Point(36, 45);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(267, 34);
            lblCurrentUser.TabIndex = 22;
            lblCurrentUser.Text = "CURRENT USER: ";
            // 
            // btnQuantity
            // 
            btnQuantity.Anchor = AnchorStyles.None;
            btnQuantity.AutoSize = true;
            btnQuantity.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuantity.Location = new Point(36, 506);
            btnQuantity.Name = "btnQuantity";
            btnQuantity.Size = new Size(195, 34);
            btnQuantity.TabIndex = 32;
            btnQuantity.Text = "QUANTITY: ";
            // 
            // lblSelection
            // 
            lblSelection.Anchor = AnchorStyles.None;
            lblSelection.AutoSize = true;
            lblSelection.BackColor = Color.FromArgb(255, 192, 192);
            lblSelection.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelection.Location = new Point(375, 397);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(33, 34);
            lblSelection.TabIndex = 33;
            lblSelection.Text = "?";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.SandyBrown;
            button4.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(516, 217);
            button4.Name = "button4";
            button4.Size = new Size(384, 69);
            button4.TabIndex = 34;
            button4.Text = "INSERT INTO DATABASE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.SandyBrown;
            btnInsert.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(719, 473);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(181, 69);
            btnInsert.TabIndex = 35;
            btnInsert.Text = "CLEAR ALL";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(757, 45);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 89);
            btnExit.TabIndex = 38;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(706, 626);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 37;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Anchor = AnchorStyles.None;
            btnMainMenu.BackColor = Color.SeaGreen;
            btnMainMenu.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.Location = new Point(32, 626);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(181, 69);
            btnMainMenu.TabIndex = 36;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // Vessel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 737);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(btnMainMenu);
            Controls.Add(btnInsert);
            Controls.Add(button4);
            Controls.Add(lblSelection);
            Controls.Add(btnQuantity);
            Controls.Add(cboFitmentsStock);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtQuantity);
            Controls.Add(txtVesselStock);
            Controls.Add(label6);
            Controls.Add(btnVessel);
            Controls.Add(lblFitment);
            Controls.Add(btnSelection);
            Controls.Add(lblUsername);
            Controls.Add(lblCurrentUser);
            Name = "Vessel";
            Text = "Vessel";
            Load += Vessel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboFitmentsStock;
        private DateTimePicker dateTimePicker1;
        private TextBox txtQuantity;
        private TextBox txtVesselStock;
        private Label label6;
        private Label btnVessel;
        private Label lblFitment;
        private Label btnSelection;
        private Label lblUsername;
        private Label lblCurrentUser;
        private Label btnQuantity;
        private Label lblSelection;
        private Button button4;
        private Button btnInsert;
        private Button btnExit;
        private Button button1;
        private Button btnMainMenu;
    }
}