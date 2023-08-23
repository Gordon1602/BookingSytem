using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookingSytem
{
    public partial class Login : Form
    { 
        SqlDataAdapter sqladapter;
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;   
                Properties.Settings.Default.Save();
            }
            LoginQ();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginQ();
            }
        }
        private void LoginQ()
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();
            string Query = "SELECT COUNT(*) FROM login WHERE Email = '" + txtUsername.Text.ToLower() + "' AND Password='" + txtPassword.Text + "'";

            SqlCommand com = new SqlCommand(Query, SQl.con);

            sqladapter = new SqlDataAdapter();
            DataTable Ldt = new DataTable();
            sqladapter.SelectCommand = com;
            sqladapter.Fill(Ldt);

            if (Ldt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Main().Show();
            }
            else
                MessageBox.Show("Invalid username or password", "Incorrect Passowrd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                checkBox1.Checked = true;
            }
        }
    } 
}



