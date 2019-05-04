using FluentAssertions;
using PriceCalculatorKata.Model;
using System;
using Xunit;

namespace PriceCalculatorKata.Tests
{
    public class ProductTest
    {
        [Fact]
        public void Should_Calculate_Correct_Flat_Rate_Tax()
        {
            //Arrange
            var book = new Product("The Little Prince", 12345, 20.25M);

            //Act and Assert
            book.PriceBeforeTax.Should().Be(20.25M);
            book.PriceAfterTax.Should().Be(24.30M);
        }

        [Fact]
        public void Should_Calculate_Correct_Tax_When_Customer_Change_Tax_Rate()
        {
            //Arrange
            var book = new Product("The Little Prince", 12345, 20.25M);
            book.ChangeTaxRate(21);


            //Act and Assert
            book.PriceBeforeTax.Should().Be(20.25M);
            book.PriceAfterTax.Should().Be(24.50M);
        }

       
    }
}
