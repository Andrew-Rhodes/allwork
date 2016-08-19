using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials___Die_game
{
    public partial class Player
    {
        //set name with parameter
        public Player(string Name)
        {
            // set name to parameter value
            this.Name = Name;
            //"this" is refering to property
        }
    }
}
