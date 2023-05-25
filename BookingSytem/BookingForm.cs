using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookingSytem
{
    public partial class BookingForm : Form
    {
        datahandler Handler;
        
        public BookingForm()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();

            string sql = @"SELECT Client_Name,Client_Surename FROM Client_table";
            SqlDataAdapter sda = new SqlDataAdapter(sql, SQl.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        
            this.comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Client_Name";


            string sql1 = @"SELECT Vehicle_Make FROM Client_Vehicle";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, SQl.con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            this.comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Vehicle_Make";

        }

        private void button1_Click(object sender, EventArgs e)
        {

          Handler.Add_Booking(comboBox1.Text,comboBox2.Text,dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text);
          Main main = new Main();
          main.Show();
          this.Hide();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
