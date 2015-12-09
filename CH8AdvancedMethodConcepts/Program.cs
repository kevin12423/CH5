using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an item number or description of item");
            string userInput = "";
            string answer = "";
            int i;
            userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out i))
            {
                answer = GetDetails(userInput);
            }
            else
            {
                answer = GetDetails(i);
            }
            Console.WriteLine(answer);

        }

        static string GetDetails(string input)
        {
            int pos = 0;
            string[] itemDescription = { "enchilada", "Burrito", "Taco", "Tostada" };
            double[] itemPrice = { 2.95, 1.95, 2.25, 3.10 };
            int[] itemNumbers = { 20, 23, 25, 31 };
            string output = "Please enter a valid item number or description";
            for (int x = 0; x < 4; x++)
            {
                if (input == itemDescription[x])
                {
                    pos = x;

                    output = String.Format("{0} - {1} will cost {2}", itemNumbers[pos], itemDescription[pos], itemPrice[pos]);
                }
            }
            return output;


        }
        static string GetDetails(int input)
        {
            int pos = 0;
            string[] itemDescription = { "enchilada", "Burrito", "Taco", "Tostada" };
            int[] itemNumbers = { 20, 23, 25, 31 };
            double[] itemPrice = { 2.95, 1.95, 2.25, 3.10 };
            string output = "Please enter a valid item number or description";
            for (int x = 0; x < 4; x++)

            {
                if (input == itemNumbers[x])
                {
                    pos = x;

                    output = String.Format("{0} - {1} will cost {2}", itemNumbers[pos], itemDescription[pos], itemPrice[pos]);
                }


            }
            return output;

        }
    }
}
