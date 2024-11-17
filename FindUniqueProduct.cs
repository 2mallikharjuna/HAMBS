using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string[] products = {
            "ProductA",
            "ProductB",
            "ProductA",
            "ProductC",
            "ProductB"
        };

        string uniqueProduct = GetLastUniqueProduct(products);
        Console.WriteLine($"Last unique product: {uniqueProduct}");
    }

    public static string GetLastUniqueProduct(string[] products)
    {
        // Group products by their occurrences and filter out those that appear more than once
        var uniqueProducts = products
            .GroupBy(product => product)
            .Where(group => group.Count() == 1)
            .Select(group => group.Key)
            .ToList();

        // Return the last unique product or null if no unique product exists
        return uniqueProducts.LastOrDefault();
    }
}
