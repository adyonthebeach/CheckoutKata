using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public class Store : IStore
    {
        private IStockRepository _storeRepository;
        public Store(IStockRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
    }
}
