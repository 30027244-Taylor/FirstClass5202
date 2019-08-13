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
            //Obtain first name from the user
            Console.WriteLine("Please enter your first name: ");
            string fname = Console.ReadLine();

            //Obtain last name from the user
            Console.WriteLine("Please enter your last name: ");
            string lname = Console.ReadLine();

            //Display first and last name together
            Console.WriteLine($"{fname} {lname}");

            Console.ReadLine();




        }
    }
}
