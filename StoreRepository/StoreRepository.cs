using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;

namespace StoreRepository
{
    public class StoreRepository : IStoreRepository
    {
        public List<ISpecialOffer> GetSpecialOffers()
        {
            throw new NotImplementedException();
        }

        public List<IStockItem> GetStockItems()
        {
            throw new NotImplementedException();
        }
    }
}
