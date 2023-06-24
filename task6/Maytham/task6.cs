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
