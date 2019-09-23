using Kata.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Logic
{
    public class SpecialOffer : ISpecialOffer
    {
        public string Sku { get; set; }

        public int Quantity { get; set; }

        public decimal OfferPrice { get; set; }

    }
}
