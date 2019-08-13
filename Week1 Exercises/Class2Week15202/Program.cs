using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2Week15202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}, nice to meet you.", name, lname);
            Console.ReadLine();
        }
    }
}
