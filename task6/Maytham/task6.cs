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
        Console.WriteLine(AreAnagrams("wxyz", "zyxw"));  
        Console.WriteLine(AreAnagrams("pears", "spare"));  
        Console.WriteLine(AreAnagrams("stone", "tones"));  
        Console.WriteLine(AreAnagrams("cat", "rat")); 
    }

    public static bool AreAnagrams(string str1, string str2)
    {
    
        if (str1.Length != str2.Length)
        {
            return false;
        }

      
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
        Console.WriteLine(ReverseAndAdd(456));  
        Console.WriteLine(ReverseAndAdd(-123));  
        Console.WriteLine(ReverseAndAdd(10000));  
    }

    public static string ReverseAndAdd(int number)
    {
        if (number < 0)
        {
            return "Input a positive number.";
        }

        int reversedNumber = 0;
        int temp = number;

      
        while (temp > 0)
        {
            int remainder = temp % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            temp /= 10;
        }

   
        int result = number + reversedNumber;

        return result.ToString();
    }
}
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(CountDuplicateCharacters("Red Green WHITE"));  // 2
        Console.WriteLine(CountDuplicateCharacters("ppqrrsttuuu"));  // 4
        Console.WriteLine(CountDuplicateCharacters("dow jones industrial average"));  // 9
    }

    public static int CountDuplicateCharacters(string str)
    {
        Dictionary<char, int> characterCounts = new Dictionary<char, int>();
        int duplicatesCount = 0;

        foreach (char c in str)
        {
            if (characterCounts.ContainsKey(c))
            {
              
                if (characterCounts[c] == 1)
                {
                    duplicatesCount++;
                }
                characterCounts[c]++;
            }
            else
            {
                characterCounts.Add(c, 1);
            }
        }

        return duplicatesCount;
    }
}

using System;

class Program
{
    static void Main()
    {
        string source = "Hello, soso! soso is a beautiful name. We all love this name";
        string target = "soso";

        int count = CountOccurrences(source, target);
        Console.WriteLine($"The string \"{target}\" appears {count} time(s) in the source string.");
    }

    static int CountOccurrences(string source, string target)
    {
        int count = 0;
        int startIndex = 0;

        while ((startIndex = source.IndexOf(target, startIndex, StringComparison.Ordinal)) != -1)
        {
            count++;
            startIndex += target.Length;
        }

        return count;
    }
}



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ConvertStringToNumbers("C Sharp"));
        Console.WriteLine(ConvertStringToNumbers("The quick brown fox jumps over the lazy dog."));
        Console.WriteLine(ConvertStringToNumbers("HTML Tutorial"));
    }

    static string ConvertStringToNumbers(string input)
    {
        string result = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    // For uppercase letters subtract 'A' then add 1
                    result += " " + ((int)c - (int)'A' + 1);
                }
                else
                {
                    // For lowercase letters subtract 'a' then add 1
                    result += " " + ((int)c - (int)'a' + 1);
                }
            }
            else if (char.IsWhiteSpace(c))
            {
                // If it's a whitespace, add it to the result
                result += " ";
            }
        }

        return result;
    }
}

