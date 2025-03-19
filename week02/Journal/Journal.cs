using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    // Create list to store multiple entries
    private readonly List<Entry> entries = new List<Entry>();

    // Method to add a new entry to the list
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            entry.Display();  // This line of code calls the Display method from the Entry class
        }
    }

    // Method to save all journal entries to a file
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))  // Check if file exists
        {
            Console.WriteLine("File not found.");
            return; // This goes back to the menu options
        }

        entries.Clear();  // Remove existing entries before loading new ones

        string[] lines = File.ReadAllLines(fileName);  // Read all lines from the file

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');  // Split the line using "|" separator
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}