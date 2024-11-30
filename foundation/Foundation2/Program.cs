using System;
using System.Reflection;

class Program
{
    static List<Order> _orders = new List<Order>();    
    
    static void Main(string[] args)
    {
        CreateOrders();
        DisplayOrders();
    }

    static void DisplayOrders()
    {
        Console.Clear();
        foreach(Order item in _orders)
        {
            Console.WriteLine(item.CreateShippingLabel());
            Console.WriteLine(item.CreatePackingLabel());
            Console.WriteLine($"Total Cost (incl. shipping): ${item.OrderTotalCost():F2}\n");
            Console.WriteLine("----------------------------------------------------");
        }
    }

    static void CreateOrders()
    {
        Address address1 = new Address("468 Junction Road", "Pella", "Iowa", "USA");
        Customer customer1 = new Customer("Peter Jasper", address1);
        Order order1 = new Order(customer1);
        Product grapefruit = new Product(4028, "Grapefruit", 1.97f, 4);
        Product banana = new Product(4631, "Banana", 0.68f, 3);
        Product milk = new Product(5893, "Whole Milk", 4.49f, 2);

        order1.AddProduct(grapefruit);
        order1.AddProduct(banana);
        order1.AddProduct(milk);

        _orders.Add(order1);

        Address address2 = new Address("9832 Ridge Street","Buffalo", "New York", "USA");
        Customer customer2 = new Customer("Terri Black", address2);
        Order order2 = new Order(customer2);
        Product cucumber = new Product(4035, "Cucumber", 0.99f, 3);
        Product potato = new Product(4012, "Potatoes", 4.39f, 1);
        Product steak = new Product(6832, "Rib Eye Steak", 15.79f, 2);

        order2.AddProduct(cucumber);
        order2.AddProduct(potato);
        order2.AddProduct(steak);

        _orders.Add(order2);

        Address address3 = new Address("536 Bullrush Lane", "Niagara Falls", "Ontario", "CAN");
        Customer customer3 = new Customer("Oscar Peters", address3);
        Order order3 = new Order(customer3);
        Product branCereal = new Product(947821, "Post Raisin Bran Cereal", 4.99f, 4);
        Product paperTowel = new Product(093548, "Bounty Paper Towels-Mega", 8.99f, 4);
        Product cookie = new Product(873012, "Keebler Fudge Stripes", 3.99f, 6);

        order3.AddProduct(branCereal);
        order3.AddProduct(paperTowel);
        order3.AddProduct(cookie);

        _orders.Add(order3);
    }


}