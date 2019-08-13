using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program will generate a random number between 1 and 10
            Random rand = new Random();
            int myNum = rand.Next(1,10);

            //Ask the user to guess a number between 1 and 10
            Console.WriteLine("Guess a number between 1 and 10:");
            int userNum = int.Parse(Console.ReadLine());

            //If their number is less than mine
            if (userNum < myNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"That is incorrect. The correct number was {myNum}.");
            }

            //If their number is greater than mine
            else if (userNum > myNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"That is incorrect. The correct number was {myNum}");
            }

            //If their number is the same as mine
            else if (userNum == myNum)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That is correct!");
            }

            Console.ReadLine();
        }
    }
}
