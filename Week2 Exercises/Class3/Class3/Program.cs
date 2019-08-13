using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            //obtain the first number from the user
            Console.WriteLine("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            //obtain the second number from the user
            Console.WriteLine("Please enter another number:");
            double num2 = double.Parse(Console.ReadLine());


            //display the 2 numbers added together
            double result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");

            //display the second number minus first number
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");

            //display the 2 numbers multiplied together
            Console.WriteLine($"{num1} * {num2} = {num1*num2}");

            //display the first number divided by the second number
            Console.WriteLine($"{num1} / {num2} = {num1/num2}");

            Console.ReadLine();
        }
    }
}
