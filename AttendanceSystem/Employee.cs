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
    public partial class Employee : Form
    {
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataAdapter sqliteDataAdapter;
        private DataSet GriddataSet = new DataSet();
        private DataTable EmployeeDataTable = new DataTable();

        public Employee()
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
                string txtQuery = "SELECT * FROM Employees";
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
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txt_EmployeeName.Text) || string.IsNullOrEmpty(txt_MobileNumber.Text) || string.IsNullOrEmpty(txt_EmailID.Text) || string.IsNullOrEmpty(cmb_EmployeeRole.Text) )
                {
                    MessageBox.Show("Enter Valid Information !\n Some Information are Missing");

                }
                
                else
                {
                    string txtQuery = "INSERT INTO Employees(Employee_Name, Employee_Role, Employee_Project, Employee_MobileNumber, Employee_EmailID, Employee_Status, Employee_RFID) VALUES('" + txt_EmployeeName.Text + "','" + cmb_EmployeeRole.Text + "','" + txt_Project.Text + "','" + txt_MobileNumber.Text + "','" + txt_EmailID.Text + "','" + cmb_EmployeeStatus.Text + "','" + txt_RFID.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Employee Added Successfully");

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ClearData();
            }

        }
        private void ClearData()
        {
            txt_EmployeeName.Clear();
            cmb_EmployeeRole.SelectedIndex = -1;
            txt_Project.Clear();
            txt_MobileNumber.Clear();
            txt_EmailID.Clear();
            cmb_EmployeeStatus.SelectedIndex = 0;
            txt_RFID.Clear();
            txt_EmployeeName.Focus();
            btn_Save.Visible = true;
            btn_Update.Visible = false;
            btn_Delete.Visible = false;
            LoadEmployeeID();
        }

        private void LoadEmployeeID()
        {
            SetConnection();
            sqliteConnection.Open();
            sqliteCommand = sqliteConnection.CreateCommand();
            string txtQuery = "SELECT Count(Employee_ID) FROM Employees";
            sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
            sqliteDataAdapter.Fill(EmployeeDataTable);

            if (EmployeeDataTable.Rows.Count == 1)
            {
                txt_EmployeeID.Text = (Convert.ToInt32(EmployeeDataTable.Rows[0][0]) + 1).ToString();
            }
            EmployeeDataTable.Reset();
            sqliteConnection.Close();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadEmployeeID();
            LoadGridData();
            ClearData();
        }

        private void grid_Employees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txt_EmployeeID.Text = grid_Employees.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_EmployeeName.Text = grid_Employees.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmb_EmployeeRole.Text = grid_Employees.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_Project.Text = grid_Employees.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_MobileNumber.Text = grid_Employees.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txt_EmailID.Text = grid_Employees.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cmb_EmployeeStatus.Text = grid_Employees.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txt_RFID.Text = grid_Employees.Rows[e.RowIndex].Cells[7].Value.ToString();
                    btn_Save.Visible = false;
                    btn_Update.Visible = true;
                    btn_Delete.Visible = true;

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
                if (string.IsNullOrEmpty(txt_EmployeeName.Text) || string.IsNullOrEmpty(txt_MobileNumber.Text) || string.IsNullOrEmpty(txt_EmailID.Text) || string.IsNullOrEmpty(cmb_EmployeeRole.Text))
                {
                    MessageBox.Show("Enter Valid Information !\n Some Information are Missing");

                }

                else
                {
                    string txtQuery = "UPDATE Employees SET Employee_Name = '" + txt_EmployeeName.Text + "', Employee_Role = '" + cmb_EmployeeRole.Text + "', Employee_Project = '" + txt_Project.Text + "', Employee_MobileNumber = '" + txt_MobileNumber.Text + "', Employee_EmailID = '" + txt_EmailID.Text + "', Employee_Status  = '" + cmb_EmployeeStatus.Text + "', Employee_RFID  = '" + txt_RFID.Text + "' WHERE Employee_ID  = '" + txt_EmployeeID.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Employee Updated Successfully");

                }
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
                if (string.IsNullOrEmpty(txt_EmployeeName.Text) || string.IsNullOrEmpty(txt_MobileNumber.Text) || string.IsNullOrEmpty(txt_EmailID.Text) || string.IsNullOrEmpty(cmb_EmployeeRole.Text))
                {
                    MessageBox.Show("Enter Valid Information !\n Some Information are Missing");

                }
                else
                {
                    string txtQuery = "DELETE FROM Employees WHERE Employee_ID= '" + txt_EmployeeID.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    MessageBox.Show("Employee Deleted Successfully");
                    ClearData();
                }
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
    }
}
