using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPG.Inventory.Items.Containers;
using RPG.Inventory.Items.Potions;
using RPG.Inventory.Items;
using RPG.Inventory.Items.Weapons;

namespace RPG.Inventory.Tests
{
    [TestFixture]
    public class ContainerTest
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            bool actual = b.AddItem(p);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            Backpack p = new Backpack();
            GreatAx axes = new GreatAx();

        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);

            Item actual = b.RemoveItem();

            Assert.AreEqual(p, actual);

        }
    }
}
