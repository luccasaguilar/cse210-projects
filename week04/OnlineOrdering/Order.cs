using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal sum = 0m;
        foreach (var p in _products)
        {
            sum += p.GetTotalCost();
        }
        sum += _customer.IsInUSA() ? 5m : 35m;
        return sum;
    }

    public string GetPackingLabel()
    {
        var lines = new List<string>();
        foreach (var p in _products)
        {
            lines.Add($"{p.GetName()} ({p.GetProductId()})");
        }
        return string.Join("\n", lines);
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}