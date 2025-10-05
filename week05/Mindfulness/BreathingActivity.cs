using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("BreathingActivity");
        SetDescription("This activity will help you clear your mind with controlled relaxed breathing");

    }
    public void PromptBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime presentTime = GetPresentTime();

        Console.WriteLine();
        Console.Write("breathe in.");
        GenerateCountdown(5);
        Console.WriteLine();
        Console.Write("Now Exhale.");
        GenerateCountdown(5);
        while (presentTime <= futureTime)
        {
            Console.WriteLine();
            Console.Write("breathe in.");
            GenerateCountdown(5);
            Console.Write("now Breathe out.");
            GenerateCountdown(5);
            presentTime = DateTime.Now;

        }
    }
}