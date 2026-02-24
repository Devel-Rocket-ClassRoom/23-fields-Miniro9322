using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Schedule
    {
        private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        public void PrintWeekDays()
        {
            for(int i  = 0; i < days.Length; i++)
            {
                Console.Write($"{days[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
