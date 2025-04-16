using System;


class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Show Activity Log");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breath = new BreathingActivity();
                    breath.Run();
                    breathingCount++;
                    break;

                case "2":
                    ReflectionActivity reflect = new ReflectionActivity();
                    reflect.Run();
                    reflectionCount++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;

                case "4":
                    Console.WriteLine("\nActivity Usage Log:");
                    Console.WriteLine($"Breathing Activities: {breathingCount}");
                    Console.WriteLine($"Reflection Activities: {reflectionCount}");
                    Console.WriteLine($"Listing Activities: {listingCount}");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;

                case "5":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}

// Description: This program exceeds the core requirements by keeping track of how many times each activity was performed.