using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForConceptsPoo
{
    public class HourlyEmployee : Employee
    {

        public float Hours { get; set; }
        public decimal HourValue { get; set; }


        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours.................: {Hours:N2}" +
                $"\n\tHours Value...........: {HourValue:C2}" +
                $"\n\tValue To Pay..........: {GetValueToPay():C2}";
        }

    }
}
