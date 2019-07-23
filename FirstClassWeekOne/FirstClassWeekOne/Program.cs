using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassWeekOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}, nice to meet you", name, lname);
            Console.WriteLine("Hello" + " " + name + " " + lname + "nice to meet you");
            Console.WriteLine("Hello {name} {lname}, nice to meet you");
            Console.ReadLine();
        }
    }
}
