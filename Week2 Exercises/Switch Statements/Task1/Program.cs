using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //fbird is my favourite bird
            string fbird = "sparrow";

            //bird is their guess
            Console.WriteLine("Try and guess my favourite bird...");
            Console.Write("Please enter a type of bird: ");
            string bird = Console.ReadLine().ToUpper();
            bird = bird.ToLower();

            switch (bird)
            {
                case "sparrow":
                    Console.WriteLine($"Correct! The {fbird} is my favourite bird.");
                    break;
                case "pigeon":
                case "kea":
                case "parrot":
                case "kereru":
                    Console.WriteLine($"Incorrect. The {bird} is not my favourite bird.");
                    break;
                default:
                    Console.WriteLine($"Something went wrong with your answer.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
