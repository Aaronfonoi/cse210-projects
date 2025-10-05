using System;
using System.Diagnostics;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 15;

    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;

    }
    public void DisplayStartingMessage()
    //public void ShowDetails()
    {
        Console.WriteLine($"This is the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void UserDuration()
    {
        Console.WriteLine();
        Console.Write("Please type a duration in seconds for this activity.");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));

    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;

    }
    public void RunActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        UserDuration();
        GetReady();

    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Great work!!");
        GenerateSpinner(5);
        Console.WriteLine($"Thats another {_duration} seconds of {_name}.");
        GenerateSpinner(5);

    }

    public void GenerateSpinner(int totalSeconds)
    {
        int spinPosition = 25;
        int spinWait = 500;

        spinPosition = Console.CursorLeft;

        DateTime futureTime = GetFutureTime(5);

        while (DateTime.Now < futureTime)
        {
            char[] spinnerChars = new char[] {'|','\\','-','/'};

            foreach (char spinnerChar in spinnerChars)
            {
                Console.CursorLeft = spinPosition;
                Console.Write(spinnerChar);
                Thread.Sleep(spinWait);

            }

        }
        Console.CursorLeft = spinPosition;
        Console.Write(" ");

    }

    public void GenerateCountdown(int totalSeconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;


        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(totalSeconds - i);
            Thread.Sleep(timerWait);

        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");


    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Acivity incoming...");
        GenerateSpinner(5);

    }
    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);
        return futureTime;

    }

    public DateTime GetPresentTime()
    {
        DateTime presentTime = new DateTime();
        presentTime = DateTime.Now;
        return presentTime;
    }



}