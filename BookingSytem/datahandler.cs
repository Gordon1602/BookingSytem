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
       
        public void Client_Reg(string Client_Name, string Client_Surename, int Client_PhoneNumde, string Client_CarModel, string Client_CarMake, string Client_Reg)
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();
            string Cadd = "insert into Client_table(Client_Name,Client_Surename,Client_PhoneNumde) values('" + Client_Name + "','" + Client_Surename + "','" + Client_PhoneNumde + "')";
            string Vadd = "insert into Client_Vehicle(Vehicle_Model,Vehicle_Make,Vehicle_Registration) values('" + Client_CarModel + "','" + Client_CarMake + "','" + Client_Reg + "')";
            SqlCommand com = new SqlCommand(Vadd, SQl.con);
            SqlCommand com1 = new SqlCommand(Cadd, SQl.con);
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
                SQl.con.Close();
            }
        }

        public BindingSource AllBookings()
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Booking_Tabel", SQl.con);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource BS = new BindingSource();

            BS.DataSource = reader;


            SQl.con.Close();

            return BS;
        }

        public BindingSource joinedDataTable()
        {

            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();

            string query = "SELECT * FROM Client_table INNER JOIN Client_Vehicle ON Client_table.Client_Id = Client_Vehicle.Vehicle_Id";

                DataTable dataTable = new DataTable();
             
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, SQl.con))
                {
                    adapter.Fill(dataTable);
                }

                BindingSource joinedDataTable1 = new BindingSource();

                joinedDataTable1.DataSource = dataTable;

                return joinedDataTable1;

            
        }

        public void Add_Booking(string Client_Name,string Vehicle_Make, string Booking_Date, string Booking_Time, string Booking_Notes)
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();
            string Cadd = "insert into Booking_Tabel(Client_Name,Vehicle_Make,Booking_Date,Booking_Time,Booking_Notes) values('" + Client_Name + "','"+ Vehicle_Make + "','" + Booking_Date + "','" + Booking_Time + "','" + Booking_Notes + "')";  
            SqlCommand com = new SqlCommand(Cadd,SQl.con);
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
                SQl.con.Close();
            }
        }


        public BindingSource Clientscearh()
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Client_table", SQl.con);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource Binding = new BindingSource();

            Binding.DataSource = reader;


            SQl.con.Close();

            return Binding;
        }
        public BindingSource Vehscearh()
        {
            SQL_Conntios SQl = new SQL_Conntios();
            SQl.Conntion();
            SQl.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Client_Vehicle ", SQl.con);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource Binding = new BindingSource();

            Binding.DataSource = reader;


            SQl.con.Close();

            return Binding;
        }

    }
}
