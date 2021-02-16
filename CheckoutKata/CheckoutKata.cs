using StoreRepository;
using Supermarket;
using System;

namespace CheckoutKata
{
    public class CheckoutKata
    {
        public CheckoutKata()
        {
            var checkoutFactory = new CheckoutFactory();
            var checkout = checkoutFactory.Create(new StockRepository());

            checkout.ScanItem("Test");
        }
    }
}
