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
            Console.WriteLine("Please enter your grade: ");
            int score = int.Parse(Console.ReadLine());
            string grade="";

            if (score <= 100 && score >= 90)
            {
                grade = "A+";
            }
            else if (score <= 89 && score >= 80)
            {
                grade = "A";
            }
            else if (score <= 79 && score >= 70)
            {
                grade = "B+";
            }
            else if (score <= 69 && score >= 60)
            {
                grade = "B";
            }
            else if (score <= 59 && score >= 50)
            {
                grade = "C";
            }
            else if (score <= 49 && score >= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"Your score of {score} gives you a grade {grade}");

            Console.ReadLine();
        }
    }
}
