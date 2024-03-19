namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    partial class ShiftTable
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
            dgvShift = new DataGridView();
            btnView = new Button();
            btnExit = new Button();
            button1 = new Button();
            btnMainMenu = new Button();
            btnDatabases = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShift).BeginInit();
            SuspendLayout();
            // 
            // dgvShift
            // 
            dgvShift.Anchor = AnchorStyles.None;
            dgvShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShift.Location = new Point(286, 52);
            dgvShift.Name = "dgvShift";
            dgvShift.RowHeadersWidth = 51;
            dgvShift.RowTemplate.Height = 29;
            dgvShift.Size = new Size(590, 627);
            dgvShift.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.None;
            btnView.BackColor = Color.Cyan;
            btnView.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.Location = new Point(12, 52);
            btnView.Name = "btnView";
            btnView.Size = new Size(242, 72);
            btnView.TabIndex = 15;
            btnView.Text = "VIEW TABLE";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(12, 535);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 89);
            btnExit.TabIndex = 42;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 407);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 41;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Anchor = AnchorStyles.None;
            btnMainMenu.BackColor = Color.SeaGreen;
            btnMainMenu.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.Location = new Point(12, 281);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(181, 69);
            btnMainMenu.TabIndex = 40;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnDatabases
            // 
            btnDatabases.Anchor = AnchorStyles.None;
            btnDatabases.BackColor = Color.SandyBrown;
            btnDatabases.Font = new Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatabases.Location = new Point(12, 170);
            btnDatabases.Name = "btnDatabases";
            btnDatabases.Size = new Size(181, 69);
            btnDatabases.TabIndex = 39;
            btnDatabases.Text = "DATABASES";
            btnDatabases.UseVisualStyleBackColor = false;
            btnDatabases.Click += btnDatabases_Click;
            // 
            // ShiftTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 713);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(btnMainMenu);
            Controls.Add(btnDatabases);
            Controls.Add(btnView);
            Controls.Add(dgvShift);
            Name = "ShiftTable";
            Text = "ShiftTable";
            Load += ShiftTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShift).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShift;
        private Button btnView;
        private Button btnExit;
        private Button button1;
        private Button btnMainMenu;
        private Button btnDatabases;
    }
}