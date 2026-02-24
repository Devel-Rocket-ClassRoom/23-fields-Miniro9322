using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class GameCharacter
    {
        private string name;
        private int health;
        private int attack;

        private static int characterCount = 0;

        private readonly int maxHealth = 100;

        private const int MinHealth = 0;

        public GameCharacter(string name, int attack)
        {
            this.name = name;
            this.health = maxHealth;
            this.attack = attack;
            characterCount++;
        }

        public void TakeDamage(int damage)
        {
            health = health - damage;
            if (health < MinHealth)
            {
                health = MinHealth;
            }
            Console.WriteLine(name + "이(가) " + damage + " 데미지를 받음! 남은 체력: " + health);
        }

        public void ShowStatus()
        {
            Console.WriteLine("=== " + name + " ===");
            Console.WriteLine("체력: " + health + "/" + maxHealth);
            Console.WriteLine("공격력: " + attack);
        }

        public static void ShowTotalCharacters()
        {
            Console.WriteLine("총 캐릭터 수: " + characterCount);
        }
    }
}
