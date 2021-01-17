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
            InitializeComponent();
        }

       
        
       
           

           
           
        
        private void Search(object sender, EventArgs e)
        {
            if(Searchbox.Text.Length == 8)
            {
                Persistance pr = new Persistance();
                Username.Text = pr.Get_Patient(Searchbox.Text)[1];
                Usercni.Text = pr.Get_Patient(Searchbox.Text)[0];
                Userage.Text = pr.Get_Patient(Searchbox.Text)[5];
                Userphone.Text = pr.Get_Patient(Searchbox.Text)[3];
                Useradress.Text = pr.Get_Patient(Searchbox.Text)[2];
                Userstatut.Text = pr.Get_Patient(Searchbox.Text)[4];
        
                if (Userstatut.Text == "Patient")
                {
                    Userstatut.ForeColor = System.Drawing.Color.Red;
                }
                else if (Userstatut.Text == "Vaccine")
                {
                    Userstatut.ForeColor = System.Drawing.Color.Blue;
                }
                else if (Userstatut.Text == "Possible")
                {
                    Userstatut.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    Userstatut.ForeColor = System.Drawing.Color.Green;
                }

            }
            else
            {
                MessageBox.Show("CNI PAS VALIDE");
            }
            
        }

        private void updates(object sender, EventArgs e)
        {
            Updates up = new Updates();
            up.Cn = Usercni.Text;
            MessageBox.Show(up.Cn);
            this.Hide();
            Updates updates = new Updates();
            updates.Show();
        }
    }
}
