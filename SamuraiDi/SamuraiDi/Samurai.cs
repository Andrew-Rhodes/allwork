using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiDi.Items;

namespace SamuraiDi
{
    public class Samurai
    {
        private readonly IWeapon _weapon;
        private List<IItem> _items;

        //property injection
        //property might be set................might not...
        public IWeapon SecondaryWeapon { get; set; }

        // constructor injection
        //taking in a concrete obj as input druing creation
        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
            _items = new List<IItem>();
        }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }

        //method injection
        //be able to provide dependency and method call
        public void PickUpItem(IItem item)
        {
            _items.Add(item);
        }
    }
}
