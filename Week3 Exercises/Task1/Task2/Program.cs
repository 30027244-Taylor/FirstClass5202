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
            int start = 1;
            int finish = 10;

            Console.WriteLine("Please enter a number: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n>>>for loop<<<");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n1} = {i*n1}");
            }

            Console.WriteLine("\n>>>while loop<<<");
            while(start<=finish)
            {
                Console.WriteLine($"{start} x {n1} = {start * n1}");
                start++;
            }

            start = 1;
            Console.WriteLine("\n>>>do/while<<<");
            do
            {
                Console.WriteLine($"{start} x {n1} = {start * n1}");
                start++;
            } while (start <= finish);

            Console.ReadLine();
        }
    }
}
