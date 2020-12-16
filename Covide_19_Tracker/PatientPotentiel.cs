using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Covide_19_Tracker
{
    public class PatientPotentiel : Citoyen
    {
        Laboratoir lab = new Laboratoir();
        private int TestResult;

        public bool Get_Result()
        {
            return lab.ResultValue;
        }

    }
}