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
    public partial class Vehicle_Edit : Form
    {
        SqlCommand cmd;
        int ID = 0;
        datahandler Handler;

        public Vehicle_Edit()
        {
            Handler = new datahandler();
            InitializeComponent();
        }

        private void Vehicle_Edit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.Vehscearh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_Conntios Dbcon = new SQL_Conntios();
            Dbcon.Conntion();
            if (CarID.Text != "")
            {
                cmd = new SqlCommand("update Client_Vehicle set Vehicle_Model=@Vehicle_Model ,Vehicle_Make=@Vehicle_Make,Vehicle_Registration=@Vehicle_Registration where Vehicle_Id=@id", Dbcon.con);
                Dbcon.con.Open();
                cmd.Parameters.AddWithValue("@id", CarID.Text);
                cmd.Parameters.AddWithValue("@Vehicle_Model", CarModel.Text);
                cmd.Parameters.AddWithValue("@Vehicle_Make", CarModel.Text);
                cmd.Parameters.AddWithValue("@Vehicle_Registration", CarReg.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dbcon.con.Close();
                dataGridView1.DataSource = Handler.Vehscearh();

            }
            else
            {

                MessageBox.Show("Please Select Record to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditingSelect editingform = new EditingSelect();
            editingform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            CarID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CarModel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Carmake.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CarReg.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Vehicle_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Carmake_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
