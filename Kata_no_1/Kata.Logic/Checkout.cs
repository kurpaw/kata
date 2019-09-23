using Kata.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kata.Logic
{
    public class Checkout
    {
        private IItemsRepository _itemsRepository;

        private ISpecialOffersRepository _specialOffersRepository;

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

        public Checkout(IItemsRepository itemsRepository, ISpecialOffersRepository specialOffersRepository)
        {
            Items = new List<IItem>();
            _itemsRepository = itemsRepository;
            _specialOffersRepository = specialOffersRepository;
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

        public decimal Total()
        {
            var groupedItems = Items
                .GroupBy(i => i.Sku)
                .Select(g => new
                {
                    Sku = g.Key,
                    Count = g.Count()
                });

            decimal total = 0m;
            foreach (var line in groupedItems)
            {
                var specialOffer = _specialOffersRepository?.GetSpecialOfferBySku(line.Sku);
                if (specialOffer != null)
                {
                    total += line.Count / specialOffer.Quantity * specialOffer.OfferPrice + line.Count % specialOffer.Quantity * _itemsRepository.GetProductBySku(line.Sku).UnitPrice;
                }
                else
                {
                    total += line.Count * _itemsRepository.GetProductBySku(line.Sku).UnitPrice;
                }
            }
            return total;
        }
    }
}
