namespace AttendanceSystem
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.grid_Employees = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.cmb_VerticalManager = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_ProjectManager = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_TeamLead = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TeamLead = new System.Windows.Forms.Button();
            this.btn_VerticalManager = new System.Windows.Forms.Button();
            this.btn_ProjectManager = new System.Windows.Forms.Button();
            this.lbl_SenderPassword = new System.Windows.Forms.Label();
            this.lbl_SenderEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1068, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Date";
            // 
            // dt_Date
            // 
            this.dt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_Date.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Date.Location = new System.Drawing.Point(1072, 42);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(200, 27);
            this.dt_Date.TabIndex = 52;
            this.dt_Date.ValueChanged += new System.EventHandler(this.dt_Date_ValueChanged);
            // 
            // grid_Employees
            // 
            this.grid_Employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Employees.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Employees.Location = new System.Drawing.Point(20, 91);
            this.grid_Employees.Name = "grid_Employees";
            this.grid_Employees.Size = new System.Drawing.Size(1252, 521);
            this.grid_Employees.TabIndex = 50;
            this.grid_Employees.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Patua One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 45);
            this.label4.TabIndex = 51;
            this.label4.Text = "Daily Attendance";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Email.Location = new System.Drawing.Point(476, 624);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(93, 20);
            this.lbl_Email.TabIndex = 69;
            this.lbl_Email.Text = "Team Lead";
            this.lbl_Email.Visible = false;
            // 
            // cmb_VerticalManager
            // 
            this.cmb_VerticalManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_VerticalManager.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_VerticalManager.FormattingEnabled = true;
            this.cmb_VerticalManager.Items.AddRange(new object[] {
            "Level 0 : Trainee Engineer",
            "Level 1 : Associate Engineer",
            "Level 2 : Senior Engineer",
            "Level 3 : Team Lead",
            "Level 4 : Team Manager",
            "Level 5 : Vertical Manager",
            "Level 6 : Human Resource Manager",
            "Level 7 : Management",
            "Others"});
            this.cmb_VerticalManager.Location = new System.Drawing.Point(170, 701);
            this.cmb_VerticalManager.Name = "cmb_VerticalManager";
            this.cmb_VerticalManager.Size = new System.Drawing.Size(269, 28);
            this.cmb_VerticalManager.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(27, 705);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Vertical Manager";
            // 
            // cmb_ProjectManager
            // 
            this.cmb_ProjectManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_ProjectManager.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProjectManager.FormattingEnabled = true;
            this.cmb_ProjectManager.Items.AddRange(new object[] {
            "Level 0 : Trainee Engineer",
            "Level 1 : Associate Engineer",
            "Level 2 : Senior Engineer",
            "Level 3 : Team Lead",
            "Level 4 : Team Manager",
            "Level 5 : Vertical Manager",
            "Level 6 : Human Resource Manager",
            "Level 7 : Management",
            "Others"});
            this.cmb_ProjectManager.Location = new System.Drawing.Point(170, 665);
            this.cmb_ProjectManager.Name = "cmb_ProjectManager";
            this.cmb_ProjectManager.Size = new System.Drawing.Size(269, 28);
            this.cmb_ProjectManager.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(27, 669);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Project Manager";
            // 
            // cmb_TeamLead
            // 
            this.cmb_TeamLead.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_TeamLead.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TeamLead.FormattingEnabled = true;
            this.cmb_TeamLead.Items.AddRange(new object[] {
            "Level 0 : Trainee Engineer",
            "Level 1 : Associate Engineer",
            "Level 2 : Senior Engineer",
            "Level 3 : Team Lead",
            "Level 4 : Team Manager",
            "Level 5 : Vertical Manager",
            "Level 6 : Human Resource Manager",
            "Level 7 : Management",
            "Others"});
            this.cmb_TeamLead.Location = new System.Drawing.Point(170, 629);
            this.cmb_TeamLead.Name = "cmb_TeamLead";
            this.cmb_TeamLead.Size = new System.Drawing.Size(269, 28);
            this.cmb_TeamLead.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(27, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Team Lead";
            // 
            // btn_TeamLead
            // 
            this.btn_TeamLead.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TeamLead.BackColor = System.Drawing.Color.Purple;
            this.btn_TeamLead.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_TeamLead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TeamLead.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TeamLead.ForeColor = System.Drawing.Color.White;
            this.btn_TeamLead.Location = new System.Drawing.Point(506, 646);
            this.btn_TeamLead.Name = "btn_TeamLead";
            this.btn_TeamLead.Size = new System.Drawing.Size(116, 63);
            this.btn_TeamLead.TabIndex = 61;
            this.btn_TeamLead.Text = "Team Lead";
            this.btn_TeamLead.UseVisualStyleBackColor = false;
            this.btn_TeamLead.Click += new System.EventHandler(this.btn_TeamLead_Click);
            // 
            // btn_VerticalManager
            // 
            this.btn_VerticalManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_VerticalManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_VerticalManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_VerticalManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerticalManager.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerticalManager.ForeColor = System.Drawing.Color.White;
            this.btn_VerticalManager.Location = new System.Drawing.Point(750, 646);
            this.btn_VerticalManager.Name = "btn_VerticalManager";
            this.btn_VerticalManager.Size = new System.Drawing.Size(116, 63);
            this.btn_VerticalManager.TabIndex = 62;
            this.btn_VerticalManager.Text = "Vertical Manager";
            this.btn_VerticalManager.UseVisualStyleBackColor = false;
            this.btn_VerticalManager.Click += new System.EventHandler(this.btn_VerticalManager_Click);
            // 
            // btn_ProjectManager
            // 
            this.btn_ProjectManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ProjectManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ProjectManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ProjectManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProjectManager.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProjectManager.ForeColor = System.Drawing.Color.White;
            this.btn_ProjectManager.Location = new System.Drawing.Point(628, 646);
            this.btn_ProjectManager.Name = "btn_ProjectManager";
            this.btn_ProjectManager.Size = new System.Drawing.Size(116, 63);
            this.btn_ProjectManager.TabIndex = 60;
            this.btn_ProjectManager.Text = "Project Manager";
            this.btn_ProjectManager.UseVisualStyleBackColor = false;
            this.btn_ProjectManager.Click += new System.EventHandler(this.btn_ProjectManager_Click);
            // 
            // lbl_SenderPassword
            // 
            this.lbl_SenderPassword.AutoSize = true;
            this.lbl_SenderPassword.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SenderPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_SenderPassword.Location = new System.Drawing.Point(739, 624);
            this.lbl_SenderPassword.Name = "lbl_SenderPassword";
            this.lbl_SenderPassword.Size = new System.Drawing.Size(93, 20);
            this.lbl_SenderPassword.TabIndex = 71;
            this.lbl_SenderPassword.Text = "Team Lead";
            this.lbl_SenderPassword.Visible = false;
            // 
            // lbl_SenderEmail
            // 
            this.lbl_SenderEmail.AutoSize = true;
            this.lbl_SenderEmail.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SenderEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_SenderEmail.Location = new System.Drawing.Point(624, 624);
            this.lbl_SenderEmail.Name = "lbl_SenderEmail";
            this.lbl_SenderEmail.Size = new System.Drawing.Size(93, 20);
            this.lbl_SenderEmail.TabIndex = 70;
            this.lbl_SenderEmail.Text = "Team Lead";
            this.lbl_SenderEmail.Visible = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.lbl_SenderPassword);
            this.Controls.Add(this.lbl_SenderEmail);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.cmb_VerticalManager);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_ProjectManager);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_TeamLead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_TeamLead);
            this.Controls.Add(this.btn_VerticalManager);
            this.Controls.Add(this.btn_ProjectManager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_Date);
            this.Controls.Add(this.grid_Employees);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Attendance";
            this.Text = "Daily Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Defaulters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.DataGridView grid_Employees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.ComboBox cmb_VerticalManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_ProjectManager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_TeamLead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_TeamLead;
        private System.Windows.Forms.Button btn_VerticalManager;
        private System.Windows.Forms.Button btn_ProjectManager;
        private System.Windows.Forms.Label lbl_SenderPassword;
        private System.Windows.Forms.Label lbl_SenderEmail;
    }
}