using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForConceptsPoo
{
    internal class BaseCommisionEmployee : CommissionEmployee
    {

        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                  $"\n\tBase.................: {$"{Base:C2}",18}";   
        }


    }
}
