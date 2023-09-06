using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSytem.Misc
{
    public partial class Cityname : Form
    {
        public Cityname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CityName = textBox1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("City has been change");
            this.Hide();

            
        }

        private void Cityname_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.CityName;
        }
    }
}
