using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Logic
{
    public class Checkout
    {
        public List<string> Items { get; private set; }

        public Checkout()
        {
            Items = new List<string>();
        }


        public void Scan(string sku)
        {
            Items.Add(sku);
        }
    }
}
