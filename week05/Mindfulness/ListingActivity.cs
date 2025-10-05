using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some blessings that you have seen recently?",
        "What have you been genuinely thankful for recently?"
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity is to help you reflect on the good things in your life by having you list as many things around a certain area.");

    }
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];

    }
    public void PromptListing()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Create list of answers to the following question.");
        Console.WriteLine($"***{prompt}***");
        Console.Write("Your time starts in: ");
        GenerateCountdown(5);
        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime presentTime = GetPresentTime();


        while (presentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            presentTime = DateTime.Now;
        }

    }


}