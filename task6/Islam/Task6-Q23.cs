using System;
namespace Task6
{

class Q23
{
    static string centerchar(string input)
    {
        int length = input.Length;
        int middle = length / 2;

        if (length % 2 == 0)
        {
            return input.Substring(middle - 1, 2);
        }
        else
        {
            return input[middle].ToString();
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string centralCharacters = centerchar(input);
        Console.WriteLine("Central character(s): " + centralCharacters);
    }
}
}