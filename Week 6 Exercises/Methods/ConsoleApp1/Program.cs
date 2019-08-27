using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{SignChange(num1)}");

            Console.ReadLine();
        }

        static int SignChange(int userInput)
        {
            int total = (userInput * -1);
            return total;
        }
    }
}
