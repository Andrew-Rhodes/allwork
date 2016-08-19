using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Containers
{
    public class PotionSatchel : speficcontainer
    {
        public PotionSatchel() : base(3, ItemType.Potion)
        {
            Name = "Potion satchel";
            Description = "this is a potion satchel";
            Weight = 1;
        }
    }
}
