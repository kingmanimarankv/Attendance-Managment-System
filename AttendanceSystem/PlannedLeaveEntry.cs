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
    public partial class PlannedLeaveEntry : Form
    {
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataAdapter sqliteDataAdapter;
        private DataSet GriddataSet = new DataSet();
        private DataTable EmployeeSearchDataTable = new DataTable();

        public PlannedLeaveEntry()
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
                string txtQuery = "SELECT * FROM PlannedLeave";
                sqliteDataAdapter = new SQLiteDataAdapter(txtQuery, sqliteConnection);
                GriddataSet.Reset();
                sqliteDataAdapter.Fill(GriddataSet);
                grid_PlannedLeaves.DataSource = GriddataSet.Tables[0];
                sqliteConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_EmployeeID.Text)) {
                MessageBox.Show("Enter Employee ID");
                txt_EmployeeID.Focus();
            }
            else
            {
                try
                {
                    string txtQuery = "INSERT INTO PlannedLeave(Employee_ID, Employee_Name, From_Date, To_Date, Total_Days) VALUES('" + txt_EmployeeID.Text + "','" + txt_EmployeeName.Text + "','" + dt_FromDate.Value.ToString() + "','" + dt_ToDate.Value.ToString() + "','" + txt_TotalDays.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Added Successfully");


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    ClearData();
                }
            }

        }
        void ClearData()
        {
            txt_EmployeeID.Clear();
            txt_EmployeeName.Clear();
            dt_FromDate.Value = DateTime.Today;
            dt_ToDate.Value = DateTime.Today;
            btn_Add.Visible = true;
            btn_Delete.Visible = false;
            btn_Update.Visible = false;

        }
        private void grid_Employees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    lbl_EntryID.Text = grid_PlannedLeaves.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_EmployeeID.Text = grid_PlannedLeaves.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_EmployeeName.Text = grid_PlannedLeaves.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dt_FromDate.Text= grid_PlannedLeaves.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dt_ToDate.Text = grid_PlannedLeaves.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txt_TotalDays.Text = grid_PlannedLeaves.Rows[e.RowIndex].Cells[5].Value.ToString();
                    btn_Add.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Update.Visible = true;

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                    string txtQuery = "DELETE FROM PlannedLeave WHERE Entry_ID= '" + lbl_EntryID.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadGridData();
                    MessageBox.Show("Deleted Successfully");
                    ClearData();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ClearData();
            }

        }
        private void txt_EmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void PlannedLeaveEntry_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void dt_ToDate_ValueChanged(object sender, EventArgs e)
        {
            txt_TotalDays.Text = Math.Round(((dt_ToDate.Value - dt_FromDate.Value).TotalDays + 1)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string txtQuery = "UPDATE PlannedLeave SET Employee_ID = '" + txt_EmployeeID.Text + "', Employee_Name = '" + txt_EmployeeName.Text + "', From_Date = '" + dt_FromDate.Value.ToString()+ "', To_Date= '" + dt_ToDate.Value.ToString()+ "', Total_Days= '" + txt_TotalDays.Text + "' WHERE Entry_ID= '" + lbl_EntryID.Text + "'";
                ExecuteQuery(txtQuery);
                LoadGridData();
                ClearData();
                MessageBox.Show("Updated Successfully");


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ClearData();
            }


        }
    }
}
