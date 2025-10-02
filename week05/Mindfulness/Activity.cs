using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;        
    }

    protected int GetDuration()
    {
        return _duration;
    }    

    public void DisplayStartingMessage()
    {
Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        if (!int.TryParse(Console.ReadLine(), out _duration) || _duration < 1)
        {
            _duration = 30;
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        string frames = "|/-\\";
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
        }
        Console.Write(' ');
        Console.Write('\r');
    }

    public void CountDown(int seconds)
    {
        for (int s = seconds; s >= 1; s--)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }        
    }
}