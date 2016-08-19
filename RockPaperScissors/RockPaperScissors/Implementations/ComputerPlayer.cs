using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    public class ComputerPlayer : Player
    {
        private static Random _randonGenerator = new Random();


        public ComputerPlayer(string name) : base(name)
        {
        }

        public override Choice GetChoice()
        {
            int choice = _randonGenerator.Next(1, 4);
            return (Choice) choice;
        }
    }
}
