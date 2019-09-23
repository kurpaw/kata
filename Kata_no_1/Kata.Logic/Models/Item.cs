using Kata.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Logic
{
    public class Item : IItem
    {
        public string Sku { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
