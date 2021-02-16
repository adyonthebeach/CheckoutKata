using CheckoutKataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public class SpecialOffer : ISpecialOffer
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal OfferPrice { get; set; }
    }
}
