using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace Covide_19_Tracker
{
    public class Patient : Citoyen
    {
        String connectionString = ConfigurationManager.ConnectionStrings["CnxToSql"].ConnectionString;
        Laboratoir lab = new Laboratoir();
        private bool result;
        private string statut;

        public bool Result
        {
            get;
            set;
            
        }

        public string Statut
        {
            get;
            set;
        }

        public String Check_Status()
        {
            throw new System.NotImplementedException();
        }

        public bool Check_Result()
        {
            throw new System.NotImplementedException();
        }
        public bool Get_Result()
        {
           return lab.ResultValue;
        }

    }
}