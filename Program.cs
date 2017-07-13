using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Baseball", 20.00, 4));
            transactions.Add(("Baseball Bat", 65.50, 2));
            transactions.Add(("Gloves", 10.00, 1));
            transactions.Add(("Shoes", 80.25, 2));
            transactions.Add(("Socks", 30.00, 6));
            int totalProducts = 0;
            double totalSales = 0;
            foreach ((string product, double amount, int quantity) transaction in transactions)
            {
                totalProducts += transaction.quantity;
                totalSales += transaction.amount;
            }
            Console.WriteLine($"Total Products Sold Today: {totalProducts}");
            Console.WriteLine($"Total Sales Today: ${totalSales}");
        }
    }
}
