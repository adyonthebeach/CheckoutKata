using StoreRepository;
using Supermarket;
using System;

namespace CheckoutKata
{
    public class CheckoutKata
    {
        public CheckoutKata()
        {
            var storeFactory = new SupermarketFactory();
            var Store = storeFactory.Create(new StockRepository());

            Store
        }
    }
}
