using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Infrastructure
{
    public interface ISpecialOffersRepository
    {
        ISpecialOffer GetSpecialOfferBySku(string sku);
    }
}
