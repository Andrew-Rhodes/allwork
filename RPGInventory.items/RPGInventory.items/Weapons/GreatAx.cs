using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Weapons
{
    public class GreatAx : Item
    {
        public GreatAx()
        {
            Name = "A Great Ax";
            Description = "An ax, thats great";
            Weight = 5;
            Type = ItemType.Weapon;
        }
    }
}
