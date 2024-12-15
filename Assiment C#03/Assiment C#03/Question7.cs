using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Number : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 12; i++) {

                Console.Write(num * i);
        }
            Console.WriteLine();
    }
}
