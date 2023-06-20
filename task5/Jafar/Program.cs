using ConsoleApp2;

//LinkedList l = new LinkedList();
//l.AddFirst("Python");
//l.AddFirst("JS");
//l.AddFirst("C#");
//l.PrintLinkedList();

//Q17
//Console.WriteLine(l.GetIndex("Python"));
//Q18
//Console.WriteLine(l.IsExist("C#"));
//

//CircularLinkedList cll = new CircularLinkedList();
//cll.Q4();

void IsContainCSharp(string s)
{
    if (s.ToLower().Contains("c#"))
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
