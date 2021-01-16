using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace Covide_19_Tracker
{
    
    class Persistance
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;


        public String[] Get_Patient(String cni)
        {
            string[] sdr = new string[8];
            int i = 0;
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                String Query = "SELECT * FROM citoyens WHERE CNI=  '" + cni + "' ";

                SqlCommand cmd = new SqlCommand(Query, cnx);
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    sdr[0] = rd[0].ToString();
                    sdr[1] = rd[1].ToString();
                    sdr[2] = rd[2].ToString();
                    sdr[3] = rd[3].ToString();
                    sdr[4] = rd[4].ToString();
                    sdr[5] = rd[5].ToString();
                    sdr[6] = rd[6].ToString();
                    sdr[7] = rd[7].ToString();
                    
                }
                return sdr;
            }
        }
        public void Updates(String pora,String poravalue,String cni)
        {
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                String Query = "UPDATE citoyens SET "+ pora + " =  '" + poravalue + "' WHERE CNI =  '" + cni + "'";


                SqlCommand cmd = new SqlCommand(Query, cnx);
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted!");
                

            }
            
        }
        public String[] Get_Data(String cni)
        {
            string[] gt = new string[4];
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                String Query1 = "SELECT Count(Statut) AS Ct FROM citoyens Where Statut = 'Patient'";
                String Query2 = "SELECT Count(Statut) AS Ct FROM citoyens Where Statut = 'Vaccine'";
                String Query3 = "SELECT Count(Statut) AS Ct FROM citoyens Where Statut = 'Possible'";
                String Query4 = "SELECT Count(Statut) AS Ct FROM citoyens Where Statut = 'Normal'";

                SqlCommand cmd1 = new SqlCommand(Query1, cnx);
                SqlCommand cmd2 = new SqlCommand(Query2, cnx);
                SqlCommand cmd3 = new SqlCommand(Query3, cnx);
                SqlCommand cmd4 = new SqlCommand(Query4, cnx);

                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                SqlDataReader rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    r1 = rd1["ct"].ToString();

                }
                cnx.Close();
                cnx.Open();
               
                
                SqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    r2 = rd2["ct"].ToString();
                }
                cnx.Close();
                cnx.Open();
                SqlDataReader rd3 = cmd3.ExecuteReader();


                while (rd3.Read())
                {
                    r3 = rd3["ct"].ToString();
                }
                cnx.Close();
                cnx.Open();
                SqlDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    r4 = rd4["ct"].ToString();
                }
                gt[0] = r1; gt[1] = r2; gt[2] = r3; gt[3] = r4;
                return gt;
            }
        }
    }
}
