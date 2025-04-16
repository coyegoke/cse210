using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity helps you reflect on positive things in your life.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to prepare...");
        ShowCountdown(5);

        Console.WriteLine("Start listing (press Enter after each item):");

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}
