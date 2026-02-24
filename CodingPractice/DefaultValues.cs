using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class DefaultValues
    {
        private int number;
        private bool flag;
        private string text;

        public void ShowDefault()
        {
            Console.WriteLine($"number: {number}");
            Console.WriteLine($"flag: {flag}");
            if(text == null)
            {
                Console.WriteLine($"text: null");
            }
            else
            {
                Console.WriteLine($"text: {text}");
            }
        }
    }
}
