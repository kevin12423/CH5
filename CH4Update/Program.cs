using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        //ffvfvfv
        static void Main(string[] args)
        {
            Console.WriteLine("enter r, p, s");
            string play = Console.ReadLine();
            Random ran = new Random();
            int computer = ran.Next(1, 4);
            switch (play)
            {
                case "r":
                    if (computer == 1)
                        Console.WriteLine("you tied they picked rock");
                    if (computer == 2)
                        Console.WriteLine("you lose they picked paper");
                    if (computer == 3)
                        Console.WriteLine("you win they picked scissors");
                    break;
                case "p":
                    if (computer == 1)
                        Console.WriteLine("you win they picked rock");
                    if (computer == 2)
                        Console.WriteLine("you tie they picked paper");
                    if (computer == 3)
                        Console.WriteLine("you lose they picked scissors");
                    break;
                case "s":
                    if (computer == 1)
                        Console.WriteLine("you lose they picked rock");
                    if (computer == 2)
                        Console.WriteLine("you win they picked paper");
                    if (computer == 3)
                        Console.WriteLine("you tie they picked scissors");
                    break;
            }


        }
    }
}
