using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Player
    {
        private string name;
        private int health;

        public void ShowStatus()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"체력: {health}");
        }
    }
}
