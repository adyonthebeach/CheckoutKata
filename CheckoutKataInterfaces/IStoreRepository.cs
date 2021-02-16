using System;
using System.Collections.Generic;

namespace CheckoutKataInterfaces
{
    public interface IStoreRepository
    {
        List<IStockItem> GetStockItems();
        List<ISpecialOffer> GetSpecialOffers();
    }
}
