using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.Interfaces
{
    public interface IDiceRollerCommand
    {
        bool RollDice(Player player);
    }
}
