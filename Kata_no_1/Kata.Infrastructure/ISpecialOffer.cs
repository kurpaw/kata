using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Infrastructure
{
    public interface ISpecialOffer
    {
        string Sku { get; set; }

        int Quantity { get; set; }

        decimal OfferPrice { get; set; }
    }
}
