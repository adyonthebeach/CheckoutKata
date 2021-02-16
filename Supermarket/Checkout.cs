using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var totalPrice = CalculateItemTotal();

            totalPrice = ApplySpecialOfferDiscounts(totalPrice);

            return totalPrice;
        }

        private decimal CalculateItemTotal()
        {
            var itemTotal = 0.0m;
            foreach (StockItem item in ScannedItems)
            {
                itemTotal += item.UnitPrice;
            }

            return itemTotal;
        }

        private decimal ApplySpecialOfferDiscounts(decimal itemsTotal)
        {
            foreach(SpecialOffer specialOffer in _stock.SpecialOffers())
            {
                var numberOfSpecialOfferItems = ScannedItems.Count(stockItem => stockItem.Sku == specialOffer.Sku);
                itemsTotal = ApplyDiscount(itemsTotal, specialOffer, numberOfSpecialOfferItems);
            }

            return itemsTotal;
        }

        private decimal ApplyDiscount(decimal itemsTotal, SpecialOffer specialOffer, int specialOfferItemCount)
        {
            if(specialOfferItemCount > 0)
            {
                var discountMultiplier = specialOfferItemCount / specialOffer.Quantity;
                itemsTotal = itemsTotal - (specialOffer.OfferPrice * discountMultiplier);
            }

            return itemsTotal;
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
