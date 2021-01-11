using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Covide_19_Tracker
{
    public partial class Form2 : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;
        public Form2()
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
