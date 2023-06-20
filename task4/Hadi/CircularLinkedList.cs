using System;
class CircularLinkedList<T>
{
    public int Count { get; set; }
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    //1. Write a program in C to create and display a circular linked list.
    public void Display()
    {
        int index = 1;
        var node = Head;
        while (index != Count + 1)
        {
            Console.WriteLine("node {0} : {1}", index, node.data.ToString());
            node = node.Next;
            index++;
        }
    }
    //2. Write a program in C to insert a node at the beginning of a circular linked list.
    public void InsertFirst(Node<T> node)
    {
        if (Count == 0)
        {
            Head = node;
            Head.Next = Head;
            Tail = Head;
        }
        if (Count >= 1)
        {
            var tempNode = Head;
            node.Next = tempNode;
            Tail.Next = node;
            Head = node;
        }
        Count++;
    }
    //3. Write a program in C to insert a node at the end of a circular linked list.
    public void InsertLast(Node<T> node)
    {
        if (Count == 0)
        {
            Head = node;
            Head.Next = Head;
            Tail = Head;
        }
        if (Count >= 1)
        {
            var tempNode = Tail;
            tempNode.Next = node;
            node.Next = Head;
            Tail = node;
        }
        Count++;
    }
    //4. Write a program in C to insert a node at any position in a circular linked list.
    public void InsertAt(Node<T> node, int Position)
    {
        if (Position == 1)
        {
            InsertFirst(node);
            return;
        }
        if (Position == Count + 1)
        {
            InsertFirst(node);
            return;
        }

        int index = 1;
        var tempNode = Head;
        while (index != Position - 1)
        {
            tempNode = tempNode.Next;
            index++;
        }
        node.Next = tempNode.Next;
        tempNode.Next = node;
        Count++;
    }
    //5. Write a program in C to delete a node from the beginning of a circular linked list.
    public void DeleteFirst()
    {
        if (Count == 1)
        {
            Clear();
            return;
        }
        var tempNode = Head.Next;
        Head = tempNode;
        Tail.Next = Head;
        Count--;
    }
    //6. Write a program in C to delete a node from the middle of a circular linked list.
    public void DeleteMiddle()
    {
        if (Count == 1)
        {
            Clear();
            return;
        }
        var tempNode = Head;
        int index = 0;
        while (index != (Count / 2) - 1)
        {
            tempNode = tempNode.Next;
            index++;
        }
        tempNode.Next = tempNode.Next.Next;
        Count--;
    }
    //7. Write a program in C to delete the node at the end of a circular linked list.
    public void DeleteLast()
    {
        if (Count == 1)
        {
            Clear();
            return;
        }

        var tempNode = Head;

        while (tempNode.Next != Head)
        {
            tempNode = tempNode.Next;
        }
        tempNode.Next = Head;
        Tail = tempNode;
        Count--;
    }
    //8. Write a program in C to search an element in a circular linked list.
    public int FindIndex(int item)
    {
        int index = 1;
        var tempNode = Head;
        while (tempNode.Next != Head)
        {
            if (Convert.ToInt64(tempNode.data) == item)
            {
                return index;
            }
            index++;
            tempNode = tempNode.Next;
        }
        if (Convert.ToInt64(tempNode.data) == item)
        {
            return index + 1;
        }
        else
        {
            return -1;
        }
    }
    private void Clear()
    {
        Count = 0;
        Head = null;
        Tail = null;
    }
}
class Node<T>
{
    public T data { get; set; }
    public Node<T> Next { get; set; }
    public Node(T data)
    {
        this.data = data;

        this.Next = null;
    }
}
