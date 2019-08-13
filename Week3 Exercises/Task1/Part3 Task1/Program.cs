using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can I count to 50? Let's see...");

            for (int i = 1; i <= 50; i++)
            {

                Console.Write($"{i} ");
                if (i % 10 == 0)
                { Console.WriteLine(); }
            }
            Console.ReadLine();
        }
    }
}
