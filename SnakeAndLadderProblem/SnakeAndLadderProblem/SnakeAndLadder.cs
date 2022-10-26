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
        public void StartGame()
        {
            Console.WriteLine("Game Started ");
            Console.WriteLine("Player Position:" + playerPosition);
        }
    }
}
