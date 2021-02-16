﻿using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;

namespace Supermarket
{
    public class Checkout : ICheckout
    {
        private IStock _stock;
        public List<IStockItem> ScannedItems { get; set; }

        public Checkout(IStock stock)
        {
            _stock = stock;
            ScannedItems = new List<IStockItem>();
        }

        public decimal GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public bool ScanItem(string sku)
        {
            if(_stock.ContainsItemWithMatching(sku))
            {
                AddItemToStockItemsWithMatching(sku);
                return true;
            }

            return false;
        }

        private void AddItemToStockItemsWithMatching(string sku)
        {
            var stockItem = _stock.GetStockItemWithMatching(sku);
            ScannedItems.Add(stockItem);
        }
    }
}
