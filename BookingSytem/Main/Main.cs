using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            string Query = "select Client_Name As 'Name',Vehicle_Make As 'Make',Booking_Date As 'Date',Booking_Time as 'Time',Booking_Notes As 'Notes' from Booking_Tabel";

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
            string MessageBoxTitle = "Exiting The System";
            string MessageBoxContent = "Are You sure you want to Exit Out of the applition";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
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
            DV.RowFilter = string.Format("Date LIKE '%{0}%'", TodayDate);
            DataView.DataSource = DV;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {        
            label2.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm");           
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Loadshedding_btn_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Logout";
            string MessageBoxContent = "Are You sure you want to Logout";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Login Login = new Login();
                Login.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }           
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SysSelecting Sys = new SysSelecting();
            Sys.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://restcountries.com/v3.1/");
            HttpResponseMessage reponse = client.GetAsync("name/aruba?fullText=true").Result;

            HttpContent content = reponse.Content;
        }
    }   
}
