using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight in kgs: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm: ");
            double heightCm = double.Parse(Console.ReadLine());

            double heightM = heightCm / 100;
            Console.WriteLine($"Your BMI is {BMI(weight, heightM)}.");

            Console.ReadLine();
        }

        static double BMI(double input1, double input2)
        {
            double total = input1 / (input2 * input2);
            return total;
        }
    }
}
