using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataInterfaces
{
    public interface IStock
    {
        public bool ContainsItemWithMatching(string Sku);
        public IStockItem GetStockItemWithMatching(string sku);
    }
}
