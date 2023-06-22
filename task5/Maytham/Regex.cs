using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = "C# syntax is highly expressive, yet it is also simple and easy to learn.";
        double avgLength = CalculateAvgWordLength(input);
        Console.WriteLine($"The average word length in the input string is: {avgLength}");
    }

    static double CalculateAvgWordLength(string input)
    {
        // Removing punctuation and splitting string into an array of words
        var words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Calculating sum of all word lengths
        int sumLengths = words.Sum(word => word.Length);

        // Calculating average
        double average = (double)sumLengths / words.Length;

        // Rounding to two decimal places
        average = Math.Round(average, 2);

        return average;
    }
}
