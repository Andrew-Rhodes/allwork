using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class MiniVan : Car
    {
        //default constructor calling the base
        public MiniVan() : base(60)
        {
            // illustrate whick is called first base or child
            MaxSpeed = 65; //calls base @ 60 then overrides at 65
        }

        public MiniVan(int max, int min) : base(max, min) { }

        //constructor not specifying a vase constructor
        //hennse, calls cat()
        public MiniVan(int max) { }

    }
}
