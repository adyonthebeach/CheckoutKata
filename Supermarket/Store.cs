using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public class Store : IStore
    {
        private IStoreRepository _storeRepository;
        public Store(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
    }
}
