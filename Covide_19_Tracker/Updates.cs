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
                MessageBox.Show(cn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (proavalue.Text != "" && Cn != "")
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
    }
}
