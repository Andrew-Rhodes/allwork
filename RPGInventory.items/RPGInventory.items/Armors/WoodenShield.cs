using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Armors
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = " A Wooden Shield";
            Description = "OUCH splinters!!!";
            Weight = 2;
            Type = ItemType.Weapon;
        }
    }
}
