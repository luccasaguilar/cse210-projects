using System;

class Program
{
    static void Main(string[] args)
    {
        var addr1 = new Address("1200 Market St", "St. Louis", "MO", "USA");
        var cust1 = new Customer("Alice Carter", addr1);
        var order1 = new Order(cust1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-100", 19.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-10", 7.50m, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS-90", 32.00m, 1));

        var addr2 = new Address("1234 Baker Street", "Toronto", "ON", "CANADA");
        var cust2 = new Customer("Arthur Smith", addr2);
        var order2 = new Order(cust2);
        order2.AddProduct(new Product("Noise-Canceling Headphones", "NH-500", 129.99m, 1));
        order2.AddProduct(new Product("Portable SSD 1TB", "PS-1TB", 89.00m, 2));

        var orders = new List<Order> { order1, order2 };

        foreach (var o in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total: ${o.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}