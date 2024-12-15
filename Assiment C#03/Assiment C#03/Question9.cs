using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter The Power: ");
            int pw = int.Parse(Console.ReadLine());
            

            int result = Math.Pow(num, pw);
            Console.WriteLine(result);
        }
    }
}
