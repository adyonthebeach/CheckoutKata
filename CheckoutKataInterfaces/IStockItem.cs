using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataInterfaces
{
    public interface IStockItem
    {
        public string Sku { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
