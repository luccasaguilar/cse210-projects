using System;
using System.Collections.Generic;

// I created a list of scriptures and the program chooses one randomly each time it runs.

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son; " +
                "that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."
            ),
            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            ),

            new Scripture(
                new Reference("Mosiah", 18, 9),
                "Stand as witnesses of God at all times and in all things, and in all places that ye may be in, even until death."
            ),

            new Scripture(
                new Reference("Ether", 12, 27),
                "My grace is sufficient for all men that humble themselves before me."
            ),

            new Scripture(
                new Reference("Moroni", 10, 4, 5),
                "When ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, " +
                "in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, " +
                "with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. " +
                "And by the power of the Holy Ghost ye may know the truth of all things."
            ),

            new Scripture(
                new Reference("Mosiah", 2, 41),
                "Consider on the blessed and happy state of those that keep the commandments of God. " +
                "For they are blessed in all things, both temporal and spiritual."
            )
        };

        Random rng = new Random();
        int index = rng.Next(scriptures.Count);
        var scripture = scriptures[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press ENTER to hide words or type 'quit' to exit: ");

            string input = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (input == "quit")
                break;

            scripture.HideRandomWords(numberToHide: 3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\n(All words are hidden. Program will end.)");
                break;
            }
        }
    }
}