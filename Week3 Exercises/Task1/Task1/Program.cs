using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int finish = 7;

            Console.WriteLine("N\t10*N\t100*N\t1000*N");


            Console.WriteLine("\n>>> for loop <<<");

            for(int i = start; i <= finish; i++) //between 3 and 7, it will output the equations below
            {
                Console.WriteLine($"{i}\t{i * 10}\t{i * 100}\t{i * 1000}");
            }

            Console.WriteLine("\n>>> while loop <<<");
            while (start<=finish) //between 3 and 7 it will output the equations as well
            {
                Console.WriteLine($"{start}\t{start * 10}\t{start * 100}\t{start * 1000}");
                start++; //this ensures that we get all the numbers in between 3 and 7
            }

            start = 3; //we have to redefine start as it equals 7 after the loop above
            Console.WriteLine("\n>>> do/while loop <<<");
            do
            {
                Console.WriteLine($"{ start}\t{ start * 10}\t{ start * 100}\t{ start * 1000}");
                start++;

            } while (start <= finish);

            Console.WriteLine("Task 1 completed. Press enter to exit...");
            Console.ReadLine();
        }
    }
}
