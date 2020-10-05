using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter quantity");
            var text = Console.ReadLine();
            var quantity = int.Parse(text);
            Console.WriteLine("Please enter price");
            text = Console.ReadLine();
            var price = decimal.Parse(text);
            var result = RetailCalculator.TotalAmount(quantity, price);
            Console.WriteLine($"Order Total = {result}");
        }
    }
}
