using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace HW10_tests

    public class ShoppingCartTests
    {
        private ShoppingCart cart;

        [SetUp]
        public void SetUp()
        {
            cart = new ShoppingCart("Mary", 1231);
        }

           [Test]     // checking that sum after removing items is greater than 0 or equals to 0
        public void SumAfterRemovingItems()
        {
            cart.AddItem("T-shirt", 2, 100);
            cart.RemoveItem("T-shirt", 1);

            Assert.ClassicAssert.GreaterOrEqual(cart.Sum, 0);
        }

            [Test]
        public void CheckTotalSum()      // checking total sum 
        {

            cart.AddItem("T-shirt", 2, 100);
            cart.AddItem("Dress", 1, 500);

            var total = cart.Sum;

            Assert.ClassicAssert.AreEqual(600, total);
        }

            [Test]      // checking items quantity before removal 
        public void ItemsQuantityBeforeRemoval()
        {
            cart.AddItem("T-shirt", 2, 100);
            cart.AddItem("Dress", 1, 500);

            var itemQuantityBeforeRemoval = cart.Items[0].Quantity;

            Assert.ClassicAssert.AreEqual(3, itemQuantityBeforeRemoval);
        }

        [Test]       // checking items quantity after removal
        public void ItemsQuantityAfterRemoval()
        {

            cart.AddItem("T-shirt", 2, 100);
            cart.AddItem("Dress", 1, 500);

            cart.RemoveItem("T-shirt", 1);
            var itemQuantityAfterRemoval = cart.Items[0].Quantity;

            Assert.ClassicAssert.AreEqual(2, itemQuantityAfterRemoval);
        }
    }
}








