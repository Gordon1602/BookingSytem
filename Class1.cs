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

namespace PRG252_PROJECT
{
    internal class DataHandler
    {

        string DBconn = "Server = DESKTOP-0GGDTEK\\GORDONDEMO; Initial Catalog = PRG252Mil2; Integrated Security = True";


        public BindingSource AllStudent()
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);


            DBconnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student1", DBconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource BS = new BindingSource();

            BS.DataSource = reader;


            DBconnection.Close();

            return BS;
        }


        public BindingSource scearh(int Student_Number)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);


            DBconnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student1 WHERE Student_Number ='" + Student_Number + "'", DBconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource Binding = new BindingSource();

            Binding.DataSource = reader;


            DBconnection.Close();

            return Binding;
        }


        public void Add(int Student_Number, string Student_Name, string Student_Surname, string Student_DOB, string Student_Gender, int Student_Phone, string Student_Address, string Module_Codes)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);
            DBconnection.Open();
            string add = "insert into Student1(Student_Number,Student_Name,Studet_Surname,Student_DOB,Student_Gender,Student_Phone,Student_Address,Module_Codes) values('" + Student_Number + "','" + Student_Name + "','" + Student_Surname + "','" + Student_DOB + "','" + Student_Gender + "','" + Student_Phone + "','" + Student_Address + "','" + Module_Codes + "')";

            SqlCommand com = new SqlCommand(add, DBconnection);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Student Has been Add");
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


        public void updateinfo(int Student_Number, string Student_Name, string Studet_Surname, int Student_DOB, string Student_Gender, int Student_Phone, string Student_Address, string Module_Codes)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);
            DBconnection.Open();
            string insert = "insert into login(Student_Number,Student_Name,Studet_Surname,Student_DOB,Student_Gender,Student_Phone,Student_Address,Module_Codes) values('" + Student_Number + "','" + Student_Name + "','" + Studet_Surname + "','" + Student_DOB + "','" + Student_Gender + "','" + Student_Phone + "','" + Student_Address + "','" + Module_Codes + "')";

            SqlCommand com = new SqlCommand(insert, DBconnection);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Values inserted");
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


        public void Remove(int Student_Number)
        {


            SqlConnection DBconnection = new SqlConnection(DBconn);
            DBconnection.Open();
            string Del = "DELETE FROM Student1 WHERE Student_Number ='" + Student_Number + "'";


            SqlCommand com = new SqlCommand(Del, DBconnection);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Student Has Be Remove");
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

        public void FormReg(string Password, string Username, string Permission)
        {
            SqlConnection DBconnection = new SqlConnection(DBconn);
            DBconnection.Open();
            string insert = "insert into login(Password,Username,Permission) values('" + Password + "','" + Username + "' ,'" + Permission + "')";

            SqlCommand com = new SqlCommand(insert, DBconnection);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Values inserted");
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






    }


}

