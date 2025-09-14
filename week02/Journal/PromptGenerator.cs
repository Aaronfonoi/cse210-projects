using System;

public class PromptGenerator
{
    public static string[] _prompts = {
        "what food are you hoping to have or had today?",
        "How did you sleep last night?"
    };

    public List<string> _PromptGenerator = new List<string>(_prompts);
    public PromptGenerator()
    {

    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(_PromptGenerator.Count);
        string PromptGenerator = _PromptGenerator[index];
        Console.WriteLine($"{_PromptGenerator}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_PromptGenerator.Count);
        string PromptGenerator = _PromptGenerator[index];

        return PromptGenerator;
    }

}