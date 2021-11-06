using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.DataFactory
{
    public class SnakeGameBase
    {
        protected static Dictionary<int, int> SnakePositions;
        protected static Dictionary<int, int> LadderPositions;
        protected static Queue<string> GameHistory;
        protected static int DICE_FACES_NUMBER = 6;

        static SnakeGameBase()
        {
            SnakePositions = new Dictionary<int, int>();
            LadderPositions = new Dictionary<int, int>();
            GameHistory = new Queue<string>();
        }

        protected void StoreSnakePositions(List<Snake> snakes)
        {
            foreach (var snakePosition in snakes)
            {
                SnakePositions.Add(snakePosition.StartPosition, snakePosition.EndPosition);
            }
        }

        protected void StoreLadderPositions(List<Ladder> ladders)
        {
            foreach (var ladderPosition in ladders)
            {
                SnakePositions.Add(ladderPosition.StartPosition, ladderPosition.EndPosition);
            }
        }

        protected void SaveOutput(string displayString)
        {
            GameHistory.Enqueue(displayString);
        }
    }
}
