using System;

public class Product
{
    private int _id;
    private string _name;
    private float _price;
    private int _qty;

    public Product(int id, string name, float price, int qty)
    {
        _id = id;
        _name = name;
        _price = price;
        _qty = qty;
    }

    public float ProductTotalCost()
    {
        return _qty * _price;
    }

    public int GetQty()
    {
        return _qty;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
}