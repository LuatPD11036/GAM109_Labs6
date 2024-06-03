

using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200.50m },
            new Product { Name = "Mouse", Price = 19.99m },
            new Product { Name = "Keyboard", Price = 49.99m },
            new Product { Name = "Monitor", Price = 299.99m },
            new Product { Name = "Headphones", Price = 99.99m }
        };

        // Dùng phương thức First để trả về sản phẩm đầu tiên có giá trị > 100
        var firstExpensiveProduct = products.First(p => p.Price > 100);

        Console.WriteLine("Sản phẩm đầu tiên có giá > 100:");
        Console.WriteLine($"Tên: {firstExpensiveProduct.Name}, Giá: {firstExpensiveProduct.Price}");

        // Dùng phương thức LastOrDefault để trả về sản phẩm cuối cùng
        var lastProduct = products.LastOrDefault();

        if (lastProduct != null)
        {
            Console.WriteLine("\nSản phẩm cuối cùng:");
            Console.WriteLine($"Tên: {lastProduct.Name}, Giá: {lastProduct.Price}");
        }
    }
}
