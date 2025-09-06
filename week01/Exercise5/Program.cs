using System;

class Program
{
    static void Main(string[] args)
    {
        
        static void DisplayMessage()
        {
            Console.WriteLine("welcome to the program!");
        }

        static void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Welcome {userName}");
        }
        static int AddNumbers(int first, int second)
        {
            int sum = first = second;
            return sum;
        }
    }
}