using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class SnakeAndLadder
    {
        int playerPosition1 = 0;
        int playerPosition2 = 0;
        const int NO_PLAY = 1;
        const int LADEER = 2;
        const int SNAKE = 3;
        const int WINNING_POSITION = 100;
        int dieCountPlayer1 = 0;
        int dieCountPlayer2 = 0;
        int totalDieCount = 0;

        public void StartGame()
        {
            Console.WriteLine("Game Started ");

            Random random = new Random();


            while (playerPosition1 != WINNING_POSITION || playerPosition2 != WINNING_POSITION)
            {
            Player1Chance:
                int dieRolled1 = random.Next(1, 7);
                Console.WriteLine("Dice rolled for player 1: {0}", dieRolled1);

                int option1 = random.Next(1, 4);
                Console.WriteLine("Move option:" + option1);

                totalDieCount++;
                dieCountPlayer1++;

                switch (option1)
                {
                    case NO_PLAY:
                        Console.WriteLine("No play");
                        break;

                    case LADEER:
                        playerPosition1 += dieRolled1;
                        Console.WriteLine(" Dice Rolls Number : +{0} ", dieRolled1);
                        Console.WriteLine("Ladder: " + playerPosition1);
                        if (playerPosition1 > WINNING_POSITION)
                        {
                            playerPosition1 -= dieRolled1;
                            break;
                        }
                        Console.WriteLine("Player1 got Ladder, New Position : {0}", playerPosition1);
                        goto Player1Chance;

                    case SNAKE:
                        playerPosition1 -= dieRolled1;
                        Console.WriteLine(" Dice Rolls Number : -{0} ", dieRolled1);
                        Console.WriteLine("Snake: " + playerPosition1);
                        if (playerPosition1 < 0)
                        {
                            playerPosition1 = 0;
                            Console.WriteLine("Player restart from :" + playerPosition1);
                        }
                        break;

                }
            Player2Chance:

                int dieRolled2 = random.Next(1, 7);
                Console.WriteLine("Dice rolled for player 2: {0}", dieRolled2);

                int option2 = random.Next(1, 4);
                Console.WriteLine("Move option:" + option2);

                totalDieCount++;
                dieCountPlayer2++;

                switch (option2)
                {
                    case NO_PLAY:
                        Console.WriteLine("No play");
                        break;

                    case LADEER:
                        playerPosition2 += dieRolled2;
                        Console.WriteLine(" Dice Rolls Number : +{0} ", dieRolled2);
                        Console.WriteLine("Ladder: " + playerPosition2);
                        if (playerPosition2 > WINNING_POSITION)
                        {
                            playerPosition2 -= dieRolled2;
                            break;
                        }
                        Console.WriteLine("Player2 got Ladder, New Position : {0}", playerPosition2);
                        goto Player2Chance;

                    case SNAKE:
                        playerPosition2 -= dieRolled2;
                        Console.WriteLine(" Dice Rolls Number : -{0} ", dieRolled2);
                        Console.WriteLine("Snake: " + playerPosition2);
                        if (playerPosition2 < 0)
                        {
                            playerPosition2 = 0;
                            Console.WriteLine("Player restart from :" + playerPosition2);
                        }
                        break;
                }
            }

            if (playerPosition1 == WINNING_POSITION)
            {
                Console.WriteLine("Player1 own the game");
            }

            else
            {
                Console.WriteLine("Player2 own the game");
            }


            Console.WriteLine("Total Number of Die thrown: " + totalDieCount);
            Console.WriteLine("Total Number of Die thrown by Player1: " + dieCountPlayer1);
            Console.WriteLine("Total Number of Die thrown by Player2: " + dieCountPlayer2);
        }
    }
}
