using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Potions
{
    public class HealingPotion : Item
    {
        public HealingPotion()
        {
            Name = "Healing Potion";
            Description = "Red fizzy liquid smelling of benGay";
            Weight = 1;
            Type = ItemType.Potion;
        }
    }
}
