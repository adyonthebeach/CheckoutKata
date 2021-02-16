using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataInterfaces
{
    public interface ICheckout
    {
        public void ScanItem(IStockItem stockItem);
        public decimal GetTotalPrice();
    }
}
