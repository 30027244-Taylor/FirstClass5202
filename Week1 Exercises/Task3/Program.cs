using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a  whole number:");
            int num0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another  whole number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a  decimal number:");
            double dec0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another decimal number:");
            double dec1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a string:");
            string str0 = Console.ReadLine();
            Console.WriteLine("Please enter another string:");
            string str1 = Console.ReadLine();

            Console.WriteLine($"Info: \n" +
                $"The two whole numbers are {num0} and {num1}\n" +
                $"The two decimal numbers are {dec0} and {dec1}\n" +
                $"The two strings are {str0} and {str1}");

            Console.ReadLine();
        }
    }
}
