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
           // DataView.DataSource = Handler.AllBookings();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (DataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "DELETE FROM Booking_Tabel WHERE Booking_Id = @Booking_Id";

                using (SqlCommand deleteRecord = new SqlCommand(sql, Dbcon))
                {
                    Dbcon.Open();

                    int selectedIndex = DataView.SelectedRows[0].Index;

                    int Client_Id = Convert.ToInt32(DataView[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@Booking_Id", SqlDbType.Int).Value = Client_Id;
                    deleteRecord.ExecuteNonQuery();

                    DataView.Rows.RemoveAt(selectedIndex);
                    Dbcon.Close();
                }
            }
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
            editingform editingform = new editingform();
            editingform.Show();
            this.Hide();
        }
    }
}
