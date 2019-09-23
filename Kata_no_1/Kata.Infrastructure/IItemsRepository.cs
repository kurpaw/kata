using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Infrastructure
{
    public interface IItemsRepository
    {
        IItem GetProductBySku(string sku);
    }
}
