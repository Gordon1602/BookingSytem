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
    class SQL_Conntios
    {

        public SqlConnection con;
        public string DBconn;

        public void Conntion()
        {
     

             DBconn = "Server = DESKTOP-0GGDTEK\\GORDONDEMO; Initial Catalog = MBooking; Integrated Security = True";
             con = new SqlConnection("Server = DESKTOP-0GGDTEK\\GORDONDEMO; Initial Catalog = MBooking; Integrated Security = True");
        }

    }
}
