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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

       
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Username = txt_Username.Text;
            string Password = txt_Password.Text;

            if (Username == "admin" && Password == "admin")
            {
                Dashboard frm = new Dashboard();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Username.Focus();
        }
    }
}
