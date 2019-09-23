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

        [Fact]
        public void Scan_ProductNotFound_ThrowsException()
        {
            Checkout checkout = new Checkout(new TestItemsRepository());

            Assert.Throws<Exception>(() => checkout.Scan("AAA"));
        }

        [Fact]
        public void Scan_EmptyStringAsArgument_ThrowsArgumentException()
        {
            Checkout checkout = new Checkout(new TestItemsRepository());

            Assert.Throws<ArgumentException>(() => checkout.Scan(""));
        }

        [Fact]
        public void Scan_WhiteSpaceAsArgument_ThrowsArgumentException()
        {
            Checkout checkout = new Checkout(new TestItemsRepository());

            Assert.Throws<ArgumentException>(() => checkout.Scan(" "));
        }

        [Fact]
        public void Total_1Pound90Pence_True()
        {
            Checkout checkout = new Checkout(new TestItemsRepository(), new TestSpecialOffersRepository());

            checkout.Scan("A99");
            checkout.Scan("B15");
            checkout.Scan("C40");
            checkout.Scan("A99");

            Assert.True(checkout.Total() == 1.90m);
        }
    }
}
