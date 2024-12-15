using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of three points:");

            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            double slope12 = (y2 - y1) / (x2 - x1);
            double slope23 = (y3 - y2) / (x3 - x2);

            if (slope12 == slope23)
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }

        }
    }
}
