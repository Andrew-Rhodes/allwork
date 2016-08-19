using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Containers
{
    public class Backpack : Container
    {
        public Backpack() : base(4)
        {
            Name = "A leather backpack";
            Description = "not quite big enough to fit a body, sigh";
            Weight = 2;
        }
    }
}
