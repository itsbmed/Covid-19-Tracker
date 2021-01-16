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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (proavalue.Text != "")
            {
                Persistance pr = new Persistance();
                Form2 fr2 = new Form2();
                MessageBox.Show(fr2.cnivalue());
                pr.Updates(pora.GetItemText(this.pora.SelectedItem), proavalue.Text, fr2.Usercni.Text);
                this.Close();
                User_Home home = new User_Home();
                home.Show();
            }
            MessageBox.Show("Please Check Your Fields");
        }
    }
}
