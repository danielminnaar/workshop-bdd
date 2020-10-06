using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class RetailCalculator
    {
        public static double TotalAmount(int quantity, double price, string countryCode)
        {
            var normalizedCountryCode = string.IsNullOrEmpty(countryCode) ? string.Empty : countryCode.ToUpper();
            double taxRate = 0;
            if(normalizedCountryCode == "DE")
            {
                taxRate = 0.0625;
            }
            var addedTax = (quantity * price) * taxRate;
            return (quantity * price) + addedTax;
        }
    }
}
