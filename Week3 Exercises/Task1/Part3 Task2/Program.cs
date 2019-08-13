using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            bool loop = true;
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Please enter a number: ");
            //    total = total + int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Total = {total}");

            //Task 2 Extension
            do
            {
                Console.WriteLine("Please enter a number: ");
                total = total + int.Parse(Console.ReadLine());

                Console.WriteLine("Would you like to add another number (y/n): ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    loop = false;
                } 

            } while (loop=true);
            Console.WriteLine($"Total = {total}");
        }
        
    }
}
