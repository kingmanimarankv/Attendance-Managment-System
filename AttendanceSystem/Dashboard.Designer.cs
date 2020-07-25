namespace AttendanceSystem
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRelationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plannedLeaveEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegisterToolStripMenuItem,
            this.employeeRelationshipToolStripMenuItem,
            this.plannedLeaveEntryToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // employeeRegisterToolStripMenuItem
            // 
            this.employeeRegisterToolStripMenuItem.Name = "employeeRegisterToolStripMenuItem";
            this.employeeRegisterToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.employeeRegisterToolStripMenuItem.Text = "Employee Register";
            this.employeeRegisterToolStripMenuItem.Click += new System.EventHandler(this.employeeRegisterToolStripMenuItem_Click);
            // 
            // employeeRelationshipToolStripMenuItem
            // 
            this.employeeRelationshipToolStripMenuItem.Name = "employeeRelationshipToolStripMenuItem";
            this.employeeRelationshipToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.employeeRelationshipToolStripMenuItem.Text = "Employee Relationship";
            this.employeeRelationshipToolStripMenuItem.Click += new System.EventHandler(this.employeeRelationshipToolStripMenuItem_Click);
            // 
            // plannedLeaveEntryToolStripMenuItem
            // 
            this.plannedLeaveEntryToolStripMenuItem.Name = "plannedLeaveEntryToolStripMenuItem";
            this.plannedLeaveEntryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.plannedLeaveEntryToolStripMenuItem.Text = "Planned Leave Entry";
            this.plannedLeaveEntryToolStripMenuItem.Click += new System.EventHandler(this.plannedLeaveEntryToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultersToolStripMenuItem,
            this.dailyAttendanceToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // defaultersToolStripMenuItem
            // 
            this.defaultersToolStripMenuItem.Name = "defaultersToolStripMenuItem";
            this.defaultersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultersToolStripMenuItem.Text = "Defaulters";
            this.defaultersToolStripMenuItem.Click += new System.EventHandler(this.defaultersToolStripMenuItem_Click);
            // 
            // dailyAttendanceToolStripMenuItem
            // 
            this.dailyAttendanceToolStripMenuItem.Name = "dailyAttendanceToolStripMenuItem";
            this.dailyAttendanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dailyAttendanceToolStripMenuItem.Text = "Daily Attendance";
            this.dailyAttendanceToolStripMenuItem.Click += new System.EventHandler(this.dailyAttendanceToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRelationshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plannedLeaveEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}