using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
         
        Address address1 = new Address("119 N McKinley st", "Burlington", "Washington", "USA");
        Customer customer1 = new Customer("Delbert, Fonoimoana", address1);
        List<Product> productsList1 = new List<Product>();
        //Item name, ItemID, Price, Quantity
        Product p1001 = new Product("Car alternator", "GA999", 424.95, 1);
        Product p1002 = new Product("Spark plug", "3764", 18.50, 6);
        Product p1003 = new Product("Serpentine belt", "760K6", 48.90, 1);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("3220 92nd St S", "Tacoma", "Washington", "USA");
        Customer customer2 = new Customer("Marty Pendriss", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("sand paper 180grit", "6014050", 5.98, 5);
        Product p2002 = new Product("interior paint", "HGSW6049", 65.98, 2);
        Product p2003 = new Product("paint roller", "480621", 10.98, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("544 Brookside Ln", "Sidney", "V8L", "BC");
        Customer customer3 = new Customer("Ryan Arnolds", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Snow blower", "SB1000", 1099.00, 1);
        Product p3002 = new Product("Ice melt", "92384", 13.98, 6);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
    
}