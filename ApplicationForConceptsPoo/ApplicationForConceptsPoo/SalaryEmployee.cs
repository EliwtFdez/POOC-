﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForConceptsPoo
{
    public class SalaryEmployee : Employee
    {
        public  decimal Salary { get; set; }


        public override decimal GetValioToPay()
        {
           return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue To Pay..........: {$"{GetValioToPay():C2}",15}";
        }
    }
}