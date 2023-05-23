﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSytem
{
    public partial class editingform : Form
    {
        public editingform()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_Edit client_Edit = new Client_Edit();
            client_Edit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle_Edit vehicle_Edit = new Vehicle_Edit();
            vehicle_Edit.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking_Edit booking_Edit = new Booking_Edit();
            booking_Edit.Show();
            this.Hide();

        }
    }
}
