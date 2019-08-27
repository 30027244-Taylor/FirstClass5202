using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the cash amount: ");
            string input = Console.ReadLine();
            char[] userInput = input.ToCharArray();
            int last = userInput[userInput.Length - 1];

            Console.WriteLine($"You need to round {RoundUpOrDown(last)}");

            Console.ReadLine();
        }

        static string RoundUpOrDown(int input)
        {
            string result = "";
            switch (input)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        result = "down";
                        break;
                    }
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        result = "up";
                        break;
                    }
            }
            return result;
        }
    }
}
