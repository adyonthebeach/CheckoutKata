using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public class CheckoutFactory : ICheckoutFactory
    {
        public ICheckout Create(IStockRepository stockRepository)
        {
            var stock = new Stock(stockRepository);
            return new Checkout(stock);
        }
    }
}
