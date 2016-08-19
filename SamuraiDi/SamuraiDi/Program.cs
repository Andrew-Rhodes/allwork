using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiDi.Items;

namespace SamuraiDi
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai bob = new Samurai(new Sword());
            bob.Attack("the bad dudes");

            bob.SecondaryWeapon = new Sword();
            if (bob.SecondaryWeapon != null)
            {
                bob.SecondaryWeapon.Hit("the other guy");
            }

            Samurai jack = new Samurai(new Shuriken());

            jack.Attack("the evildoers");

            jack.PickUpItem(new Ration());
            jack.PickUpItem(new Ration());
            jack.PickUpItem(new Ration());
            jack.PickUpItem(new Ration());
            jack.PickUpItem(new Ration());
            jack.PickUpItem(new Ration());



            Console.ReadLine();
        }
    }
}
