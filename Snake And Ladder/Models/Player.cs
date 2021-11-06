using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.Models
{
    public class Player
    {
        public Player(int playerCount, string input)
        {
            PlayerId = playerCount;
            PlayerName = input;
            CurrentPosition = 0;
        }

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }

        public int CurrentPosition { get; set; }
    }
}
