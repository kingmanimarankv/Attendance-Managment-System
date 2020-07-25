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
   
    public partial class Settings : Form
    {
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataAdapter sqliteDataAdapter;
        private DataSet GriddataSet = new DataSet();
        private DataTable EmployeeSearchDataTable = new DataTable();
        public Settings()
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO Settings VALUES('1','" + txt_Email.Text + "','" + txt_Password.Text + "')";
            ExecuteQuery(txtQuery);
            MessageBox.Show("Saved Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE Settings SET Email='" + txt_Email.Text + "',Password='" + txt_Password.Text + "'WHERE EntryID=1";
            ExecuteQuery(txtQuery);
            MessageBox.Show("Saved Successfully");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
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
                    txt_Email.Text = EmployeeSearchDataTable.Rows[0][1].ToString();
                    txt_Password.Text = EmployeeSearchDataTable.Rows[0][2].ToString();


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
