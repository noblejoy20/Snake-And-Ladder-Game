using Snake_And_Ladder.DataFactory;
using Snake_And_Ladder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.CommandHandlers
{
    public class DisplayCommandHandler : SnakeGameBase, IDisplayCommand
    {
        public void DisplayGameHistory()
        {
            while (GameHistory.Count > 0)
            {
                Console.WriteLine(GameHistory.Dequeue());
            }
        }
    }
}
