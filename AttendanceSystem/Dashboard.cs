using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void employeeRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            frm.Show();
        }

        private void employeeRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Relationship frm = new Employee_Relationship();
            frm.Show();
        }

        private void plannedLeaveEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlannedLeaveEntry frm = new PlannedLeaveEntry();
            frm.Show();
        }

        private void defaultersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Defaulters frm = new Defaulters();
            frm.Show();
        }

        private void dailyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance frm = new Attendance();
            frm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.Show();
        }
    }
}
