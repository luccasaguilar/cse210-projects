using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int total = GetDuration();
        int elapsed = 0;

        while (elapsed < total)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            CountDown(4);
            elapsed += 4;
            if (elapsed >= total) break;

            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountDown(6);
            elapsed += 6;
            Console.WriteLine();
        }

        DisplayEndingMessage();        
    }
}