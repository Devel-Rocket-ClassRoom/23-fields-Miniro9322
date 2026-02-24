using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Counter
    {
        public static int count = 0;

        public Counter()
        {
            count++;
            Console.WriteLine($"현재 카운트: {count}");
        }
    }
}
