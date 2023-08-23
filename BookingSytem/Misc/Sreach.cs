using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSytem
{
    public partial class Sreach : Form
    {
        public Sreach()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Submite_Click(object sender, EventArgs e)
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();

            string query = "SELECT Client_Name AS Name , Client_Surename AS Surename ,Client_PhoneNumde AS'Phone Number' FROM Client_table WHERE Client_Name LIKE '%" + textBox1.Text.ToLower() + "%'  or  Client_PhoneNumde LIKE '%" + textBox1.Text.ToLower() + "%' or  Client_Surename LIKE '%" + textBox1.Text.ToLower() + "%' ";
            SqlCommand command = new SqlCommand(query, SQl.con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();

            string query = "SELECT Vehicle_Make as Make , Vehicle_Model as Mobel , Vehicle_Registration as 'License Number'  FROM Client_Vehicle WHERE Vehicle_Make Like '%" + textBox2.Text.ToLower() + "%'or Vehicle_Model like '%" + textBox2.Text.ToLower() + "%' or Vehicle_Registration like '%" + textBox2.Text.ToLower() + "%' ";
            SqlCommand command = new SqlCommand(query, SQl.con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Sreach_Load(object sender, EventArgs e)
        {

        }

        private void Sreach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
