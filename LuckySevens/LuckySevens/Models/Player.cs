﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace LuckySevens.Models
{
    public class Player
    {
        [DataType(DataType.Currency)]
        public decimal StartingBet { get; set; }

        public int TimesRolled { get; set; }

        [DataType(DataType.Currency)]
        public decimal MaxWinnings { get; set; }

        public int MaxWinnigsRolled { get; set; }
    }
}