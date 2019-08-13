using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Alt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can also do it like this:
            Console.WriteLine("Calculator");
            Console.WriteLine("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an operator (+, -, * or /) :");
            string oper = Console.ReadLine();
            double result = 0;

            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"{num1} {oper} {num2} = {result}");

            Console.ReadLine();
        }
    }
}
