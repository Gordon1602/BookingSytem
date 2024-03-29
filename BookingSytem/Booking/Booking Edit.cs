﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookingSytem
{
    public partial class Booking_Edit : Form
    {
        SqlCommand cmd;
        int ID = 0;
        datahandler Handler;
        public Booking_Edit()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            Booking_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Client_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Client_veh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Booking_date.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Booking_time.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Booking_note.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        
        }

        private void Booking_Edit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Handler.AllBookings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditingSelect editingform = new EditingSelect();
            editingform.Show();
            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SQL_Conntios Dbcon = new SQL_Conntios();
            Dbcon.Conntion();

            if (Booking_Id.Text != "" )
            {
                cmd = new SqlCommand("update Booking_Tabel set Client_Name=@Client_Name,Vehicle_Make=@Vehicle_Make,Booking_Date=@Booking_Date,Booking_Time=@Booking_Time,Booking_Notes=@Booking_Notes  where Booking_Id=@id", Dbcon.con);
                Dbcon.con.Open();
                cmd.Parameters.AddWithValue("@id", Booking_Id.Text);
                cmd.Parameters.AddWithValue("@Client_Name", Client_name.Text);
                cmd.Parameters.AddWithValue("@Vehicle_Make", Client_veh.Text);
                cmd.Parameters.AddWithValue("@Booking_Date", Booking_date.Text);
                cmd.Parameters.AddWithValue("@Booking_Time", Booking_time.Text);
                cmd.Parameters.AddWithValue("@Booking_Notes", Booking_note.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                Dbcon.con.Close();
                dataGridView1.DataSource = Handler.AllBookings();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Booking_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
