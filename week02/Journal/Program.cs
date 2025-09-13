using System;
using System.IO;

// Shows creativity and exceeds core requirements:
// I added a new menu item to display all available prompts. I also made adjustments to the menu in case the user enters an invalid option.

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();

        Console.WriteLine("Welcome to thew Journal Program:");

        while (choice != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Available Prompts");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = PromptGenerator.GetRandomPrompt();
                        Console.WriteLine($"{prompt}");
                        string entryText = Console.ReadLine();
                        Entry newEntry = new Entry(DateTime.Now.ToShortDateString(), prompt, entryText);
                        journal.AddEntry(newEntry);
                        break;

                    case 2:
                        journal.Display();
                        break;

                    case 3:
                        journal = new Journal();
                        Console.WriteLine("What is the filename?");
                        string filenameLoad = Console.ReadLine();
                        journal.LoadFile(filenameLoad);
                        break;

                    case 4:
                        Console.WriteLine("What is the filename?");
                        string filename = Console.ReadLine();
                        journal.SaveFile(filename);
                        break;

                    case 5:
                        PromptGenerator allPrompts = new PromptGenerator();
                        allPrompts.Display();
                        break;

                    case 6:
                        Console.WriteLine("\nExiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option! Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}