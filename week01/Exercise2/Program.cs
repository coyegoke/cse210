using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        string answer = Console.ReadLine();
        string sign = "";
        int percent = int.Parse(answer);


        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent >= 50)
        {
            letter = "E";
        }
        else
        {
            letter = "F";
        }

        int remainder = percent % 10;
        if (remainder >= 7)
        {
            sign = "+";
            if (letter == "A")
            {
                sign = "";
            }
        }
        else
        {
            sign = "-";
        }

        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");


        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}