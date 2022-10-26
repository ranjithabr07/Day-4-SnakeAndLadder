using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class SnakeAndLadder
    {
        iint playerPosition = 0;
        const int NO_PLAY = 1;
        const int LADEER = 2;
        const int SNAKE = 3;
        const int WINNING_POSITION = 100;
        public void StartGame()
        {
            Console.WriteLine("Game Started ");
            Console.WriteLine("Player Position:" + playerPosition);

            while (playerPosition < WINNING_POSITION)
            {
                Random random = new Random();
                int dieRolled = random.Next(1, 7);
                int option = random.Next(1, 4);

                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No play");
                        break;

                    case LADEER:
                        playerPosition += dieRolled;
                        Console.WriteLine(" Dice Rolls Number : +{0} ", dieRolled);
                        Console.WriteLine("Ladder: " + playerPosition);
                        if (playerPosition > WINNING_POSITION)
                        {
                            playerPosition -= dieRolled;
                        }
                        Console.WriteLine("Player position:" + playerPosition);
                        break;

                    case SNAKE:
                        playerPosition -= dieRolled;
                        Console.WriteLine(" Dice Rolls Number : -{0} ", dieRolled);
                        Console.WriteLine("Snake: " + playerPosition);
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                            Console.WriteLine("Player restart from :" + playerPosition);
                        }
                        break;

                }
                if (playerPosition == WINNING_POSITION)
                {
                    Console.WriteLine("Player Won the Game");
                }
            }
        }
    }
}
