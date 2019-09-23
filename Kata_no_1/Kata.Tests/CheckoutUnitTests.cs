using Kata.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Kata.Tests
{
    public class CheckoutUnitTests
    {
        [Fact]
        public void Scan_OneProduct_True()
        {
            Checkout checkout = new Checkout(new TestItemsRepository());

            checkout.Scan("A99");

            Assert.True(checkout.Items.Count == 1);
        }

        [Fact]
        public void Scan_TwoProducts_True()
        {
            Checkout checkout = new Checkout(new TestItemsRepository());

            checkout.Scan("A99");
            checkout.Scan("B15");

            Assert.True(checkout.Items.Count == 2);
        }
    }
}
