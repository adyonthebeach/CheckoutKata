using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Supermarket
{
    public class Stock : IStock
    {
        private IStockRepository _stockRepository;
        public Stock(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public bool ContainsItemWithMatching(string sku)
        {
            return _stockRepository.GetStockItems().Any(stockItem => stockItem.Sku == sku);
        }

        public IStockItem GetStockItemWithMatching(string sku)
        {
            return _stockRepository.GetStockItems().FirstOrDefault(stockItem => stockItem.Sku == sku);
        }

        public List<ISpecialOffer> SpecialOffers()
        {
            return _stockRepository.GetSpecialOffers();
        }
    }
}
