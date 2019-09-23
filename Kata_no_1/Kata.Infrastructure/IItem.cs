using System;

namespace Kata.Infrastructure
{
    public interface IItem
    {
        string Sku { get; set; }

        decimal UnitPrice { get; set; }
    }
}
