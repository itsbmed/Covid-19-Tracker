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

        public void SetColor()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckEmail()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckCni()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckFields()
        {
            throw new System.NotImplementedException();
        }
    }
}