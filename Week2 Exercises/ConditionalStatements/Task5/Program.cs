using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your 4 digit pin: ");
            int pin = int.Parse(Console.ReadLine());
            if(pin>1000 || pin<9999)
            {
                Console.WriteLine("Please enter your pin number again: ");
                int pin2 = int.Parse(Console.ReadLine());
                if(pin == pin2)
                {
                    Console.WriteLine("Pin Accepted...");
                }
                else
                {
                    Console.WriteLine("Your pins did not match");
                }
            }
            else
            {
                Console.WriteLine("Your pin did not meet requirements");
            }
            Console.ReadLine();
        }
    }
}
