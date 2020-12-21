using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Covide_19_Tracker
{
    public class Citoyen
    {
        private string nom;
        private string prenom;
        private string cni;
        private string adress;
        private string date;
        private string genre;
        private string phone;
        private int field;
        private string statut;
        private int id;

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

        public int Nom
        {
            get;
            set;
        }

        public int Phone
        {
            get;
            set;
            
        }

        public int Prenom
        {
            get;
            set;
           
        }

        public int Statut
        {
            get;
            set;
            
        }

        public int Id
        {
            get => default;
            set
            {
            }
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