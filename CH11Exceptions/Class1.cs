using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Mortgage
    {
        //properties
        public string Name { get; set; }
        public double CreditScore { get; set; }
        public Mortgage(string name)
        {
            Name = name;


        }
        public bool EnterCreditScore(double credit)
        {
            bool resultRange = true;
            if (credit >= 300 && credit <= 850)
            {
                return resultRange = true;
            }
            else if (credit >= 300 || credit <= 850)
            {
                resultRange = false;
                throw new ArgumentException();
            }
            return resultRange;




        }
    }
}

