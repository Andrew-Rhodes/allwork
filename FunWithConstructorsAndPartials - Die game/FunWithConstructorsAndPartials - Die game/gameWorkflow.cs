using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials___Die_game
{
    public class gameWorkflow
    {
        //properties
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }



        //private static read only
        //privase only inside of class
        //static only one
        //readonly can set in constructor only
        private static readonly Random _randomGenerator;


        //static construcor
        //can only init static props and fields
        //cannot interact with instances of the class
        static gameWorkflow()
        {
            _randomGenerator = new Random();
        }

        private int RollDie()
        {
            return _randomGenerator.Next(1, 7);
        }

        public void PlayGame()
        {
            do
            {
                Player1.Score += RollDie();
                Player2.Score += RollDie();
            } while (Player1.Score < 100 && Player2.Score < 100);

            Console. = ConsoleColor.DarkCyan;
            Console.Write("Game Over");
            Console.WriteLine($"{Player1.Name} {Player1.Score} {Player2.Name} {Player2.Score}");
        }
    }
}
