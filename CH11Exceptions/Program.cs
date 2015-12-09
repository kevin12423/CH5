using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MortgageClient
    {
        static void Main(string[] args)
        {
            string name;
            double credit = 0;
            Console.WriteLine("enter a name:");
            name = Console.ReadLine();
            Mortgage test = new Mortgage(name);



            do
            {
                try
                {

                    Console.WriteLine("Enter a credit score:");
                    credit = double.Parse(Console.ReadLine());



                }
                catch (ArgumentException)
                {
                    Console.WriteLine("not approved");

                }
            }
            while (test.EnterCreditScore(credit));

        }
    }
}
}
