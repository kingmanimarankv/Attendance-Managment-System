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
    public partial class EntryForm : Form
    {
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataAdapter sqliteDataAdapter;
        private DataSet GriddataSet = new DataSet();
        private DataSet EmployeeGriddataSet = new DataSet();
        private DataTable EmployeeDataTable = new DataTable();
        public EntryForm()
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
                string date = dt_Date.Value.ToShortDateString();
                
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Attendance_Entry WHERE Date LIKE '"+date+"%'";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                GriddataSet.Reset();
                sqliteDataAdapter.Fill(GriddataSet);
                grid_Attendance.DataSource = GriddataSet.Tables[0];
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            if (grid_Attendance.Rows.Count > 1)
            {
                btn_Load.Visible = false;
            }
            else
            {
                btn_Load.Visible = true;
            }
        }

        private void LoadEmployeeGridData()
        {

            try
            {
                SetConnection();
                sqliteConnection.Open();
                sqliteCommand = sqliteConnection.CreateCommand();
                string txtQuery = "SELECT * FROM Employees";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                EmployeeGriddataSet.Reset();
                sqliteDataAdapter.Fill(EmployeeGriddataSet);
                grid_Employees.DataSource = EmployeeGriddataSet.Tables[0];
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

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            LoginScreen frm = new LoginScreen();
            frm.Show();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            LoadGridData();
            LoadEmployeeGridData();
           
          


        }

        void LoadAttendanceToday()
        {

            string date = dt_Date.Value.ToShortDateString();

            for (int i = 0; i < grid_Employees.Rows.Count - 1; i++)
            {
                string txtQuery = "INSERT INTO Attendance_Entry(Date, Employee_ID, Employee_Name, Status) VALUES('" + date + "','" +grid_Employees.Rows[i].Cells[0].Value.ToString()+ "','" + grid_Employees.Rows[i].Cells[1].Value.ToString() + "','Absent')";
                ExecuteQuery(txtQuery);
                LoadGridData();
                ClearData();

            }



        }



        private void txt_RFID_TextChanged_1(object sender, EventArgs e)
        {
            string txtQuery;
            if (txt_RFID.TextLength >= 10)
            {
                SetConnection();
                try
                {
                    sqliteConnection.Open();
                    sqliteCommand = sqliteConnection.CreateCommand();
                    txtQuery = "SELECT * FROM Employees WHERE Employee_RFID = '" + txt_RFID.Text + "'";
                    sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                    sqliteDataAdapter.Fill(EmployeeDataTable);

                    if (EmployeeDataTable.Rows.Count == 1)
                    {
                        txt_EmployeeName.Text = EmployeeDataTable.Rows[0][1].ToString();
                        txt_EmployeeID.Text = EmployeeDataTable.Rows[0][0].ToString();


                    }
                    EmployeeDataTable.Reset();
                    sqliteConnection.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                txtQuery = "UPDATE Attendance_Entry SET Status = 'Present' WHERE Employee_ID = '" + txt_EmployeeID.Text + "'";
                ExecuteQuery(txtQuery);
                LoadGridData();
                ClearData();

            }
        }
        void ClearData()
        {
            txt_RFID.Clear();
            txt_EmployeeID.Clear();
            txt_EmployeeName.Clear();
            txt_RFID.Focus();
        }

        private void dt_Date_ValueChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadAttendanceToday();
            LoadGridData();
        }
    }
}
