using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class TaxClient
    {
        static void Main(string[] args)
        {
            Tax[] workers = new Tax[3];
            string ssn = "";
            double income;

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Enter a SSN");
                ssn = Console.ReadLine();
                Console.WriteLine("Enter Income");
                income = Convert.ToDouble(Console.ReadLine());
                workers[i] = new Tax(ssn, income);
                Console.WriteLine("you need to pay:");
                Console.WriteLine(workers[i].TaxOwed.ToString("C"));

            }
        }
    }
}
