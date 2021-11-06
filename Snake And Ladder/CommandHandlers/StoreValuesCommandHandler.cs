using Snake_And_Ladder.Commands;
using Snake_And_Ladder.DataFactory;
using Snake_And_Ladder.Interfaces;
using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.CommandHandlers
{
    public class StoreValuesCommandHandler : SnakeGameBase, IStoreValueCommand
    {

        public void StoreData(StoreValuesCommand store)
        {
            StoreSnakePositions(store.Snakes);
            StoreLadderPositions(store.Ladders);
        }
    }
}
