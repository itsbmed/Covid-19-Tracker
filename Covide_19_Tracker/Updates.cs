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
    public partial class Updates : Form
    {
        private String cn;
        public String Cn
        {
            get { return cn; }
            set { cn = value; }
        }
        public Updates()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pora.GetItemText(this.pora.SelectedItem) == "Adress")
            {
                phoneoradress.Text = "Adress";
                
            }
            else
            {
                phoneoradress.Text = "Phone";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (proavalue.Text != "")
            {
                Persistance pr = new Persistance();
   
                MessageBox.Show(cn);
                pr.Updates(pora.GetItemText(this.pora.SelectedItem), proavalue.Text,cn);
                this.Close();
                User_Home home = new User_Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Fields");
            }
            
        }

        private void Rt_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            
            Persistance pr = new Persistance();
            hm.f2.Username.Text = pr.Get_Patient(cn)[1];
            hm.f2.Usercni.Text = pr.Get_Patient(cn)[0];
            hm.f2.Userage.Text = pr.Get_Patient(cn)[5];
            hm.f2.Userphone.Text = pr.Get_Patient(cn)[3];
            hm.f2.Useradress.Text = pr.Get_Patient(cn)[2];
            hm.f2.Userstatut.Text = pr.Get_Patient(cn)[4];

                if (hm.f2.Userstatut.Text == "Patient")
                {
                hm.f2.Userstatut.ForeColor = System.Drawing.Color.Red;
                }
                else if (hm.f2.Userstatut.Text == "Vaccine")
                {
                hm.f2.Userstatut.ForeColor = System.Drawing.Color.Blue;
                }
                else if (hm.f2.Userstatut.Text == "Possible")
                {
                hm.f2.Userstatut.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    hm.f2.Userstatut.ForeColor = System.Drawing.Color.Green;
                }
            this.Hide();
            hm.f2.Show();




        }
    }
}
