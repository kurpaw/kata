using Kata.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Logic
{
    public class Checkout
    {
        private IItemsRepository _itemsRepository;

        public List<IItem> Items { get; private set; }

        public Checkout()
        {
            Items = new List<IItem>();
        }

        public Checkout(IItemsRepository itemsRepository)
        {
            Items = new List<IItem>();
            _itemsRepository = itemsRepository;
        }

        public void Scan(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                throw new ArgumentException("Invalid sku");
            }

            var item = _itemsRepository.GetProductBySku(sku);
            if (item != null)
            {
                Items.Add(item);
            }
            else
            {
                throw new Exception("Product not found");
            }
        }
    }
}
