namespace AttendanceSystem
{
    partial class Employee_Relationship
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.grid_Employees = new System.Windows.Forms.DataGridView();
            this.txt_Project = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmb_TeamLead = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_ProjectManager = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_VerticalManager = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_RelationshipID = new System.Windows.Forms.Label();
            this.txt_EmployeeRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.BackColor = System.Drawing.Color.Purple;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(341, 701);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 48);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(707, 701);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 48);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.grid_Employees.Location = new System.Drawing.Point(20, 212);
            this.grid_Employees.Name = "grid_Employees";
            this.grid_Employees.Size = new System.Drawing.Size(1252, 469);
            this.grid_Employees.TabIndex = 44;
            this.grid_Employees.TabStop = false;
            this.grid_Employees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Employees_CellMouseClick);
            // 
            // txt_Project
            // 
            this.txt_Project.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Project.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Project.ForeColor = System.Drawing.Color.Green;
            this.txt_Project.Location = new System.Drawing.Point(925, 97);
            this.txt_Project.Name = "txt_Project";
            this.txt_Project.ReadOnly = true;
            this.txt_Project.Size = new System.Drawing.Size(347, 27);
            this.txt_Project.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(925, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Project";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(607, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Employee Role";
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_EmployeeName.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeName.ForeColor = System.Drawing.Color.Green;
            this.txt_EmployeeName.Location = new System.Drawing.Point(164, 96);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.ReadOnly = true;
            this.txt_EmployeeName.Size = new System.Drawing.Size(437, 27);
            this.txt_EmployeeName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(164, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Patua One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 45);
            this.label4.TabIndex = 32;
            this.label4.Text = "Employee Relationship";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(585, 701);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(116, 48);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(463, 701);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(116, 48);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_EmployeeID.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeID.ForeColor = System.Drawing.Color.Green;
            this.txt_EmployeeID.Location = new System.Drawing.Point(20, 96);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(138, 27);
            this.txt_EmployeeID.TabIndex = 0;
            this.txt_EmployeeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EmployeeID_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Employee ID";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(463, 701);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(116, 48);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cmb_TeamLead
            // 
            this.cmb_TeamLead.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cmb_TeamLead.Location = new System.Drawing.Point(20, 158);
            this.cmb_TeamLead.Name = "cmb_TeamLead";
            this.cmb_TeamLead.Size = new System.Drawing.Size(397, 28);
            this.cmb_TeamLead.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(20, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Team Lead";
            // 
            // cmb_ProjectManager
            // 
            this.cmb_ProjectManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cmb_ProjectManager.Location = new System.Drawing.Point(447, 158);
            this.cmb_ProjectManager.Name = "cmb_ProjectManager";
            this.cmb_ProjectManager.Size = new System.Drawing.Size(397, 28);
            this.cmb_ProjectManager.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(447, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Project Manager";
            // 
            // cmb_VerticalManager
            // 
            this.cmb_VerticalManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cmb_VerticalManager.Location = new System.Drawing.Point(875, 158);
            this.cmb_VerticalManager.Name = "cmb_VerticalManager";
            this.cmb_VerticalManager.Size = new System.Drawing.Size(397, 28);
            this.cmb_VerticalManager.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(875, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Vertical Manager";
            // 
            // lbl_RelationshipID
            // 
            this.lbl_RelationshipID.AutoSize = true;
            this.lbl_RelationshipID.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RelationshipID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_RelationshipID.Location = new System.Drawing.Point(413, 56);
            this.lbl_RelationshipID.Name = "lbl_RelationshipID";
            this.lbl_RelationshipID.Size = new System.Drawing.Size(104, 20);
            this.lbl_RelationshipID.TabIndex = 54;
            this.lbl_RelationshipID.Text = "Employee ID";
            this.lbl_RelationshipID.Visible = false;
            // 
            // txt_EmployeeRole
            // 
            this.txt_EmployeeRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_EmployeeRole.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeRole.ForeColor = System.Drawing.Color.Green;
            this.txt_EmployeeRole.Location = new System.Drawing.Point(611, 97);
            this.txt_EmployeeRole.Name = "txt_EmployeeRole";
            this.txt_EmployeeRole.ReadOnly = true;
            this.txt_EmployeeRole.Size = new System.Drawing.Size(308, 27);
            this.txt_EmployeeRole.TabIndex = 55;
            // 
            // Employee_Relationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.txt_EmployeeRole);
            this.Controls.Add(this.lbl_RelationshipID);
            this.Controls.Add(this.cmb_VerticalManager);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_ProjectManager);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_TeamLead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.grid_Employees);
            this.Controls.Add(this.txt_Project);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_EmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_EmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Employee_Relationship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Relationship";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Relationship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView grid_Employees;
        private System.Windows.Forms.TextBox txt_Project;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cmb_TeamLead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_ProjectManager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_VerticalManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_RelationshipID;
        private System.Windows.Forms.TextBox txt_EmployeeRole;
    }
}