using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("123 Main St", "Provo", "UTAH", "USA");
        Address address2 = new Address("12 Friendship street", "Bwari", "ABUJA", "NIGERIA");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Emmanuel Olusola", address2);

        Product product1 = new Product("Product 1", "P1", 10, 2);
        Product product2 = new Product("Product 2", "P2", 15, 3);
        Product product3 = new Product("Product 3", "P3", 5, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetTotalPrice():C}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalPrice():C}");

    }
}