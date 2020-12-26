using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace Covide_19_Tracker
{
    public class PatientPotentiel : Citoyen
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;
        Laboratoir lab = new Laboratoir();
        private int TestResult;

        public bool Get_Result()
        {
            return lab.ResultValue;
        }

    }
}