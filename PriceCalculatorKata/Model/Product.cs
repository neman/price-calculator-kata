using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculatorKata.Model
{
    public class Product
    {
        private const int FlatTaxRate = 20;

        public string Name { get; private set; }
        public int UPC { get; private set; }
        public decimal PriceBeforeTax { get; set; }
        public int TaxRate { get; private set; } = FlatTaxRate;

        public decimal PriceAfterTax
        {
            get
            {
                return Math.Round(PriceBeforeTax * (1 + (TaxRate)/100M), 2);
            }
        }
        public Product(string name, int upc, decimal price)
        {
            Name = name;
            UPC = upc;
            PriceBeforeTax = price;
        }

        public void ChangeTaxRate(int newTaxRate)
        {
            TaxRate = newTaxRate;
        }

        public override string ToString()
        {
            return $"Product price reported as ${PriceBeforeTax} before tax and ${PriceAfterTax} after {TaxRate}% tax.";
        }


    }
}
