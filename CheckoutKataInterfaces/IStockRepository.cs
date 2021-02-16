using System;
using System.Collections.Generic;

namespace CheckoutKataInterfaces
{
    public interface IStockRepository
    {
        List<IStockItem> GetStockItems();
        List<ISpecialOffer> GetSpecialOffers();
    }
}
