using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the magic number
        Console.Write("Enter the magic number: ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask the user for a guess
        Console.Write("Guess the number: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        // Add a loop to keep playing until the user guesses correctly
        while (guess != magicNumber)
        {
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }

        // Generate a random magic number instead of user input
        Random random = new Random();
        magicNumber = random.Next(1, 101);
        int guesscount = 0;

        do
        {
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());
            guesscount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed it in {guesscount} attempts.");
            }
        } while (guess != magicNumber);

        // Keeping track of attempts and ask if they want to play again
        bool playAgain = true;

        while (playAgain)
        {
            magicNumber = random.Next(1, 101);
            guesscount = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine());
                guesscount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it in {guesscount} attempts.");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }
}
