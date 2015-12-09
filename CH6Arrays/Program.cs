using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int flag2 = 0;
            int userZip = 0;
            int userTime = 0;
            int[] zips = { 262, 414, 608, 715, 815, 920 };
            double[] price = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            Console.WriteLine("Enter your zip code.");
            userZip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of call in minutes");
            userTime = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x <= 5; x++)
            {
                if (userZip == zips[x])
                {
                    flag++;
                    flag2 = x;

                }


            }
            if (flag == 0)
            {
                Console.WriteLine("sorry enter a valid zip code");
            }
            else
            {



                Console.WriteLine("the price for your phone call will be ${0} ", price[flag2] * userTime);

            }
        }
    }
}
