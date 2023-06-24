using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(ReverseWords("The quick brown fox jumps over the lazy dog"));
        Console.WriteLine(ReverseWords("Reverse the words of three or more"));
        Console.WriteLine(ReverseWords("ABcDef"));
    }

    public static string ReverseWords(string input)
    {
 
        var words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 3)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
        }

      
        return string.Join(" ", words);
    }
}




public class Program
{
    public static void Main()
    {
        Console.WriteLine(AreAnagrams("wxyz", "zyxw"));  // True
        Console.WriteLine(AreAnagrams("pears", "spare"));  // True
        Console.WriteLine(AreAnagrams("stone", "tones"));  // True
        Console.WriteLine(AreAnagrams("cat", "rat"));  // False
    }

    public static bool AreAnagrams(string str1, string str2)
    {
        // If the strings are different lengths, they cannot be anagrams
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Convert the strings to character arrays, sort them and compare them
        var str1Array = str1.ToCharArray();
        var str2Array = str2.ToCharArray();

        Array.Sort(str1Array);
        Array.Sort(str2Array);

        return new string(str1Array) == new string(str2Array);
    }
}


using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(ReverseAndAdd(456));  // 456654
        Console.WriteLine(ReverseAndAdd(-123));  // "Input a positive number."
        Console.WriteLine(ReverseAndAdd(10000));  // 1000000001
    }

    public static string ReverseAndAdd(int number)
    {
        if (number < 0)
        {
            return "Input a positive number.";
        }

        int reversedNumber = 0;
        int temp = number;

        // Reverse the number
        while (temp > 0)
        {
            int remainder = temp % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            temp /= 10;
        }

        // Add the reversed number to the original number
        int result = number + reversedNumber;

        return result.ToString();
    }
}


