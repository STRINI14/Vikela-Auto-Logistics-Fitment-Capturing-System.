namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            btnShift = new Button();
            btnVessel = new Button();
            btnDatabases = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnShift
            // 
            btnShift.Anchor = AnchorStyles.None;
            btnShift.BackColor = SystemColors.ActiveCaption;
            btnShift.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnShift.Location = new Point(48, 109);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(181, 137);
            btnShift.TabIndex = 0;
            btnShift.Text = "SHIFT STOCK";
            btnShift.UseVisualStyleBackColor = false;
            btnShift.Click += btnShift_Click;
            // 
            // btnVessel
            // 
            btnVessel.Anchor = AnchorStyles.None;
            btnVessel.BackColor = Color.FromArgb(255, 128, 0);
            btnVessel.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnVessel.Location = new Point(362, 109);
            btnVessel.Name = "btnVessel";
            btnVessel.Size = new Size(181, 137);
            btnVessel.TabIndex = 1;
            btnVessel.Text = "VESSEL STOCK";
            btnVessel.UseVisualStyleBackColor = false;
            btnVessel.Click += btnVessel_Click;
            // 
            // btnDatabases
            // 
            btnDatabases.Anchor = AnchorStyles.None;
            btnDatabases.BackColor = Color.Green;
            btnDatabases.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatabases.Location = new Point(668, 109);
            btnDatabases.Name = "btnDatabases";
            btnDatabases.Size = new Size(214, 137);
            btnDatabases.TabIndex = 2;
            btnDatabases.Text = "DATABASES";
            btnDatabases.UseVisualStyleBackColor = false;
            btnDatabases.Click += btnDatabases_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.BackColor = Color.Gray;
            btnLogout.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(48, 597);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 89);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(730, 597);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 89);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 714);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnDatabases);
            Controls.Add(btnVessel);
            Controls.Add(btnShift);
            Name = "frmMainMenu";
            Text = "Main_Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShift;
        private Button btnVessel;
        private Button btnDatabases;
        private Button btnLogout;
        private Button btnExit;
    }
}