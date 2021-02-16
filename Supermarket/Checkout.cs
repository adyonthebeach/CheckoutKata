using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;

namespace Supermarket
{
    public class Checkout : ICheckout
    {
        public List<IStockItem> StockItems;

        public decimal GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void ScanItem(IStockItem stockItem)
        {
            StockItems.Add(stockItem);
        }
    }
}
