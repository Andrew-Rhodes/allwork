﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    public interface Idog
    {
        string Name { get; }

        void Bark();
        string GoForAWalk();
    }
}
