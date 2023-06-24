using System;
namespace Task6
{
    class Revers
    {
public static void Main(string[] args)
{
    System.Console.WriteLine("Enter a String");
    string Input = Console.ReadLine();
    String Revers = Input;
    string str ;
    char [] ChaRArray = Revers.ToCharArray();
    Array.Reverse(ChaRArray);
    string newString = new string (ChaRArray);
    System.Console.WriteLine(newString.ToUpper());
}
    }
}