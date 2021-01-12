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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Persistance pr = new Persistance();
            Patientbox.Text = pr.Get_Data(Searchbox.Text)[0];
            Vaccinebox.Text = pr.Get_Data(Searchbox.Text)[1];
            Possiblebox.Text = pr.Get_Data(Searchbox.Text)[2];
            Normalebox.Text = pr.Get_Data(Searchbox.Text)[3];
            

           
        }
    }
}
