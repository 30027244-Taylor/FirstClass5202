using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            //Obtain a number from the user
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            //Obtain another number from the user
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            //If the first number is larger than the second display that it is larger
            if(num1>num2)
            {
                Console.WriteLine($"{num1} is larger");
            }

            //If the second number is larger, display that it is larger
            if(num1<num2)
            {
                Console.WriteLine($"{num2} is larger");
            }

            //If the numbers are the same, display that they are equal
            if(num1==num2)
            {
                Console.WriteLine("These numbers are equal");
            }

            Console.ReadLine();
        }
    }
}
