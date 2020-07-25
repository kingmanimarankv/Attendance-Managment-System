using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;


namespace AttendanceSystem
{
    public partial class Defaulters : Form
    {
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataAdapter sqliteDataAdapter;
        private DataSet GriddataSet = new DataSet();
        private DataSet TeamLeaddataSet = new DataSet();
        private DataSet ProjectManagerdataSet = new DataSet();
        private DataSet VerticalManagerdataSet = new DataSet();
        private DataTable EmployeeSearchDataTable = new DataTable();





        public Defaulters()
        {
            InitializeComponent();
        }

        private void Defaulters_Load(object sender, EventArgs e)
        {
            LoadGridData();
            LoadTeamLead();
            LoadProjectManager();
            LoadVerticalManager();
            SenderEmailGet();
        }
        private void LoadTeamLead()
        {

            try
            {
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Employees WHERE Employee_Role = 'Level 3 : Team Lead' ";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                TeamLeaddataSet.Reset();
                sqliteDataAdapter.Fill(TeamLeaddataSet);
                cmb_TeamLead.DataSource = TeamLeaddataSet.Tables[0];
                cmb_TeamLead.DisplayMember = "Employee_Name";
                cmb_TeamLead.Enabled = true;
                this.cmb_TeamLead.SelectedIndex = -1;
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void LoadProjectManager()
        {

            try
            {
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Employees WHERE Employee_Role = 'Level 4 : Team Manager' ";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                ProjectManagerdataSet.Reset();
                sqliteDataAdapter.Fill(ProjectManagerdataSet);
                cmb_ProjectManager.DataSource = ProjectManagerdataSet.Tables[0];
                cmb_ProjectManager.DisplayMember = "Employee_Name";
                cmb_ProjectManager.Enabled = true;
                this.cmb_ProjectManager.SelectedIndex = -1;
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void LoadVerticalManager()
        {

            try
            {
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Employees WHERE Employee_Role = 'Level 5 : Vertical Manager' ";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                VerticalManagerdataSet.Reset();
                sqliteDataAdapter.Fill(VerticalManagerdataSet);
                cmb_VerticalManager.DataSource = VerticalManagerdataSet.Tables[0];
                cmb_VerticalManager.DisplayMember = "Employee_Name";
                cmb_VerticalManager.Enabled = true;
                this.cmb_VerticalManager.SelectedIndex = -1;
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }


        private void SetConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=AttendanceSystem.db;Version=3;New=False;Compress=True;");
        }
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sqliteConnection.Open();
            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = txtQuery;
            sqliteCommand.ExecuteNonQuery();
            sqliteConnection.Close();
        }
        private void LoadGridData()
        {
            string date = dt_Date.Value.ToShortDateString();
            try
            {
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT e.Employee_ID, e.Employee_Name, e.Employee_Role,e.Employee_Project, r.TeamLead, r.ProjectManager, r.VerticalManager FROM Employees e JOIN Employees_Relationship r, Attendance_Entry a WHERE e.Employee_ID = a.Employee_ID AND e.Employee_ID = r.Employee_ID AND a.Status= 'Absent' AND a.Date ='"+ date+"'";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                GriddataSet.Reset();
                sqliteDataAdapter.Fill(GriddataSet);
                grid_Employees.DataSource = GriddataSet.Tables[0];
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void dt_Date_ValueChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        void SenderEmailGet()
        {
            SetConnection();
            try
            {
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Settings WHERE EntryID=1";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                EmployeeSearchDataTable.Clear();
                sqliteDataAdapter.Fill(EmployeeSearchDataTable);

                if (EmployeeSearchDataTable.Rows.Count == 1)
                {
                    lbl_SenderEmail.Text = EmployeeSearchDataTable.Rows[0][1].ToString();
                    lbl_SenderPassword.Text = EmployeeSearchDataTable.Rows[0][2].ToString();
                    

                }
                EmployeeSearchDataTable.Reset();
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btn_TeamLead_Click(object sender, EventArgs e)
        {
            SetConnection();
            try
            {
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT Employee_EmailID FROM Employees WHERE Employee_Name='" + cmb_TeamLead.Text + "'";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                EmployeeSearchDataTable.Clear();
                sqliteDataAdapter.Fill(EmployeeSearchDataTable);

                if (EmployeeSearchDataTable.Rows.Count == 1)
                {
                    lbl_Email.Text = EmployeeSearchDataTable.Rows[0][0].ToString();

                }
                EmployeeSearchDataTable.Reset();
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
            string date = dt_Date.Value.ToShortDateString();
            
            string EmployeeList = "Hi "+cmb_TeamLead.Text+",\nToday's (" + date + ") Absentees are\nEmployee ID\t\tEmployee Name\n";

            for (int i = 0; i < grid_Employees.Rows.Count - 1; i++)
            {
                if (grid_Employees.Rows[i].Cells[4].Value.ToString() == cmb_TeamLead.Text)
                {

                    EmployeeList += grid_Employees.Rows[i].Cells[0].Value.ToString();
                    EmployeeList += "\t\t\t\t";
                    EmployeeList += grid_Employees.Rows[i].Cells[1].Value.ToString();
                    EmployeeList += "\n";
                }
            }

            Console.WriteLine(EmployeeList);

            SendMail(EmployeeList, lbl_Email.Text, "Absentees List (" + date + ")");
            MessageBox.Show("Email sent");


        }

       
        void SendMail(string Message,string ToEmail,string MailSubject)
        {

            using (MailMessage mm = new MailMessage(lbl_SenderEmail.Text, lbl_Email.Text.Trim()))
            {
                mm.Subject = MailSubject;
                mm.Body = Message;
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(lbl_SenderEmail.Text,lbl_SenderPassword.Text); ;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);

            }
        }

        private void btn_ProjectManager_Click(object sender, EventArgs e)
        {
            SetConnection();
            try
            {
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT Employee_EmailID FROM Employees WHERE Employee_Name='" + cmb_ProjectManager.Text + "'";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                EmployeeSearchDataTable.Clear();
                sqliteDataAdapter.Fill(EmployeeSearchDataTable);

                if (EmployeeSearchDataTable.Rows.Count == 1)
                {
                    lbl_Email.Text = EmployeeSearchDataTable.Rows[0][0].ToString();

                }
                EmployeeSearchDataTable.Reset();
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            string date = dt_Date.Value.ToShortDateString();

            string EmployeeList = "Hi " + cmb_ProjectManager.Text + ",\nToday's (" + date + ") Absentees are\nEmployee ID\t\tEmployee Name\n";

            for (int i = 0; i < grid_Employees.Rows.Count - 1; i++)
            {
                if (grid_Employees.Rows[i].Cells[5].Value.ToString() == cmb_ProjectManager.Text)
                {

                    EmployeeList += grid_Employees.Rows[i].Cells[0].Value.ToString();
                    EmployeeList += "\t\t\t\t";
                    EmployeeList += grid_Employees.Rows[i].Cells[1].Value.ToString();
                    EmployeeList += "\n";
                }
            }

            Console.WriteLine(EmployeeList);

            SendMail(EmployeeList, lbl_Email.Text, "Absentees List (" + date + ")");
            MessageBox.Show("Email sent");

        }

        private void btn_VerticalManager_Click(object sender, EventArgs e)
        {
            SetConnection();
            try
            {
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT Employee_EmailID FROM Employees WHERE Employee_Name='" + cmb_VerticalManager.Text + "'";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                EmployeeSearchDataTable.Clear();
                sqliteDataAdapter.Fill(EmployeeSearchDataTable);

                if (EmployeeSearchDataTable.Rows.Count == 1)
                {
                    lbl_Email.Text = EmployeeSearchDataTable.Rows[0][0].ToString();

                }
                EmployeeSearchDataTable.Reset();
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            string date = dt_Date.Value.ToShortDateString();

            string EmployeeList = "Hi " + cmb_VerticalManager.Text + ",\nToday's (" + date + ") Absentees are\nEmployee ID\t\tEmployee Name\n";

            for (int i = 0; i < grid_Employees.Rows.Count - 1; i++)
            {
                if (grid_Employees.Rows[i].Cells[6].Value.ToString() == cmb_VerticalManager.Text)
                {

                    EmployeeList += grid_Employees.Rows[i].Cells[0].Value.ToString();
                    EmployeeList += "\t\t\t\t";
                    EmployeeList += grid_Employees.Rows[i].Cells[1].Value.ToString();
                    EmployeeList += "\n";
                }
            }

            Console.WriteLine(EmployeeList);

            SendMail(EmployeeList, lbl_Email.Text, "Absentees List (" + date + ")");
            MessageBox.Show("Email sent");

        }

        private void btn_Individual_Click(object sender, EventArgs e)
        {
            SetConnection();
            string date = dt_Date.Value.ToShortDateString();
            
            for (int i = 0; i < grid_Employees.Rows.Count - 1; i++)
            {
                try
                {
                    sqliteConnection.Open();
                    sqliteCommand = sqliteConnection.CreateCommand();
                    string txtQuery = "SELECT Employee_EmailID FROM Employees WHERE Employee_Name='" + grid_Employees.Rows[i].Cells[1].Value.ToString() + "'";
                    sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                    EmployeeSearchDataTable.Clear();
                    sqliteDataAdapter.Fill(EmployeeSearchDataTable);

                    if (EmployeeSearchDataTable.Rows.Count == 1)
                    {
                        lbl_Email.Text = EmployeeSearchDataTable.Rows[0][0].ToString();

                    }
                    EmployeeSearchDataTable.Reset();
                    sqliteConnection.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

                string EmployeeList = "Hi " + grid_Employees.Rows[i].Cells[1].Value.ToString() + ",\n You are marked absent for today("+date+").\nRegards,\nHR";
                Console.WriteLine(EmployeeList);

                SendMail(EmployeeList, lbl_Email.Text, "You are marked Absent for Today");


            }

            

        }
    }
    }
