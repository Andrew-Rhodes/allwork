using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials___Die_game
{
    public partial class Player
    {
        // properties
        public string Name { get; private set; }
        public int Score { get; set; }

        // default constructor
        public Player()
        {
            //interally set name
            Name = "New Player";
        }

        
    }
}
