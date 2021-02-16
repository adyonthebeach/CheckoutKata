using NUnit.Framework;
using StoreRepository;
using Supermarket;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataTest
{
    public class CalculateTotalTests
    {
        [Test]
        public void CheckTotalOfSingleItemTest()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());
            checkout.ScanItem("A99");

            Assert.AreEqual(0.50m, checkout.GetTotalPrice());
        }

        [Test]
        public void CheckTotalOfMultipleItemsTest()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());
            checkout.ScanItem("A99");
            checkout.ScanItem("B15");
            checkout.ScanItem("C40");
            checkout.ScanItem("A99");
            checkout.ScanItem("B15");
            checkout.ScanItem("C40");

            Assert.AreEqual(2.65m, checkout.GetTotalPrice());
        }
    }
}
