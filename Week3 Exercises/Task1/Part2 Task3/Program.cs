using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a rectangle made up of # that is 5 high and 7 wide:");
            int height = 5;
            int width = 7;
            string sym = "#";

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
