using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookingSytem
{
    public partial class VehicleDel : Form
    {
       
        datahandler Handler;
        public VehicleDel()
        {
            InitializeComponent();
            Handler = new datahandler();
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
                string sql = "DELETE FROM Client_Vehicle WHERE Vehicle_Id = @Vehicle_Id";

                using (SqlCommand deleteRecord = new SqlCommand(sql, Dbcon.con))
                {
                    Dbcon.con.Open();

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    int Vehicle_Id = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@Vehicle_Id", SqlDbType.Int).Value = Vehicle_Id;
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

        private void VehicleDel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.Vehscearh();
        }
    }
}
