//q5

﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> s = new Stack<int>();

        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        s.Push(5);
        s.Push(6);
        s.Push(7);
        s.Push(8);
        s.Push(9);
        s.Push(10);

        int maxNumb = FindMaxNumb(s);
        Console.WriteLine("The maximum number is " + maxNumb);
    }

    static int FindMaxNumb(Stack<int> s)
    {
        if (s.Count == 0) throw new InvalidOperationException("Stack is empty");

        int maxNumb = Int32.MinValue;

        foreach (int item in s)
        {
            if (item > maxNumb)
            {
                maxNumb = item;
            }
        }

        return maxNumb;
    }
}


//q6


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> s = new Stack<int>();

        s.Push(10);
        s.Push(5);
        s.Push(8);
        s.Push(3);
        s.Push(12);
        s.Push(1);
        s.Push(6);
        s.Push(4);
        s.Push(9);
        s.Push(2);

        int minNumb = FindMinNumb(s);
        Console.WriteLine("The minimum number is " + minNumb);
    }

    static int FindMinNumb(Stack<int> s)
    {
        if (s.Count == 0) throw new InvalidOperationException("Stack is empty");

        int minNumb = int.MaxValue;

        foreach (int item in s)
        {
            if (item < minNumb)
            {
                minNumb = item;
            }
        }

        return minNumb;
    }
}


//q7

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> s = new Stack<int>();

        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        s.Push(5);

        Console.WriteLine("Stack before removing elements:");
        PrintStack(s);

        RemoveAllElements(s);

        Console.WriteLine("Stack after removing elements:");
        PrintStack(s);
    }

    static void RemoveAllElements(Stack<int> s)
    {
        s.Clear();
    }

    static void PrintStack(Stack<int> s)
    {
        foreach (int item in s)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
