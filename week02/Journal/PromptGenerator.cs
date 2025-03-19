using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // List of possible prompts (given)
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random random = new Random();  // Random number generator

    // Method to get a random prompt from the lists of prompts available.
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}