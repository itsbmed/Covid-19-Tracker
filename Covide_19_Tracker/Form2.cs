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
       
        public Form2()
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Persistance pr = new Persistance();
            Username.Text = pr.Get_Patient("XA137230")[1];
            Usercni.Text = pr.Get_Patient("XA137230")[0];
            Userage.Text = pr.Get_Patient("XA137230")[5];
            Userphone.Text = pr.Get_Patient("XA137230")[5];
            Useradress.Text = pr.Get_Patient("XA137230")[2];
            Userstatut.Text = pr.Get_Patient("XA137230")[4];
            
            if (Userstatut.Text == "Patient")
            {
                Userstatut.ForeColor = System.Drawing.Color.Red;
            }
            else if (Userstatut.Text == "Vaccine")
            {
                Userstatut.ForeColor = System.Drawing.Color.Blue;
            }
            else if (Userstatut.Text == "PatPont")
            {
                Userstatut.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                Userstatut.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
