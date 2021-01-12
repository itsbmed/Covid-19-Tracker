using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace Covide_19_Tracker
{
    public class Citoyen
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;
        private string fullname;
        private string cni;
        private string adress;
        private string date;
        private string genre;
        private string phone;
        private string statut;
        private String color;


        public String Adress
        {
            get { return adress; }
            set { adress = value; }

        }

        public String Cni
        {
            get { return cni; }
            set { cni = value; }

        }

        public String Date
        {
            get { return date; }
            set { date = value; }

        }

        public String Genre
        {
            get { return genre; }
            set { genre = value; }

        }

        public String FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }

        }

        public String Statut
        {
            get { return statut; }
            set {statut = value; }

        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public void SetColor()
        {
            Laboratoir lb = new Laboratoir();
            if (lb.ResultValue)
            {
                color = "Red";
            }
            else
            {
                color = "Normal";
            }
        }

        public bool CheckPhone(String  em)
        {
            if (em.Trim() != "" && em.Length == 10)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool CheckCni(String cn)
        {
            if (cn.Trim() != "" && cn.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void insertdata(String Fn,String Cn,String Ad,String Ph, String Bd,String St,String Gn,String Cl)
        {
            if (CheckCni(Cni) && CheckPhone(Phone) && CheckFields(FullName,Adress,Statut,Genre,Date))
            {
                using (SqlConnection cnx = new SqlConnection(connectionString)) 
                {
                    String Query = "INSERT INTO citoyens(CNI,Fullname,Adress,Phone,Statut,Bdate,Genre,Color) " +
                    "VALUES('" + Cn + "','" + Fn + "','" + Ad + "','" + Ph + "','" + St + "','" + Bd + "','" + Gn + "','" + Cl + "')";

                    SqlCommand cmd = new SqlCommand(Query, cnx);
                    if (cnx.State == System.Data.ConnectionState.Open)
                        cnx.Close();
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Please Check The Fields");
            }
           
        }
        public bool CheckFields(String fn,String ad,String St,String Gr,String Dt)
        {
            if (fn.Trim() != "" && ad.Trim() != "" && St.Trim() != "" && Gr.Trim() != "" && Dt.Trim() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}