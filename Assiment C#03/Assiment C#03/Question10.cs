using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_C_03.Assiment_C_03
{
    internal class Question10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Marks of Five Subjects");
            int[] Marks = new int[5]
            for (int i = 0; i < 5; i++)
            {
                Marks[i] = int.Parse(Console.ReadLine());
            }

            int TotalMarks = 0;
            foreach (int mark in Marks) 
            { 
                TotalMarks += mark;
            }

            int average = TotalMarks / Marks.Length;
            int Percentage = (TotalMarks / 500) * 100;

            Console.WriteLine("Total marks = " + TotalMarks);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + Percentage);
        }
    }
}
