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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Searchbox.Text.Length == 8)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                Persistance pr = new Persistance();

                f2.Username.Text = pr.Get_Patient(Searchbox.Text)[1];
                f2.Usercni.Text = pr.Get_Patient(Searchbox.Text)[0];
                f2.Userage.Text = pr.Get_Patient(Searchbox.Text)[5];
                f2.Userphone.Text = pr.Get_Patient(Searchbox.Text)[3];
                f2.Useradress.Text = pr.Get_Patient(Searchbox.Text)[2];
                f2.Userstatut.Text = pr.Get_Patient(Searchbox.Text)[4];

                if (f2.Userstatut.Text == "Patient")
                {
                    f2.Userstatut.ForeColor = System.Drawing.Color.Red;
                }
                else if (f2.Userstatut.Text == "Vaccine")
                {
                    f2.Userstatut.ForeColor = System.Drawing.Color.Blue;
                }
                else if (f2.Userstatut.Text == "Possible")
                {
                    f2.Userstatut.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    f2.Userstatut.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                MessageBox.Show("CNI PAS VALIDE");
            }


        }

        private void User_Home_Load(object sender, EventArgs e)
        {
            Persistance pr = new Persistance();
            Patientbox.Text = pr.Get_Data(Searchbox.Text)[0];
            Vaccinebox.Text = pr.Get_Data(Searchbox.Text)[1];
            Possiblebox.Text = pr.Get_Data(Searchbox.Text)[2];
            Normalebox.Text = pr.Get_Data(Searchbox.Text)[3];
        }
    }
}