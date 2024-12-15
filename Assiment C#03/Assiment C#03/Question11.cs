using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            int daysInMonth;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 2:
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;


                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }

            Console.WriteLine("Number of days in the month: " + daysInMonth);

        }
    }
}
