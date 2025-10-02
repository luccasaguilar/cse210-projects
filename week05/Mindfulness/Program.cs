using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                var a = new BreathingActivity();
                a.Run();
            }
            else if (choice == "2")
            {
                var a = new ReflectingActivity();
                a.Run();
            }
            else if (choice == "3")
            {
                var a = new ListingActivity();
                a.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

            Console.WriteLine();
            // Console.WriteLine("Press Enter to return to menu...");
            // Console.ReadLine();
        }
    }
}