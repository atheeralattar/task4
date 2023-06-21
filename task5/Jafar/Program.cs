using ConsoleApp2;
void IsContainCSharp(string s)
{
    if (Regex.IsMatch(s,"[Cc]#"))
    {
        Console.WriteLine("C# document found.");
    }
    else
    {
        Console.WriteLine("Sorry no C# document!");
    }
}
IsContainCSharp("C# Exercises");
IsContainCSharp("Python Exercises");
IsContainCSharp("Tutorial on c#");
