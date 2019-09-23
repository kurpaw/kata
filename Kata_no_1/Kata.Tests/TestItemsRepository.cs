using Kata.Infrastructure;
using Kata.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Tests
{
    public class TestItemsRepository : IItemsRepository
    {
        private Dictionary<string, Item> _items;

        public TestItemsRepository()
        {
            _items = new Dictionary<string, Item>()
            {
                { "A99", new Item() { Sku = "A99", UnitPrice = 0.5m }},
                { "B15", new Item() { Sku = "B15", UnitPrice = 0.3m }},
                { "C40", new Item() { Sku = "C40", UnitPrice = 0.6m }}
            };
        }

        public IItem GetProductBySku(string sku)
        {
            if (_items.ContainsKey(sku))
            {
                return _items[sku];
            }

            return null;
        }
    }
}
