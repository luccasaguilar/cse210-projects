using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };    

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You will begin in: ");
        CountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing. Press Enter after each item.");

        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        var rng = new Random();
        int i = rng.Next(_prompts.Count);
        return _prompts[i];
    }

    public void GetListFromUser()
    {
        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        List<string> items = new List<string>();

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string line = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(line))
            {
                items.Add(line.Trim());
            }
        }

        _count = items.Count;

    }
}