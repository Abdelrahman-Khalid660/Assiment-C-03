using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question3
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(Math.Max(num1, num2), num3);
            int minNum = Math.Min(Math.Min(num1, num2), num3);

            Console.WriteLine("Max element = " + maxNum);
            Console.WriteLine("Min element = " + minNum);
        }


    }
}
