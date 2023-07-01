using System;

internal class LlStack<T>
{
    public int Count { get; set; }
    public Node<T> First { get; set; }
    public Node<T> Top { get; set; }
    public void Display()
    {
        int index = 1;
        var node = First;
        while (index != Count + 1)
        {
            Console.WriteLine("Stack Element {0} : {1}", index, node.Data.ToString());
            node = node.Next;
            index++;
        }
    }
    public void Push(Node<T> node)
    {
        if (Count == 0)
        {
            First = node;
            Top = node;
        }
        if (Count > 0)
        {
            var tempNode = Top;
            node.Previous = tempNode;
            node.Next = First;
            tempNode.Next = node;
            First.Previous = node;
        }
        Top = node;
        Count++;
    }
    public T Pop()
    {
        var temp = Top.Data;
        if (Count == 1)
        {
            Top = null;
            First = null;
            Count = 0;
        }
        if (Count > 1)
        {

            var TempNode = Top.Previous;
            TempNode.Next = First;
            First.Previous = TempNode;
            Top = TempNode;
            Count--;
        }
        return temp;
    }
    public void Peek()
    {

        if (Count == 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        else
            Console.WriteLine("The topmost element of Stack is : {0}", Top.Data.ToString());
    }
    //17.Write a C# program to merge two stacks into one.
    public void Merge(LlStack<T> stack)
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("The Stack is Empty");
            return;
        }
        var TempNodeFirst = stack.First;
        var TempNodeTop = stack.Top;
        var StackCount = stack.Count;
        Top.Next = TempNodeFirst;
        TempNodeFirst.Previous = Top;
        TempNodeTop.Next = First;
        First.Previous = TempNodeTop;
        Top = TempNodeTop;
        Count += StackCount;
    }
    //18.Write a C# program that implements a stack and checks if a stack is a subset of another stack.
    public bool SubsetOF(LlStack<T> stack)
    {
        var tempNode = this.First;
        while (tempNode.Next != this.First)
        {
            if (tempNode.Data.Equals(stack.First.Data))
            {
                var stackTempNode = stack.First;
                var stackCount = stack.Count;
                while (stackCount > 0)
                {
                    if (!tempNode.Data.Equals(stackTempNode.Data))
                    {
                        return false;
                    }
                    tempNode = tempNode.Next;
                    stackTempNode = stackTempNode.Next;
                    stackCount--;
                }
                return true;
            }
            tempNode = tempNode.Next;
        }
        return false;
    }
    //19.Write a C# program that implements a stack and checks if two stacks are equal.
    public bool IsEqualWith(LlStack<T> stack)
    {
        if (stack.Count == Count)
        {
            var TempNode = this.First;
            var StackNode = stack.First;
            var StackCount = stack.Count;
            while (StackCount > 0)
            {
                if (!TempNode.Data.Equals(StackNode.Data))
                {
                    return false;
                }
                StackNode = StackNode.Next;
                TempNode = TempNode.Next;
                StackCount--;
            }
            return true;
        }
        return false;
    }
    //20.Write a C# program that implements a stack and finds common elements between two stacks.
    public void CommonWith(LlStack<T> stack)
    {
        LlStack<T> TempStack = new LlStack<T>();
        var TempNode = this.First;
        var TempStackNode = stack.First;
        while (TempNode.Next != First)
        {
            TempStackNode = stack.First;
            while (TempStackNode.Next != stack.First)
            {
                if (TempStackNode.Data.Equals(TempNode.Data))
                {
                    Node<T> node = new Node<T>(TempNode.Data);
                    TempStack.Push(node);
                }
                TempStackNode = TempStackNode.Next;
            }
            if (TempStackNode.Data.Equals(TempNode.Data))
            {
                Node<T> node = new Node<T>(TempNode.Data);
                TempStack.Push(node);
            }
            TempNode = TempNode.Next;
        }
        if (TempStackNode.Data.Equals(TempNode.Data))
        {
            Node<T> node = new Node<T>(TempNode.Data);
            TempStack.Push(node);
        }
        TempStack.Display();
    }

}
