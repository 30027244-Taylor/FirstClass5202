using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a distance in miles and I will convert it to kilometres: ");
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"{MilesToKilometres(input)}");

            Console.ReadLine();
        }

        static double MilesToKilometres(double miles)
        {
            double kms = miles * 1.60934;
            return kms;
        }
    }
}
