using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem
{
    [TestFixture]
    public class TestClass2
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
            Assert.AreEqual(1, 1, "adsajksakjd");
        }

        [Test]
        public void shouldPrintReceiptForShoppingCartContaingApples()
        {

            // ShoppingCart.
            ShoppingCart a = new ShoppingCart();


            Assert.AreEqual(a.printReceipt("Apple"), "0.60", "1 Apple");
            Assert.AreEqual(a.printReciept(("Apple", "Apple")), "1.20", "2 Apple");
            Assert.AreEqual(a.printReciept(("Apple", "Apple", "pple")), "1.80", "3 Apple");

        }


        [Test]
        public void shouldPrintReceiptForShoppingCartContaingOranges()
        {

            // ShoppingCart.
            ShoppingCart a = new ShoppingCart();


            Assert.AreEqual(a.printReceipt("Orange"), "0.25", "1 Orange");
            Assert.AreEqual(a.printReciept(("Orange", "Orange")), "0.50", "2 Orange");
            Assert.AreEqual(a.printReciept(("Orange", "Orange", "Orange")), "0.75", "3 Orange");

        }


        [Test]
        public void shouldPrintReceiptForShoppingCartContaingAppleandOranges()
        {

            // ShoppingCart.
            ShoppingCart a = new ShoppingCart();


            Assert.AreEqual(a.printReceipt("Apple"), "0.60", "1 Apple");
            Assert.AreEqual(a.printReciept(("Apple", "Orange")), "0.85", "1 Apple, 1 Orange");
            Assert.AreEqual(a.printReciept(("Apple", "Orange", "A   pple")), "1.45", "2 Apple , 1 Orange");

        }


    }
}
