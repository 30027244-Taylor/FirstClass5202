using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 76;
            int end = 46;

            Console.WriteLine("Displaying odd numbers between 76 and 46 (descending)");

            while(start>=end)
            {
                if (start % 2 != 0)
                    Console.WriteLine(start);
                start--;
            }
            Console.ReadLine();
        }
    }
}
