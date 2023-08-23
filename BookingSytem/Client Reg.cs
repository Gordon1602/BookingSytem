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
    public partial class Client_Reg : Form
    {

        datahandler Handler;
        public Client_Reg()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            if (String.IsNullOrEmpty(CName.Text) || String.IsNullOrEmpty(CSurename.Text) || String.IsNullOrEmpty(CarModel.Text) || String.IsNullOrEmpty(CarMake.Text) || String.IsNullOrEmpty(Car_Reg.Text))
            {
                MessageBox.Show("There Are Flied That is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(CPH.Text, out i))
            {
                MessageBox.Show("Please Enter A Phone Number", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                Handler.Client_Reg(CName.Text, CSurename.Text, int.Parse(CPH.Text), CarModel.Text, CarMake.Text, Car_Reg.Text);
                Main main = new Main();
                main.Show();
                this.Hide();
            }

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Client_PH_Click(object sender, EventArgs e)
        {

        }

        private void Client_Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
