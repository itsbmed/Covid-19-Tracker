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
           

            if (Check_Result())
            {
                return "Patient";
            }

            else
            {
                return "Normale";
            }
        }

        public bool Check_Result()
        {
            Laboratoir lb = new Laboratoir();

            if (lb.ResultValue)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public bool Get_Result()
        {
            bool pr = Check_Result();
           return pr;
        }

    }
}