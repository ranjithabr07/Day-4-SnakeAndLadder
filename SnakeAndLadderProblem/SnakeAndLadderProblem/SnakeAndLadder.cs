﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class SnakeAndLadder
    {
        int playerPosition = 0;
        public void StartGame()
        {
            Console.WriteLine("Game Started ");
            Console.WriteLine("Player Position:" + playerPosition);
            Random random = new Random();
            int dieRolled = random.Next(1, 7);
            Console.WriteLine("Die Rolled: " + dieRolled);
            playerPosition += dieRolled;
            Console.WriteLine("Player position:" + playerPosition);
        }
    }
}
