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
    
    public partial class Main : Form
    {
        datahandler Handler;
        DataTable datatable;
        SqlDataAdapter sqladapter;
        public Main()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client_Reg Creg = new Client_Reg();
             Creg.Show();
            this.Hide();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            DataView.ClearSelection();
            DataView.DataSource = Handler.AllBookings();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          DataView.DataSource = Handler.AllBookings();
            timer1.Start();

            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();
            string Query = "select * from Booking_Tabel";

            SqlCommand com = new SqlCommand(Query, SQl.con);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = com;
            sqladapter.Fill(datatable);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeletingSelection deletingSelection = new DeletingSelection();
            deletingSelection.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingForm Book = new BookingForm();
            Book.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView.ClearSelection();
            DataView.DataSource = Handler.joinedDataTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditingSelect editingform = new EditingSelect();
            editingform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sreach sreach = new Sreach();
            sreach.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string TodayDate = DateTime.Now.ToString("dd/MM/yyyy");
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("Booking_Date LIKE '%{0}%'", TodayDate);
            DataView.DataSource = DV;
        }
   
        private void timer1_Tick_1(object sender, EventArgs e)
        {        
            label2.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm");
        }
    }
}
