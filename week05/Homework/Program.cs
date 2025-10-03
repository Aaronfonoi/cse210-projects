using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Aaron Fonoimoana", "Multiplication");
        Console.WriteLine(a1.GetSummary());


        MathAssignment a2 = new MathAssignment("Aaron Fonoimoana", "Fractions", "8.6", "7-16");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Aaron Fonoimoana", "American History", "The Hero's of world war II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        



    }
}