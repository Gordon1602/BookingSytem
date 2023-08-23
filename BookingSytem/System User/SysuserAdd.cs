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
    public partial class SysuserAdd : Form
    {
        datahandler Handler;
        public SysuserAdd()
        {
            InitializeComponent();
            Handler = new datahandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Handler.Add_SystemUser(UserName.Text.ToLower(), Retypepassword.Text, Email.Text.ToLower());
            SysSelecting sysSelecting = new SysSelecting();
            sysSelecting.Show();
            this.Hide();
        }
    }
}
