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
            ct.Genre = GrField.Text;
            ct.Statut = StField.Text;
            if (ct.Statut == "Normal")
            {
                ct.Color = "Green";
            }
            else if(ct.Statut == "vaccine")
            {
                ct.Color = "Blue";
            }
            else {
                ct.Color = "Red";
            }


        }
        public String t ;
        private void Focus_Click(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            t = tb.Text;
            tb.Text = "";

        }

        private void Focus_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == "")
            {
                tb.Text = t;
            }
        }

        private void Signup(object sender, EventArgs e)
        {

            ct.insertdata( ct.FullName, ct.Cni, ct.Adress,ct.Phone,  ct.Date, ct.Genre, ct.Statut,  ct.Color ) ;
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
