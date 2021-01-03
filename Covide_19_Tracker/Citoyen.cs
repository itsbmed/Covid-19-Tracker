using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
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
        private int color;


        public int Adress
        {
            get ;
            set;
            
        }

        public int Cni
        {
            get ;
            set;
            
        }

        public int Date
        {
            get;
            set;
            
        }

        public int Genre
        {
            get ;
            set;
            
        }

        public int FullName
        {
            get;
            set;
        }

        public int Phone
        {
            get;
            set;
            
        }

       

        public int Statut
        {
            get;
            set;
            
        }

        public int Color
        {
            get;
            set;
        }

        public void SetColor()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckEmail(String  em)
        {
            if (em.Trim() != "")
            {
                return false;
            }
            else {
                return true;
            }
        }

        public bool CheckCni(String cn)
        {
            if (cn.Trim() != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void insertdata(String Fn,String Cn,String Ad,String Ph, String Bd,String St,String Gn,String Cl)
        {
            
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                String Query = "INSERT INTO citoyens(CNI,Fullname,Adress,Phone,Statut,Bdate,Genre,Color) " +
                "VALUES('" + Cn + "','" + Fn + "','" + Ad + "','" + Ph + "','" + St + "','" + St + "','" + Bd + "','" + Gn + "','" + Cl + "')";

                SqlCommand cmd = new SqlCommand(Query, cnx);
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            


        }
        public bool CheckFields(String fn,String ad,String ph,String st)
        {
            if (fn.Trim() != "" && ad.Trim() != "" && ph.Trim() != "" && st.Trim() != "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}