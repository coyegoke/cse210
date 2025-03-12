using System;

class Program
{
    static void Main(string[] args)
    {
        // Function 1: Display a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Function 2: Prompt user for their name and return it
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // Function 3: Prompt user for their favorite number and return it as an integer
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        // Function 4: Square the given number and return the result
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Function 5: Display the result with the user's name and squared number
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }

        // Calling functions in sequence
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

    }
}