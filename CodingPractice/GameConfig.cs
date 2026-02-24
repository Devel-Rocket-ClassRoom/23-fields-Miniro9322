using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class GameConfig
    {
        private readonly string version = "1.0.0";
        private int maxPlayers;

        public GameConfig()
        {
            maxPlayers = 4;
        }

        public void ShowConfig()
        {
            Console.WriteLine($"버전: {version}");
            Console.WriteLine($"최대 플레이어: {maxPlayers}");
        }
    }
}
