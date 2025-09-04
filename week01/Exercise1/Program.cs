using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("what is your first name?");
        string firstname = Console.ReadLine();

        Console.WriteLine("what is your last name?");
        string lastname = Console.ReadLine();
        
        Console.WriteLine($"your name is {lastname}, {firstname} {lastname}.Aaron");
    }
}