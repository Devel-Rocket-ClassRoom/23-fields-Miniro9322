using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Player3
    {
        private string name;
        public static int totalCount = 0;

        public Player3(string name)
        {
            this.name = name;
            totalCount++;
            Console.WriteLine(this.name);
        }
    }
}
