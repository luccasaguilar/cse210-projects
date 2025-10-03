using System;

public class BookOfMormonActivity : Activity
{
    private static readonly Random _rng = new Random();
    private readonly List<string> _prompts = new List<string>
    {
        "Lessons from Nephi and the plates of brass",
        "Faith of the stripling warriors",
        "Repentance of Alma the Younger",
        "Trust of the Brother of Jared",
        "Service of Ammon among the Lamanites",
        "Charity in Moroni’s writings",
        "Deliverance stories in Mosiah",
        "Covenants at the Waters of Mormon",
        "Teachings of King Benjamin",
        "Hope in Ether and Moroni"
    };

    private readonly List<string> _scriptures = new List<string>
    {
        "1 Nephi 3:7, I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "2 Nephi 2:25, Adam fell that men might be; and men are, that they might have joy.",
        "Mosiah 2:17, When ye are in the service of your fellow beings ye are only in the service of your God.",
        "Mosiah 18:9, Stand as witnesses of God at all times and in all things, and in all places that ye may be in, even until death.",
        "Alma 37:6, By small and simple things are great things brought to pass.",
        "Alma 41:10, Wickedness never was happiness.",
        "Ether 12:27, My grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.",
        "Moroni 7:47, Charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him.",
        "Moroni 10:4, When ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.",
        "Ether 12:4, Whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men."
    };

    public BookOfMormonActivity() : base(
        "Book of Mormon Insights Activity",
        "This activity invites you to list insights, principles, people, and teachings from the Book of Mormon about a given theme.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many insights as you can related to:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.Write("You will begin in: ");
        CountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing. Press Enter after each item.");

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string line = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(line)) count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        Console.WriteLine();
        Console.WriteLine($"To brighten your day, consider the following scripture: {GetRandomScripture()}");
        Console.WriteLine();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        var rng = new Random();
        int i = rng.Next(_prompts.Count);
        return _prompts[i];
    }
    
    private string GetRandomScripture()
    {
        var rng = new Random();
        int i = rng.Next(_scriptures.Count);
        return _scriptures[i];
    }    
}
