using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string user = Console.ReadLine();
        int gradePercent = int.Parse(user);

        string letter = "";

        int x = (gradePercent);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        int f = 59;

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }

        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (x >= a)
        {
            Console.WriteLine($"you got an {letter}");
        }
        else if (x < a && x >= b)
        {
            Console.WriteLine($"you got a {letter}");
        }
        else if (x < b && x >= c)
        {
            Console.WriteLine($" you got a {letter}");
        }
        else if (x < c && x >= d)
        {
            Console.WriteLine("your grade is a D");
        }
        else if (x <= f)
        {
            Console.WriteLine("You got an F");
        }
        
    }
}