using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.Commands
{
    public class DiceRollerCommand
    {
        public DiceRollerCommand(Player player)
        {
            Player = player;
        }

        public Player Player { get; set; }
    }
}
