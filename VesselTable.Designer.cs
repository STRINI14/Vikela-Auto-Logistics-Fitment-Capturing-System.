namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    partial class VesselTable
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
            btnExit = new Button();
            button1 = new Button();
            btnMainMenu = new Button();
            btnDatabases = new Button();
            btnView = new Button();
            dgvVessel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVessel).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(19, 532);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 89);
            btnExit.TabIndex = 48;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(19, 404);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 47;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Anchor = AnchorStyles.None;
            btnMainMenu.BackColor = Color.SeaGreen;
            btnMainMenu.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.Location = new Point(19, 278);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(181, 69);
            btnMainMenu.TabIndex = 46;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnDatabases
            // 
            btnDatabases.Anchor = AnchorStyles.None;
            btnDatabases.BackColor = Color.SandyBrown;
            btnDatabases.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatabases.Location = new Point(19, 167);
            btnDatabases.Name = "btnDatabases";
            btnDatabases.Size = new Size(181, 69);
            btnDatabases.TabIndex = 45;
            btnDatabases.Text = "DATABASES";
            btnDatabases.UseVisualStyleBackColor = false;
            btnDatabases.Click += btnDatabases_Click;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.None;
            btnView.BackColor = Color.Cyan;
            btnView.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.Location = new Point(19, 49);
            btnView.Name = "btnView";
            btnView.Size = new Size(242, 72);
            btnView.TabIndex = 44;
            btnView.Text = "VIEW TABLE";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dgvVessel
            // 
            dgvVessel.Anchor = AnchorStyles.None;
            dgvVessel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVessel.Location = new Point(293, 49);
            dgvVessel.Name = "dgvVessel";
            dgvVessel.RowHeadersWidth = 51;
            dgvVessel.RowTemplate.Height = 29;
            dgvVessel.Size = new Size(590, 627);
            dgvVessel.TabIndex = 43;
            dgvVessel.CellContentClick += dgvVessel_CellContentClick;
            // 
            // VesselTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 724);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(btnMainMenu);
            Controls.Add(btnDatabases);
            Controls.Add(btnView);
            Controls.Add(dgvVessel);
            Name = "VesselTable";
            Text = "VesselTable";
            Load += VesselTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVessel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button button1;
        private Button btnMainMenu;
        private Button btnDatabases;
        private Button btnView;
        private DataGridView dgvVessel;
    }
}