﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForConceptsPoo
{
    public class Invoice : IPay
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }


        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id}- {Descripcion}, " +
                $"\n\tQuantity........: {$"{Quantity:N2}",18}" +
                $"\n\tPrice...........: {$"{Quantity:C2}",18}" +
                $"\n\tValue...........: {$"{GetValueToPay():c2}",18}";
        }

    }

}
