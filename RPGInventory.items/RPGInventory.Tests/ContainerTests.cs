using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPGInventory.items.Containers;
using RPGInventory.items.Potions;
using RPGInventory.items.Weapons;

namespace RPGInventory.Tests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            var backpack = new Backpack();
            var hp = new HealingPotion();

            bool isAdded = backpack.AddItem(hp);

            Assert.True(isAdded);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            var backpack = new Backpack();

            backpack.AddItem(new GreatAx());
            backpack.AddItem(new GreatAx());
            backpack.AddItem(new GreatAx());
            backpack.AddItem(new GreatAx());

            var isAdded = backpack.AddItem(new GreatAx());

            Assert.IsFalse(isAdded);
        }

        [Test]
        public void CanRemoveItemtoBackpack()
        {
            var backpack = new Backpack();
            var axe = new GreatAx();

            backpack.AddItem(axe);

            var item = backpack.RemoveItem();

            Assert.AreEqual(axe, item);

            Assert.IsNull(backpack.RemoveItem());

        }

        [Test]
        public void CannotAddDuplicateItemToBackpack()
        {
            var backpack = new Backpack();
            var axe = new GreatAx();

            backpack.AddItem(axe);
            var isAdded = backpack.AddItem(axe);

            Assert.IsFalse(isAdded);
        }

        [Test]
        public void PotionBagOnlyAllowsPotion()
        {
            var bag = new PotionSatchel();
            

            Assert.IsTrue(bag.AddItem(new HealingPotion()));
            Assert.IsFalse(bag.AddItem(new GreatAx()));
        }
    }
}
