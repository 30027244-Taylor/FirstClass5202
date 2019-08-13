using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 3-letter palindrome, beginning with the first letter: ");
            string l1 = Console.ReadLine();

            Console.WriteLine("Please enter the second letter: ");
            string l2 = Console.ReadLine();
            if(l2 == "a" || l2 == "e" || l2 == "i" || l2 == "o" || l2 == "u")
            {
                Console.WriteLine("Please enter the third letter: ");
                string l3 = Console.ReadLine();

                if(l1==l3)
                {
                    Console.WriteLine($"{l1} {l2} {l3} is a palindrome");
                }
            }
            else
            {
                Console.WriteLine("There is an issue with your word");
            }

            Console.ReadLine();

        }
    }
}
