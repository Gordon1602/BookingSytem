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
    public partial class Client_Edit : Form
    {

        SqlCommand cmd;
        int ID = 0;
        datahandler Handler;
        public Client_Edit()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Client_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CSurename.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CPH.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
         
        }

        private void Client_Edit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.Clientscearh();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            EditingSelect editingform = new EditingSelect();
            editingform.Show();
            this.Hide();

        }

        private void Submite_Click(object sender, EventArgs e)
        {
            SQL_Conntios Dbcon = new SQL_Conntios();
            Dbcon.Conntion();

            if (Client_id.Text != "")
            {
                cmd = new SqlCommand("update Client_table set Client_Name=@Client_Name,Client_Surename=@Client_Surename,Client_PhoneNumde=@Client_PhoneNumde where Client_Id=@id", Dbcon.con);
                Dbcon.con.Open();
                cmd.Parameters.AddWithValue("@id", Client_id.Text);
                cmd.Parameters.AddWithValue("@Client_Name", CName.Text);
                cmd.Parameters.AddWithValue("@Client_SureName", CSurename.Text);
                cmd.Parameters.AddWithValue("@Client_PhoneNumde",int.Parse( CPH.Text));
             

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dbcon.con.Close();
                dataGridView1.DataSource = Handler.Clientscearh();

            }
            else
            {

                MessageBox.Show("Please Select Record to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
