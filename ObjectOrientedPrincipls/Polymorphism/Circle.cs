﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Shape
    {
        // property only availble to circle
        public decimal Radius { get; set; }

        public override string Draw()
        {
            return "Drawing a circle";
        }
    }
}
