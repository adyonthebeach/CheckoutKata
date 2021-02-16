using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public class SupermarketFactory : ISupermarketFactory
    {
        public IStore Create(IStockRepository storeRepository, )
        {
            return new Store(storeRepository);
        }
    }
}
