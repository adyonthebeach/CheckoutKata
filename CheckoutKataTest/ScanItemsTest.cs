using NUnit.Framework;
using StoreRepository;
using Supermarket;

namespace CheckoutKataTest
{
    public class Tests
    {

        [Test]
        public void ScanItemTest()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());
            checkout.ScanItem("Test");

            Assert.AreEqual(1, checkout.ScannedItems.Count);
        }
    }
}