namespace ConsoleApp2;

public class Stack
{
    public int Top { get; set; }
    public static int Size;
    public int[] stack ;

    public Stack(int size)
    {
        Size = size;
        stack = new int[size];
        Top = -1;
    }

    public bool IsEmpty()
    {
        return Top < 0;
    }

    public bool IsFull()
    {
        return Top >= Size;
    }

    public void Push(int value)
    {
        var t = stack.Length;
        if (IsFull())
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        stack[++Top] = value;
        
    }

    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Underflow");
            return;
        }

       var pop = stack[Top--];
       Console.WriteLine(pop);
    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Underflow");
            return;
        }

        Console.WriteLine($"Top of Stack is: {stack[Top]}");
    }

    public void Print()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Underflow");
            return;
        }

        
        for (int i = Top; i >= 0; i--)
        {
            Console.Write(stack[i]+" ");
        }

        Console.WriteLine();
    }
    public void Clear()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        for (int i = 0; i < Size; i++)
        {
            Pop();
        }
        
    }

}

