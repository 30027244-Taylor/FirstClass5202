using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Please enter a number from 1 to 7: ");
            int num1 = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"That number is {DayName(num1, days)}");

            Console.ReadLine();
        }

        static string DayName(int input, string[] days)
        {
            return days[input-1];
        }
    }
}
