using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= input; i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.Write(i);
            //    }
            //    else
            //    {
            //        Console.Write(" ");
            //    }
            //}

            /*Task 3 Extension*/
            Console.WriteLine("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}\t");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }
            Console.ReadLine();
        }
}    }