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
        SqlConnection Dbcon = new SqlConnection("Server = DESKTOP-0GGDTEK\\GORDONDEMO; Initial Catalog = MBooking; Integrated Security = True");
       
        datahandler Handler;
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
    }
}
