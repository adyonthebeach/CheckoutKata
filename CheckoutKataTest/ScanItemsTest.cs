using NUnit.Framework;
using StoreRepository;
using Supermarket;

namespace CheckoutKataTest
{
    public class Tests
    {
        [Test]
        public void ScanItemThatExistsInStockListTest()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());
            checkout.ScanItem("A99");

            Assert.AreEqual(1, checkout.ScannedItems.Count);
        }

        [Test]
        public void ScanItemThatDoesNotExistsInStockListTest()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());
            checkout.ScanItem("PARTDOESNTEXIST");

            Assert.AreEqual(0, checkout.ScannedItems.Count);
        }

        [Test]
        public void ScanMultipleItemsThatExistsInStockListTest()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());
            checkout.ScanItem("A99");
            checkout.ScanItem("B15");
            checkout.ScanItem("C40");
            checkout.ScanItem("A99");
            checkout.ScanItem("B15");
            checkout.ScanItem("C40");

            Assert.AreEqual(6, checkout.ScannedItems.Count);
        }
    }
}