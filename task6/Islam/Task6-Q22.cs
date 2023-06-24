using System;
namespace Task6
{


class Q22
{
    static string Revers(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLower(chars[i]))
                chars[i] = char.ToUpper(chars[i]);
            else if (char.IsUpper(chars[i]))
                chars[i] = char.ToLower(chars[i]);
        }

        return new string(chars);
    }

    static void Main()
    {
        Console.Write("Enter a string ");
        string input = Console.ReadLine();

        string reversedString = Revers(input);
        Console.WriteLine("The Reversed String is " + reversedString);
    }
}
}