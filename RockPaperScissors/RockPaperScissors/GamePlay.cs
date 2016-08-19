using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors
{
    public class GamePlay
    {
        public void PlayRound()
        {
            Player p1 = new ComputerPlayer("Player 1");
            Player p2 = new ComputerPlayer("player 2");

            MatchResult result = new MatchResult();


            result.Player1Choice = p1.GetChoice();
            result.Player2Choice = p2.GetChoice();

            if (result.Player1Choice == result.Player2Choice)
            {
                result.MatchResults = Enums.result.Tie;
            }
            else if ((result.Player1Choice == Choice.Rock && result.Player2Choice == Choice.scissors) ||
                     (result.Player1Choice == Choice.Paper && result.Player2Choice == Choice.Rock) ||
                     (result.Player1Choice == Choice.scissors && result.Player2Choice == Choice.Paper))
            {
                result.MatchResults = Enums.result.Win;
            }
            else
            {
                result.MatchResults = Enums.result.Loss;
            }

            ProcessResult(p1, p2, result);



        }

        private void ProcessResult(Player p1, Player p2, MatchResult result)
        {
            Console.WriteLine($"{p1.Name} chose {result.Player1Choice}");
            Console.WriteLine($"{p2.Name} chose {result.Player2Choice}");

            switch (result.MatchResults)
            {
                case Enums.result.Win:
                    Console.WriteLine($"{p1.Name} Wins!");
                    break;

                case Enums.result.Loss:
                    Console.WriteLine($"{p2.Name} Wins!");
                    break;

                default:
                    Console.WriteLine("Its a tie");
                    break;

            }
        }
    }
}
