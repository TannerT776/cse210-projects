using System;

class Program
{
    static void Main()
    {
        // First customer & address
        Address address1 = new Address("123 Main St", "Orem", "UT", "USA");
        Customer customer1 = new Customer("Tanner Tinsley", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Gaming Headset", "HD001", 79.99, 1));
        order1.AddProduct(new Product("Keyboard", "KB002", 49.99, 2));

        // Second customer & order
        Address address2 = new Address("55 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS010", 29.99, 1));
        order2.AddProduct(new Product("USB-C Cable", "CB004", 9.99, 3));

        // Display both orders
        Console.WriteLine("ORDER 1 - PACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("TOTAL COST: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine("ORDER 2 - PACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(ord
