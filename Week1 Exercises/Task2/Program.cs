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
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine(); //user's name

            Console.WriteLine("Please enter your address:");
            string address = Console.ReadLine(); //user's address

            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine()); //user's age

            Console.WriteLine("Please enter your email address:");
            string email = Console.ReadLine(); // user's email

            Console.WriteLine("Please enter your 4-digit pin number:");
            int pin = int.Parse(Console.ReadLine()); //user's pin

            Console.WriteLine("Please check that the information you have entered is correct:");
            Console.WriteLine($"\nName: {name}\nAddress: {address}\nAge: {age}\nEmail: {email}\nPin: {pin}"); //\n writes the next part immediately after on a new line, optimises space

            Console.ReadLine();
        }
    }
}
