using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int temp;

            Console.Write("How many Fibonacci numbers would you like? ");
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n1}\n{n2}");
            for(int i = 2; i < counter; i++)
            {
                temp = n1 + n2;
                Console.WriteLine(temp);
                n1 = n2;
                n2 = temp;
            }
            Console.ReadLine();
        }
    }
}
