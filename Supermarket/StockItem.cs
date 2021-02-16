using CheckoutKataInterfaces;
using System;

namespace Supermarket
{
    public class StockItem : IStockItem
    {
        public string Sku { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
