using Kata.Infrastructure;
using Kata.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Tests
{
    public class TestSpecialOffersRepository : ISpecialOffersRepository
    {
        private Dictionary<string, SpecialOffer> _items;

        public TestSpecialOffersRepository()
        {
            _items = new Dictionary<string, SpecialOffer>()
            {
                { "A99", new SpecialOffer() { Sku = "A99", Quantity = 3, OfferPrice = 1.30m } },
                { "B15", new SpecialOffer() { Sku = "B15", Quantity = 2, OfferPrice = 0.45m } }
            };
        }

        public ISpecialOffer GetSpecialOfferBySku(string sku)
        {
            if (_items.ContainsKey(sku))
            {
                return _items[sku];
            }

            return null;
        }
    }
}
