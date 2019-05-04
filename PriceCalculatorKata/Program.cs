using PriceCalculatorKata.Model;
using System;

namespace PriceCalculatorKata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1. TAX");
            Console.WriteLine("Sample product: Book with name = “The Little Prince”, UPC=12345, price=$20.25.");

            var book = new Product("The Little Prince", 12345, 20.25M);

            Console.WriteLine(book.ToString());

            book.ChangeTaxRate(21);

            Console.WriteLine(book.ToString());
        }
    }
}