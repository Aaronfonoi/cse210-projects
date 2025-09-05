using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Please enter a magic number.");
        //string user = Console.ReadLine();
        //int magicNumber = int.Parse(user);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number ");
            guess = int.Parse(Console.ReadLine());
        

        
        





                if (magicNumber == guess)
            {
                Console.WriteLine("correct");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Too low");
            }

                Console.WriteLine($"your guess is: {guess}");
                
        }
    }
}