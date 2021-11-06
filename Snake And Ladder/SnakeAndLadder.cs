using Snake_And_Ladder.Models;
using Snake_And_Ladder.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_And_Ladder
{
    public class SnakeAndLadder
    {
        public static void Main(string[] args)
        {
            var inputService = new InputService();
            var gameService = new GameService();

            Console.WriteLine("Welcome to Snake and Ladder game\n");

            var snakes = inputService.GetSnakes();
            var ladders = inputService.GetLadders();
            var players = inputService.GetPlayers();

            Console.WriteLine("Lets Start the game.\n");

            gameService.StoreGameValues(snakes, ladders);

            gameService.StartGame(players);

        }
    }
}
