using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class SnakeAndLadder
    {
        int playerPosition = 0;
        const int NO_PLAY = 1;
        const int LADEER = 2;
        const int SNAKE = 3;
        public void StartGame()
        {
            Console.WriteLine("Game Started ");
            Console.WriteLine("Player Position:" + playerPosition);
            Random random = new Random();
            int dieRolled = random.Next(1, 7);
            Console.WriteLine("Die Rolled: " + dieRolled);
            playerPosition += dieRolled;
            Console.WriteLine("Player position:" + playerPosition);
            int option = random.Next(1, 4);

            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("No play");
                    break;

                case LADEER:
                    playerPosition += dieRolled;
                    Console.WriteLine("Ladder: " + playerPosition);
                    break;

                case SNAKE:
                    playerPosition -= dieRolled;
                    Console.WriteLine("Snake: " + playerPosition);
                    break;


            }
        }
    }
}
