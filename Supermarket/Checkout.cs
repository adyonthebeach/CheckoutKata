using System;
using System.Collections.Generic;

namespace Supermarket
{
    public class Checkout
    {
        public List<StockItem> StockItems;

        public void ScanItem(StockItem stockItem)
        {
            StockItems.Add(stockItem);
        }
    }
}
