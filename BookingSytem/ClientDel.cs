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
    public partial class ClientDel : Form
    {

        SqlConnection Dbcon = new SqlConnection("Server = DESKTOP-0GGDTEK\\GORDONDEMO; Initial Catalog = MBooking; Integrated Security = True");

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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "DELETE FROM Client_table WHERE Client_Id = @Client_Id";

                using (SqlCommand deleteRecord = new SqlCommand(sql, Dbcon))
                {
                    Dbcon.Open();

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    int Client_Id = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@Client_Id", SqlDbType.Int).Value = Client_Id;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    Dbcon.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeletingSelection deletingSelection = new DeletingSelection();
            deletingSelection.Show();
            this.Hide();
        }
    }
}
