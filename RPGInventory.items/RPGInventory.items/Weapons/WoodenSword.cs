using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Weapons
{
    public class WoodenSword : Item
    {
        public WoodenSword()
        {
            Name = "A wooden Sword";
            Description = "Dangerous to go alone, take this";
            Weight = 3;
            Type = ItemType.Weapon;
        }
    }

}
