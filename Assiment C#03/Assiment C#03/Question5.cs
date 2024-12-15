using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Letter: ");
            char letter = char.Parse(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'o' ||
                letter == 'I' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else 
            {
                Console.WriteLine("consonant");
            }
        }

        }
}
