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

            string query = "SELECT* FROM Client_table WHERE Client_Name = '" + textBox1.Text + "'";
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

            string query = "SELECT* FROM Client_Vehicle WHERE Vehicle_Make = '" + textBox2.Text + "'";
            SqlCommand command = new SqlCommand(query, SQl.con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
