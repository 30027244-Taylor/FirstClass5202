using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Random rand = new Random();
            int myNum = rand.Next(1, 10);

            do
            {
                Console.Write("Guess a number between 1 and 10:");
                counter++;
                int userNum = int.Parse(Console.ReadLine());
                if (userNum == myNum)
                {
                    break;
                }
                else
                {
                    Console.Write("That is incorrect, press enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (true);

            Console.WriteLine($"That is correct! You guessed {counter} times");
            Console.ReadLine();
        }
    }
}
