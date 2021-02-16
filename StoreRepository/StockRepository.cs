using CheckoutKataInterfaces;
using Supermarket;
using System;
using System.Collections.Generic;

namespace StoreRepository
{
    public class StockRepository : IStockRepository
    {
        public List<ISpecialOffer> GetSpecialOffers()
        {
            return new List<ISpecialOffer>()
            {
                new SpecialOffer()
                {
                    Sku = "A99",
                    Quantity = 3,
                    OfferPrice = 1.30m
                },
                new SpecialOffer()
                {
                    Sku = "B15",
                    Quantity = 2,
                    OfferPrice = 0.45m
                }
            };
        }

        public List<IStockItem> GetStockItems()
        {
            return new List<IStockItem>()
            {
                new StockItem()
                {
                    Sku = "A99",
                    UnitPrice = 0.50m
                },
                new StockItem()
                {
                    Sku = "B15",
                    UnitPrice = 0.30m,
                },
                new StockItem()
                {
                    Sku = "C40",
                    UnitPrice = 0.60m
                }
            };
        }
    }
}
