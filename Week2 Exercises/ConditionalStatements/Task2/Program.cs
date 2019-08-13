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
            //My number is 6
            int myNum = 6;

            //Ask the user to guess a number between 1 and 10
            Console.WriteLine("Guess a number between 1 and 10:");
            int userNum = int.Parse(Console.ReadLine());

            //If their number is less than mine
            if(userNum<myNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is incorrect. You guessed too low.");
            }

            //If their number is greater than mine
            else if(userNum>myNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is incorrect. You guessed too high.");
            }

            //If their number is the same as mine
            else if(userNum==myNum)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That is correct!");
            }

            Console.ReadLine();
        }
    }
}
