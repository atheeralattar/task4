using System;

public class Node
{
    public int Data;
    public Node Next;
}

public class CircularLinkedList
{
    public Node Head;
    
    // Function to insert a new node at the end of the list
    public void InsertAtEnd(int data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        newNode.Next = Head;

        if (Head != null)
        {
            Node temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
        else
        {
            newNode.Next = newNode; // For the first node
        }
        
        Head = newNode;
    }
    
    // Function to print nodes in a given Circular linked list
    public void Display()
    {
        Node temp = Head;
        if (Head != null)
        {
            do
            {
                Console.WriteLine("Data " + temp.Data);
                temp = temp.Next;
            }
            while (temp != Head);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();
        
        // Prompting user for number of nodes
        Console.WriteLine("Input the number of nodes: ");
        int numNodes = Convert.ToInt32(Console.ReadLine());

        // Prompting user for node values and creating the list
        for(int i = 1; i <= numNodes; i++)
        {
            Console.WriteLine("Input data for node " + i + ":");
            int data = Convert.ToInt32(Console.ReadLine());
            list.InsertAtEnd(data);
        }
        
        Console.WriteLine("Data entered in the list are: ");
        list.Display();
    }
}


