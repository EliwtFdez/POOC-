using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForConceptsPoo
{
     public class CommissionEmployee : Employee
    {
        public float CommissionPorcentaje { get; set; }

        public decimal Sales { get; set; }  



         public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPorcentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommision Porcentaje: {CommissionPorcentaje:P2}" +
                $"\n\tSale..................: {Sales:p2}"+
                $"\n\tValue To Pay..........: {GetValueToPay():C2}";
        }

    }

}

