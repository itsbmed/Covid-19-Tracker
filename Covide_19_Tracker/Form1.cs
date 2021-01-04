using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covide_19_Tracker
{
    public partial class SignUp : Form
    {
        Citoyen ct = new Citoyen();
        Laboratoir lb = new Laboratoir();
        String Gr = "", Cl = "";
        public SignUp()
        {


            InitializeComponent();
        }
        public void setdata()
        {
            ct.FullName = Fnbox.Text;
            ct.Cni = Cnbox.Text;
            ct.Adress = Adbox.Text;
            ct.Phone = Phbox.Text;
            ct.Date = Bdbox.Text;
            
        }
        private void Signup(object sender, EventArgs e)
        {
            if (lb.ResultValue)
            {

            }
            else
            {

            }


            ct.insertdata(
                Fnbox.Text,
                Cnbox.Text,
                Adbox.Text,
                Phbox.Text,
                Bdbox.Text,
                Gr,Gr, Cl ) ;

        }
    }
}
