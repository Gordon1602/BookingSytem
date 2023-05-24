using System;
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
    public partial class DeletingSelection : Form
    {
        public DeletingSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientDel clientDel = new ClientDel();
            clientDel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VehicleDel vehicleDel = new VehicleDel();
            vehicleDel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingDel bookingDel = new BookingDel();
            bookingDel.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();

        }
    }
}
