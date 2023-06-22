using System.Globalization;

//25. Write a C# Sharp program to check whether a given string is an “isograms” or not. Return True or False.
void Isograms(string s)
{
    Console.WriteLine($"Original string: {s}");
    s = s.ToLower();
    foreach (var i in s)
    {
        if (s.Count(s=> s == i ) > 1)
        {
            Console.WriteLine("Check the said string is an 'isograms' or not! False");
            return;
        }
    }
    Console.WriteLine("Check the said string is an 'isograms' or not! True");
}
//Isograms("Python");
//Isograms("JavaScript");
//Isograms("C#");
//Isograms("PHP");



//26. Write a C# Sharp program to convert the first character of each word in a given string to uppercase.
 void ToUpper(string s)
 {
     Console.WriteLine($"Original String: {s}");
     TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
     Console.WriteLine($"After:\n {textInfo.ToTitleCase(s)}");
 }
//ToUpper("python exercises");
//ToUpper("The quick brown Fox jumps over the little lazy Dog");



//27. Write a C# Sharp program to find the position of a specified word in a given string.
void FindPosition(string str,string word)
{
    
    var s = str.Split();
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Equals(word))
        {
            Console.WriteLine($"Position of the word '{word}' in the said string: {i+1}");
        }
    }
}

var str = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine("Original String: " + str);
//FindPosition(str,"fox");
//FindPosition(str,"The");
//FindPosition(str,"lazy");



//28. Write a C# Sharp program to alternate the case of each letter in a given string. The first letter of this string must be uppercase.

static string Chaos(string s)
{
    var arr = s.ToCharArray();

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0 || i % 2 == 0)
            arr[i] = char.ToUpper(arr[i]);
        else
            arr[i] = char.ToLower(arr[i]);
    }

    return new string(arr);
}
string s = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
//Console.WriteLine("Original String: "+s);
//Console.WriteLine("After: \n"+Chaos(s));


//29. Write a C# Sharp program to reverse all the words of a given string with even length.
void EvenReverse(string s)
{

    var arr = s.Split();
    foreach (var word in arr)
    {
        if (word.Length%2==0)
        {
            for (int i = word.Length -1; i >=0; i--)
            {
                Console.Write(word[i]);
            }

            Console.Write(" ");
        }
        else
        {
            Console.Write(word+" ");
        }
    }
}

var s2 = "C# is used to develop web apps , desktop apps , mobile apps , games and much more.";
//Console.WriteLine("Original String: " + s2);
//EvenReverse(s2);



//30. Write a C# Sharp program to find the longest common ending between two given strings
 string Ending(string st1, string st2)
{
    for (int i = 0; i < st1.Length; i++)
    {
        var end = st1.Substring(i);
        if (st2.EndsWith(end))
        {
            return end;
        }
    }
    return "";
}
var str1 = "running";
var str2 = "ruminating";
//Console.WriteLine($"Original String: {str1} {str2}");
//Console.WriteLine($"Common ending between said two strings: {Ending(str1,str2)}");
