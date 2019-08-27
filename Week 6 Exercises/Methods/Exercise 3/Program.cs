using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"The circle's circumference is {CircleCircumference(input)}");
            Console.WriteLine($"The circle's area is {CircleArea(input)}");
            Console.ReadLine();
        }

        static double CircleCircumference(double rad)
        {
            double circ = 2 * 3.1416 * rad;
            return circ;
        }

        static double CircleArea(double rad)
        {
            double area = 3.1416 * rad * rad;
            return area;
        }
    }
}
