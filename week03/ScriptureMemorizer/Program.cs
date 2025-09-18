using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // var reference = new Reference("John", 3, 16);
        // string text = "For God so loved the world, that he gave his only begotten Son; " +
        //               "that whosoever believeth in him should not perish, but have everlasting life.";

        var reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                      "In all thy ways acknowledge him, and he shall direct thy paths.";

        var scripture = new Scripture(reference, text);

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