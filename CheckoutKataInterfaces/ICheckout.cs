using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataInterfaces
{
    public interface ICheckout
    {
        public List<IStockItem> ScannedItems { get; set; }
        public bool ScanItem(string Sku);
        public decimal GetTotalPrice();
    }
}
