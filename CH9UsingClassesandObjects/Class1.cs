using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Tax
    {
        //properties
        public string Ssn
        {
            get;
            set;
        }
        public double GrossIncome
        {
            get;
            set;
        }
        public readonly double TaxOwed;
        //constructors
        public Tax(string ssn, double grossIncome)
        {
            double taxRate;
            Ssn = ssn;
            GrossIncome = grossIncome;
            if (grossIncome < 30000)
            {
                taxRate = .15;
            }
            else
            {
                taxRate = .28;
            }
            TaxOwed = grossIncome * taxRate;




        }

    }
}
