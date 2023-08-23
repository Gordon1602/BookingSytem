using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BookingSytem
{
    public partial class ClientDel : Form
    {

        
        datahandler Handler;
        public ClientDel()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void ClientDel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.Clientscearh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SQL_Conntios Dbcon = new SQL_Conntios();
            Dbcon.Conntion();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "DELETE FROM Client_table WHERE Client_Id = @Client_Id";

                using (SqlCommand deleteRecord = new SqlCommand(sql, Dbcon.con))
                {
                    Dbcon.con.Open();

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    int Client_Id = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@Client_Id", SqlDbType.Int).Value = Client_Id;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    Dbcon.con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeletingSelection deletingSelection = new DeletingSelection();
            deletingSelection.Show();
            this.Hide();
        }

        private void ClientDel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
