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
    }
}
