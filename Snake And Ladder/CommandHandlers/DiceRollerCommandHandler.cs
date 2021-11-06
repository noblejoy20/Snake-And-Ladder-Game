using Snake_And_Ladder.DataFactory;
using Snake_And_Ladder.Interfaces;
using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.CommandHandlers
{
    public class DiceRollerCommandHandler : SnakeGameBase, IDiceRollerCommand
    {
        private readonly Random randomNumber; 
        public DiceRollerCommandHandler()
        {
            randomNumber = new Random();
        }

        public bool RollDice(Player player)
        {
            int rolledValue = randomNumber.Next(1, DICE_FACES_NUMBER+1);
            int currentPosition = player.CurrentPosition;

            if(SnakePositions.ContainsKey(player.CurrentPosition + rolledValue))
            {
                player.CurrentPosition = SnakePositions[player.CurrentPosition + rolledValue];
            }
            else if(LadderPositions.ContainsKey(player.CurrentPosition + rolledValue))
            {
                player.CurrentPosition = LadderPositions[player.CurrentPosition + rolledValue];
            }
            else
            {
                player.CurrentPosition += rolledValue;
            }

            ShowValue(rolledValue, currentPosition, player);

            if (player.CurrentPosition >= 100)
            {
                GameHistory.Enqueue($"{player.PlayerName} wins the game");
                return false;
            }
            return true;
            
        }

        private void ShowValue(int rolledValue, int currentPosition, Player player)
        {
            var displayString = String.Format("{0} rolled a {1} and moved from {2} to {3}", player.PlayerName, rolledValue, currentPosition, player.CurrentPosition);
            SaveOutput(displayString);
        }

        
    }
}
