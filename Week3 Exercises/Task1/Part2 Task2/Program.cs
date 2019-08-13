using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a character/symbol: ");
            string sym = Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            for(int i=1; i<=num1; i++)
            {
                Console.Write(sym);
            }

            Console.WriteLine();
            int counter = 0;
            while(counter<num1)
            {
                Console.Write(sym);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
