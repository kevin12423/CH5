using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {

            display(calculate(drawer(), wood1()));
        }
        static int drawer()
        {
            Console.WriteLine("Welcome enter the number of drawers you would like");
            int numDrawer = Convert.ToInt32(Console.ReadLine());
            return (numDrawer);

        }
        static char wood1()
        {
            Console.WriteLine("enter the type of wood you would like");
            Console.WriteLine("enter M: for mahogany, O: for oak, and P: for pine");
            char typeWood = Convert.ToChar(Console.ReadLine());
            return (typeWood);
        }
        static double calculate(int numDrawers, char woodType)
        {
            double total = numDrawers * 30;
            if (woodType == 'p')
            {
                total = total + 100;
                Console.WriteLine("the total is {0} ", total.ToString("C"));


            }
            if (woodType == 'm')
            {
                total = total + 180;
                Console.WriteLine("the total is {0} ", total.ToString("C"));

            }
            if (woodType == 'o')
            {
                total = total + 140;
                Console.WriteLine("the total is {0} ", total.ToString("C"));

            }
            return total;

        }
        static void display(double total)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("We make desk: ");
            Console.WriteLine("Pine desks are $100");
            Console.WriteLine("Oak desks are $140");
            Console.WriteLine("Mahogany desks are $180");
            Console.WriteLine("Each drawer is an extra $30");
            Console.WriteLine("your total is {0}", total.ToString("C"));




        }
    }
}

