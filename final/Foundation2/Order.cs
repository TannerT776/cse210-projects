using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private double GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalPrice();
        }

        total += GetShippingCost();
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in _products)
        {
            label += p.GetName() + " (ID: " + p.GetProductId() + ")\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress();
    }
}
