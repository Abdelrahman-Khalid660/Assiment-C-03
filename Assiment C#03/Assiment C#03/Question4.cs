using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question4
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if (num % 3 == 0) {
                Console.WriteLine("Odd");
            }




        }


    }
}
