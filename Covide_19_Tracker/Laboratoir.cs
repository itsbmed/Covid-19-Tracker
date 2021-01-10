using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace Covide_19_Tracker
{
    public class Laboratoir
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;

        public bool ResultValue
        {
            get;
            set;
        }

        public bool Result()
        {
            if (ResultValue == true)
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