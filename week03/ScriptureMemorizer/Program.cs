using System;
using System.Collections.Generic;

//creates a list(library) of scripture objects for each selcetion.
List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Romans", 5, 8), "But God commendeth his love toward us, in that, while we were yet sinners, Christ died for us."),
            new Scripture(new Reference("John", 11, 25-26), "Jesus said to her, “I am the resurrection and the life. Whoever believes in me, though he die, yet shall he live, and everyone who lives and believes in me shall never die. Do you believe this?")
        };

Random random = new Random();
Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

//The funtion below continues execution until all words are hidden.
while (!selectedScripture.IsCompletelyHidden())
{
    Console.Clear(); //This helps to clear the console.

    Console.WriteLine(selectedScripture.GetDisplayText());
    // This select the scripture to display.

    Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
    //This prompts user(s) for input to either "hide" more words or "quit" the program.
    string input = Console.ReadLine();
    if (input.ToLower() == "quit")

        break;

    selectedScripture.HideRandomWords(2);
}
