using System;  // Importing System namespace for basic C# functionality

// Define the Entry class to represent a single journal entry
public class Entry
{
    // Properties to store the date, prompt, and response
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Constructor to initialize an entry when created
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // Method to display the entry on the screen
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("-----------------------------");
    }
}