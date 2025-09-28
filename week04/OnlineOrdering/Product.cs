using System;

public class Product
{
    private string _itemID;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string name, string itemID, double price, int quantity)
    {
        _itemID = itemID;
        _name = name;
        _price = price;
        _quantity = quantity;


    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetItemID()
    {
        return _itemID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}