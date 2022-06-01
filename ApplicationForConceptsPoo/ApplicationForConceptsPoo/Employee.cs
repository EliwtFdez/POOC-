﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForConceptsPoo
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public Boolean IsActive { get; set; }


        public abstract decimal GetValioToPay();

        public override string ToString()
        {
            return $"{Id}- {FirstName} {LastName}," +
                $" Birth: {BirthDate}," +
                $" Hiring: {HiringDate}, " +
                $"Is Active {IsActive}";
        }

    }
}