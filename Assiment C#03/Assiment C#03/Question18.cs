using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the time taken to complete the task (in hours): ");
            double timeTaken = double.Parse(Console.ReadLine());

            if (timeTaken >= 2 && timeTaken < 3)
            {
                Console.WriteLine("Highly Efficient!");
            }
            else if (timeTaken >= 3 && timeTaken < 4)
            {
                Console.WriteLine("Increase your speed");
            }
            else if (timeTaken >= 4 && timeTaken < 5)
            {
                Console.WriteLine("Training required to enhance speed");
            }
            else if (timeTaken >= 5)
            {
                Console.WriteLine("You are required to leave the company");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive time");
            }
        }
    }
}
