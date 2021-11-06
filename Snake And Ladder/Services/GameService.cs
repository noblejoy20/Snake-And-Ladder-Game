using Snake_And_Ladder.CommandHandlers;
using Snake_And_Ladder.Interfaces;
using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using Snake_And_Ladder.Commands;

namespace Snake_And_Ladder.Services
{
    public class GameService
    {
        private readonly IStoreValueCommand _storeValueCommand;
        private readonly IDiceRollerCommand _diceRollerCommand;
        private readonly IDisplayCommand _displayCommand;
        private bool _flag;
        public GameService()
        {
            _storeValueCommand = new StoreValuesCommandHandler();
            _diceRollerCommand = new DiceRollerCommandHandler();
            _displayCommand = new DisplayCommandHandler();
            _flag = true;
        }

        public void StoreGameValues(List<Snake> Snakes,List <Ladder> Ladders)
        {
            var cmd = new StoreValuesCommand(Snakes, Ladders);
            _storeValueCommand.StoreData(cmd);
        }

        public void StartGame(List<Player> players)
        {
            while (_flag)
            {
                foreach (var player in players)
                {
                    bool result = _diceRollerCommand.RollDice(player);
                    if (!result)
                    {
                        _displayCommand.DisplayGameHistory();
                        return;
                    }
                }
            }
        }
    }
}
