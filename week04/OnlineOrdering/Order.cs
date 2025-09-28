using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;



public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {

        _products = products;
        _customer = customer;
    }

    public double CalculateShipping()
    {
        double shippingCost = _customer.LiveInUs() ? 5 : 35;
        return shippingCost;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product p in _products)
        {
            double cost = p.CalculateTotalCost();
            totalCost += cost;

        }
        double shippingCost = CalculateShipping();
        totalCost += shippingCost;
        return totalCost;

    }
    public string PackingLabel()
    {
        string packLabel = "Packing Label: ";
        foreach (Product p in _products)
        {
            packLabel += p.GetName() + " - " + p.GetItemID() + " ";

        }
        return packLabel;

    }
    public string ShippingLabel()
    {
        string shipLabel = "Shipping Label: ";
        shipLabel += _customer.GetName() + "\n" + _customer.CompleteAddress();
        return shipLabel;

    }
    public string TotalCost()
    {
        string finalCost = "Items: ";
        double totalCost = CalculateTotalCost();
        foreach (Product p in _products)
        {
            finalCost += p.GetName() + " (" + p.GetItemID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculateTotalCost() + "\n";
        }

        finalCost += "Shipping Cost: $" + CalculateShipping() + "\n";
        finalCost += "Total: $" + CalculateTotalCost();

        return finalCost;
    }

    public void DisplayResults()
    {
        string packLabel = PackingLabel();
        string shipLabel = ShippingLabel();
        string finalCost = TotalCost();

        Console.WriteLine(packLabel);
        Console.WriteLine(shipLabel);
        Console.WriteLine(finalCost);
    }

}