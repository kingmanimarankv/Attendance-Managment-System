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

namespace AttendanceSystem
{
    public partial class Employee_Relationship : Form
    {
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataAdapter sqliteDataAdapter;
        private DataSet GriddataSet = new DataSet();
        private DataSet TeamLeaddataSet = new DataSet();
        private DataSet ProjectManagerdataSet = new DataSet();
        private DataSet VerticalManagerdataSet = new DataSet();
        private DataTable EmployeeDataTable = new DataTable();
        private DataTable EmployeeSearchDataTable = new DataTable();

        public Employee_Relationship()
        {
            InitializeComponent();
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
           
            try
            {
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Employees_Relationship";
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
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            try
            {
                    string txtQuery = "INSERT INTO Employees_Relationship(Employee_ID, Employee_Name, Employee_Role, TeamLead, ProjectManager, VerticalManager) VALUES('" + txt_EmployeeID.Text + "','" + txt_EmployeeName.Text + "','" + txt_EmployeeRole.Text + "','" + cmb_TeamLead.Text + "','" + cmb_ProjectManager.Text + "','" + cmb_VerticalManager.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Employee Added Successfully");

             
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ClearData();
            }

        }
        private void ClearData()
        {
            txt_EmployeeID.Clear();
            txt_EmployeeName.Clear();
            txt_EmployeeRole.Clear();
            cmb_TeamLead.SelectedIndex = -1;
            cmb_ProjectManager.SelectedIndex = -1;
            cmb_VerticalManager.SelectedIndex = -1;
            txt_Project.Clear();
            txt_EmployeeID.Focus();
            btn_Save.Visible = true;
            btn_Update.Visible = false;
            btn_Delete.Visible = false;
        }

        private void Employee_Relationship_Load(object sender, EventArgs e)
        {
            LoadGridData();
            LoadTeamLead();
            LoadProjectManager();
            LoadVerticalManager();
        }
        private void grid_Employees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    lbl_RelationshipID.Text = grid_Employees.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_EmployeeID.Text = grid_Employees.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_EmployeeName.Text = grid_Employees.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_EmployeeRole.Text = grid_Employees.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cmb_TeamLead.Text = grid_Employees.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cmb_ProjectManager.Text = grid_Employees.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cmb_VerticalManager.Text = grid_Employees.Rows[e.RowIndex].Cells[6].Value.ToString();
                    btn_Save.Visible = false;
                    btn_Update.Visible = true;
                    btn_Delete.Visible = true;
                    getEmployeeDetails();


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
               
                    string txtQuery = "UPDATE Employees_Relationship SET Employee_ID = '" + txt_EmployeeID.Text + "', Employee_Name = '" + txt_EmployeeName.Text + "', Employee_Role = '" + txt_EmployeeRole.Text + "', TeamLead = '" + cmb_TeamLead.Text + "', ProjectManager = '" + cmb_ProjectManager.Text + "', VerticalManager  = '" + cmb_VerticalManager.Text + "' WHERE Relationship_ID  = '" + lbl_RelationshipID.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Employee Updated Successfully");

              
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ClearData();
            }




        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
               
                    string txtQuery = "DELETE FROM Employees_Relationship WHERE Relationship_ID= '" + lbl_RelationshipID.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    MessageBox.Show("Employee Deleted Successfully");
                    ClearData();
                          }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ClearData();
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txt_EmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                getEmployeeDetails();  
            }
        }
        private void getEmployeeDetails()
        {
            SetConnection();
            try
            {
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Employees WHERE Employee_ID = '" + txt_EmployeeID.Text + "'";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                sqliteDataAdapter.Fill(EmployeeSearchDataTable);

                if (EmployeeSearchDataTable.Rows.Count == 1)
                {
                    txt_EmployeeName.Text = EmployeeSearchDataTable.Rows[0][1].ToString();
                    txt_EmployeeRole.Text = EmployeeSearchDataTable.Rows[0][2].ToString();
                    txt_Project.Text = EmployeeSearchDataTable.Rows[0][3].ToString();

                }
                EmployeeSearchDataTable.Reset();
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}

