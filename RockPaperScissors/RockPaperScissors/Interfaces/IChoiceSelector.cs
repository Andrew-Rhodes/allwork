using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Interfaces
{
    interface IChoiceSelector
    {
        Choice GetChoice();
    }
}
