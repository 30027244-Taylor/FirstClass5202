using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int finish = 10;

            Console.WriteLine("Number\tSquare\tCube");

            Console.WriteLine("---for loop---");
            for(int i = start; i<=finish; i++)
            {
                Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }

            Console.WriteLine("---while loop---");
            while(start<=finish)
            {
                Console.WriteLine($"{start}\t{start * start}\t{start * start * start}");
                start++;
            }

            start = 0;
            Console.WriteLine("---do/while loop---");
            do
            {
                Console.WriteLine($"{start}\t{start * start}\t{start * start * start}");
                start++;
            } while (start <= finish);

            Console.ReadLine();
        }
    }
}
