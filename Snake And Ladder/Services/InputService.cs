using Snake_And_Ladder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake_And_Ladder.Services
{
    public class InputService
    {
        public List<Snake> GetSnakes()
        {
            List<Snake> Snakes = new List<Snake>();
            Console.WriteLine("Please give the input for the number of snakes");
            int snakesNumber = Int32.TryParse(Console.ReadLine(), out int value) ? value : 0;
            if (snakesNumber == 0)
            {
                throw new InvalidOperationException("Please enter a valid number");
            }
            List<int> snakePositions;
            while (snakesNumber-- > 0)
            {
                var input = Console.ReadLine();
                snakePositions = input.Split(' ').Select(x => Convert.ToInt32(x)).ToList();
                if (snakePositions.Count != 2)
                {
                    throw new InvalidOperationException("Please enter a valid snake positions");
                }
                Snakes.Add(new Snake(snakePositions[0], snakePositions[1]));
            }
            return Snakes;
        }

        public List<Ladder> GetLadders()
        {
            List<Ladder> Ladders = new List<Ladder>();
            Console.WriteLine("Please give the input for the number of ladders");
            int laddersNumber = Int32.TryParse(Console.ReadLine(), out int value) ? value : 0;
            if (laddersNumber == 0)
            {
                throw new InvalidOperationException("Please enter a valid number");
            }
            List<int> ladderPositions;
            while (laddersNumber-- > 0)
            {
                var input = Console.ReadLine();
                ladderPositions = input.Split(' ').Select(x => Convert.ToInt32(x)).ToList();
                if (ladderPositions.Count != 2)
                {
                    throw new InvalidOperationException("Please enter a valid ladder positions");
                }
                Ladders.Add(new Ladder(ladderPositions[0], ladderPositions[1]));
            }
            return Ladders;
        }

        public List<Player> GetPlayers()
        {
            List<Player> Players = new List<Player>();
            Console.WriteLine("Please give the input for the number of players");
            int playerCount = Int32.TryParse(Console.ReadLine(), out int value) ? value : 0;
            if (playerCount == 0)
            {
                throw new InvalidOperationException("Please enter a valid number");
            }
            while (playerCount > 0)
            {
                var input = Console.ReadLine();
                Players.Add(new Player(playerCount, input));
                playerCount--;
            }
            return Players;
        }
    }
}
