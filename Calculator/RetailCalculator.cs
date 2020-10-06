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
            } else if (normalizedCountryCode == "DK")
            {
                taxRate = 0.04;
            
            } else if (normalizedCountryCode == "NO")
            {
                taxRate = 0.0825;
            }
            var addedTax = (quantity * price) * taxRate;
            var totalAmount = (quantity * price) + addedTax;
            return ApplyDiscount(totalAmount);
        }

        private static double ApplyDiscount(double amount)
        {
            if (amount >= 1000 && amount < 5000)
                return amount - (amount * 0.03);

            return amount;
        }
    }
}
