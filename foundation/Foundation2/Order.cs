using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);  
    }

    public float OrderTotalCost()
    {
        float totalCost = 0;
        
        foreach(Product item in _products)
        {
            totalCost += item.ProductTotalCost();  
        }
        return totalCost + ShippingCost();
    }

    public float ShippingCost()
    {
        if (_customer.IsUSA() == true)
        {
            return 5.00f;    
        }
        return 35.00f;
    }

    public string CreatePackingLabel()
    {
        string packingLabel = "";

        foreach (Product item in _products)
        {
            packingLabel += item.GetId() + "\t" + item.GetName() + "\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        return $"{_customer.GetAddress()}";
    }

}
