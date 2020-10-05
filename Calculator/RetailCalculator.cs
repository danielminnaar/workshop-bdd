using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class RetailCalculator
    {
        public static decimal TotalAmount(int quantity, decimal price)
        {
            return quantity * price;
        }
    }
}
