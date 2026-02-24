using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Example
    {
        private const double Pi = 3.14159;
        private readonly DateTime createdAt = DateTime.Now;

        public void ShowValues()
        {
            Console.WriteLine($"원주율: {Pi}");
            Console.WriteLine($"생성 시간: {createdAt}");
        }
    }
}
