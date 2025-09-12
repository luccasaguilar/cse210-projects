using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public string _date;

    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What challenge did I face today, and how did I respond to it?",
        "What is something new I learned today?",
        "Who made a positive difference in my day, and how?",
        "What moment today made me feel grateful?",
        "What was the most peaceful or relaxing part of my day?",
        "Did I do something kind for someone else today? What was it?",
        "What progress did I make toward one of my goals today?",
        "Was there a moment today when I laughed or smiled? Describe it.",
        "What is something I would like to remember about today in the future?",
        "If I could give my future self advice based on today, what would it be?"
    };

    public static string GetRandomPrompt()
    {

        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}