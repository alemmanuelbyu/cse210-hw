public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal productTotal = 0;
        foreach (Product product in Products)
        {
            productTotal += product.GetTotalCost();
        }
        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in Products)
        {
            label += $"{product.Name} ({product.Id})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address}";
    }
}

