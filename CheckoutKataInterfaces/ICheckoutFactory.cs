using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataInterfaces
{
    public interface ICheckoutFactory
    {
        ICheckout Create(IStockRepository stockRepository);
    }
}
