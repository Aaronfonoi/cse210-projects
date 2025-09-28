using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUs()
    {
        return _address.isUSA() ? true : false;

    }

    public string GetName()
    {
        return _name;
    }


    public string CompleteAddress()
    {
        string getAddress = _address.CompleteAddress();
        return getAddress;
    }
}