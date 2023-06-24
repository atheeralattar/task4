using System;
using System.Linq;
namespace Task6
{
class Q24
{
    static void maxAndMin(string input)
    {
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        int min = numbers.Min();
        int max = numbers.Max();

        Console.WriteLine("Minimum number: " + min);
        Console.WriteLine("Maximum number: " + max);
    }

    static void Main()
    {
        Console.Write("Enter a string of numbers separated by a single space: ");
        string input = Console.ReadLine();

        maxAndMin(input);
    }
}
}