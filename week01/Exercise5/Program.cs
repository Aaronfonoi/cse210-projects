using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();

        string name = userName();
        int numbers = FavoriteNumber();
        int squaredNumber = squareNumber(numbers);
        DisplayResult(name, squaredNumber);

        
    
        static void DisplayMessage()
        {
            Console.WriteLine("welcome to the program!");
        }

        static string userName()
        {
            Console.Write("Who are you?: ");
            string user = Console.ReadLine();
            return user;

        }
        static int FavoriteNumber()
        {
            Console.Write("What is your favorite number? : ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int squareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Hello {name}, the square of your favorite number is {square}");
        }
    }
}



