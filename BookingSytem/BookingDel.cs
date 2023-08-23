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
    public partial class BookingDel : Form
    {

        datahandler Handler;
     
        public BookingDel()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void BookingDel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.AllBookings();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            SQL_Conntios Dbcon = new SQL_Conntios();
            Dbcon.Conntion();
           
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "DELETE FROM Booking_Tabel WHERE Booking_Id = @Booking_Id";

                using (SqlCommand deleteRecord = new SqlCommand(sql, Dbcon.con))
                {
                    Dbcon.con.Open();

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    int Booking_Id = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@Booking_Id", SqlDbType.Int).Value = Booking_Id;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    Dbcon.con.Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DeletingSelection deletingSelection = new DeletingSelection();
            deletingSelection.Show();
            this.Hide();
        }

        private void BookingDel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
