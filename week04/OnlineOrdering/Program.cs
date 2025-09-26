using System;

class Program
{
    static void Main(string[] args)
    {
        var addr1 = new Address("600 Plates Way", "Zarahemla", "UT", "USA");
        var cust1 = new Customer("Captain Moroni", addr1);
        var order1 = new Order(cust1);
        order1.AddProduct(new Product("Title of Liberty Banner", "TL-001", 24.99m, 2));
        order1.AddProduct(new Product("Stripling Warrior Shield", "SW-200", 39.50m, 1));
        order1.AddProduct(new Product("Liahona Replica", "LH-777", 59.00m, 1));

        var addr2 = new Address("12 Valley of Lemuel Rd", "Bountiful", "Alma", "Guatemala");
        var cust2 = new Customer("Nephi son of Lehi", addr2);
        var order2 = new Order(cust2);
        order2.AddProduct(new Product("Brass Plates Copy", "BP-316", 79.99m, 1));
        order2.AddProduct(new Product("Shipbuilding Tools Set", "ST-008", 129.00m, 1));
        order2.AddProduct(new Product("Liahona Compass", "LC-101", 45.75m, 2));

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