using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookingSytem
{
    public partial class SysSelecting : Form
    {
        datahandler Handler;
        DataTable datatable;
        SqlDataAdapter sqladapter;


        public SysSelecting()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
           
        }

        private void SysSelecting_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.AllUserSystem();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQL_Conntios Dbcon = new SQL_Conntios();
            Dbcon.Conntion();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "DELETE FROM Login WHERE Login_Id = @Login_Id";

                using (SqlCommand deleteRecord = new SqlCommand(sql, Dbcon.con))
                {
                    Dbcon.con.Open();

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    int Login_Id = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@Login_Id", SqlDbType.Int).Value = Login_Id;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    Dbcon.con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SysuserAdd sysuser = new SysuserAdd();
            sysuser.Show();
            this.Hide();
        }
    }
}
