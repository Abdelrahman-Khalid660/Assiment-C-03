using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question22
    {
        static void Main(string[] args)
        {
            string Abdo1 = "Hello";
            string Abdo2 = Abdo1;

            Abdo2 = "World";

            Console.WriteLine("Value 1 : " + Abdo1);
            Console.WriteLine("Value 2 : " + Abdo2);
        }
    }
}

// The Output Will be :
// Value 1: World
// Value 2 : World
//When Abdo2 is assigned the value of Abdo1, both variables refer to the same object
//Modifying Abdo2 actually modifies the object that both Abdo1 and Abdo2
    

