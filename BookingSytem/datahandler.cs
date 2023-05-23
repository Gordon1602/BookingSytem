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
    internal class datahandler
    {
        string DBconn = "Server = DESKTOP-0GGDTEK\\GORDONDEMO; Initial Catalog = MBooking; Integrated Security = True";


        public void Client_Reg(string Client_Name, string Client_Surename, int Client_PhoneNumde, string Client_CarModel, string Client_CarMake, string Client_Reg)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);
            DBconnection.Open();
            string Cadd = "insert into Client_table(Client_Name,Client_Surename,Client_PhoneNumde) values('" + Client_Name + "','" + Client_Surename + "','" + Client_PhoneNumde + "')";
            string Vadd = "insert into Client_Vehicle(Vehicle_Model,Vehicle_Make,Vehicle_Registration) values('" + Client_CarModel + "','" + Client_CarMake + "','" + Client_Reg + "')";
            SqlCommand com = new SqlCommand(Vadd, DBconnection);
            SqlCommand com1 = new SqlCommand(Cadd, DBconnection);
            try
            {
                com.ExecuteNonQuery();
                com1.ExecuteNonQuery();
                MessageBox.Show("Client Has been Add", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                DBconnection.Close();
            }
        }

        public BindingSource AllBookings()
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);


            DBconnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Booking_Tabel", DBconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource BS = new BindingSource();

            BS.DataSource = reader;


            DBconnection.Close();

            return BS;
        }

        public BindingSource joinedDataTable()
        {
            using (SqlConnection connection = new SqlConnection(DBconn))
            {

                string query = "SELECT * FROM Client_table INNER JOIN Client_Vehicle ON Client_table.Client_Id = Client_Vehicle.Vehicle_Id";

                DataTable dataTable = new DataTable();
             
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }

                BindingSource joinedDataTable1 = new BindingSource();

                joinedDataTable1.DataSource = dataTable;

                return joinedDataTable1;

            }
        }

        public void Add_Booking(string Client_Name,string Vehicle_Make, string Booking_Date, string Booking_Time, string Booking_Notes)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);
            DBconnection.Open();
            string Cadd = "insert into Booking_Tabel(Client_Name,Vehicle_Make,Booking_Date,Booking_Time,Booking_Notes) values('" + Client_Name + "','"+ Vehicle_Make + "','" + Booking_Date + "','" + Booking_Time + "','" + Booking_Notes + "')";
           
            
            SqlCommand com = new SqlCommand(Cadd, DBconnection);
            try
            {
                com.ExecuteNonQuery();
              
                MessageBox.Show("Booking Has been Add", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                DBconnection.Close();
            }
        }


        public BindingSource Clientscearh(int Client_Id)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);


            DBconnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Client_table WHERE Client_Id ='" + Client_Id + "'", DBconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource Binding = new BindingSource();

            Binding.DataSource = reader;


            DBconnection.Close();

            return Binding;
        }
        public BindingSource Vehscearh(int Vehicle_Id)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);


            DBconnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Client_Vehicle WHERE Vehicle_Id ='" + Vehicle_Id + "'", DBconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource Binding = new BindingSource();

            Binding.DataSource = reader;


            DBconnection.Close();

            return Binding;
        }

        public BindingSource Bookingscearh(int Booking_Id)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);


            DBconnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Booking_Tabel WHERE Booking_Id ='" + Booking_Id + "'", DBconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource Binding = new BindingSource();

            Binding.DataSource = reader;


            DBconnection.Close();

            return Binding;
        }

        


    }
}
