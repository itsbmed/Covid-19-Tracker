using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Covide_19_Tracker
{
    
    class Persistance
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;


        public String[] Get_Patient(String cni)
        {
            string[] sdr = new string[5];
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
                    sdr[i] = rd[i].ToString();
                }
                return sdr;
            }
        }
    }
}
