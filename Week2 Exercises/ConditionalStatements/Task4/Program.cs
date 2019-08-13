using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            if(num1%2==0)
            {
                Console.WriteLine("This number is even.");
            }

            else
            {
                Console.WriteLine("This number is odd.");
            }

            Console.ReadLine();
        }
    }
}
