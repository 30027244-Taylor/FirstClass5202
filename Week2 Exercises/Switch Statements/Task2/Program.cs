using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price of fruit per kilogram...");
            Console.WriteLine("Please enter a fruit: ");
            string fruit = Console.ReadLine();
            string response;
            switch (fruit)
            {
                case "apples":
                    response = "\napples:\t $1.25/kg";
                    break;
                case "bananas":
                   response = "\nbananas:\t $3.15/kg";
                    break;
                case "kiwifruit":
                    response = "\nkiwifruit:\t $4.65/kg";
                    break;
                case "oranges":
                    response = "\noranges:\t $2.75/kg";
                    break;
                default:
                    response = "\nerror, unknown fruit...";
                    break;
            }

            Console.WriteLine(response);

            Console.ReadLine();
        }
    }
}
