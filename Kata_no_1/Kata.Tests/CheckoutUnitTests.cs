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
            Checkout checkout = new Checkout();

            checkout.Scan("A99");

            Assert.True(checkout.Items.Count == 1);

        }
    }
}
