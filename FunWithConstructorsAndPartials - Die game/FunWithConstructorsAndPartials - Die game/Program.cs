using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials___Die_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string theName = Console.ReadLine();
            Player p1 = new Player(theName);
            Player p2 = new Player();

            //object initalizers
            gameWorkflow game = new gameWorkflow()
            {
                Player1 = p1,
                Player2 = p2
            };

            game.PlayGame();
            Console.ReadLine();

        }
    }
}
