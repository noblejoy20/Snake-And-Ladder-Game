using Snake_And_Ladder.Models;
using System.Collections.Generic;

namespace Snake_And_Ladder.Commands
{
    public class StoreValuesCommand
    {
        public StoreValuesCommand(List<Snake> snakes, List<Ladder> ladders)
        {
            Snakes = snakes;
            Ladders = ladders;
        }
        public List<Snake> Snakes { get; set; }
        public List<Ladder> Ladders { get; set; }
    }
}