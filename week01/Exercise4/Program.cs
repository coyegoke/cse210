using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers (type 0 to stop):");
        int UserNumber;
        do
        {
            UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        } while (UserNumber != 0);

        // Calculate the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        // Calculate the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        // Find the maximum number
        int maxNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        Console.WriteLine($"The largest number is: {maxNumber}");

        // Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted numbers are: " + string.Join(", ", numbers));
    }
}