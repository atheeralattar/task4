using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}                             //-------Big O = O(1)

public class CircularLinkedList
{
    private Node head;

    public void Insert(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            Node current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Next = head;
        }
    }                             //-------Big O = O(N)

    public void DeleteNode(int position)
    {
        if (head == null)
        {
            Console.WriteLine("Empty");
            return;
        }

        if (position == 0)
        {
            Node lastNode = GetLastNode();
            head = head.Next;
            lastNode.Next = head;
        }
        else
        {
            Node current = head;
            int count = 0;

            while (count < position - 1)
            {
                current = current.Next;
                count++;
            }

            Node nodeToDelete = current.Next;
            current.Next = nodeToDelete.Next;
            nodeToDelete.Next = null;
        }
    }                         //-------Big O = O(N)

    private Node GetLastNode()
    {
        Node current = head;
        while (current.Next != head)
        {
            current = current.Next;
        }
        return current;
    } //-------Big O = O(N)

    public void DisplayList()
    {
        if (head == null)
        {
            Console.WriteLine(" Empty");
            return;
        }

        Node current = head;
        do
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        } while (current != head);
    }
}                        //-------Big O = O(N)

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList myList = new CircularLinkedList();
        myList.Insert(1);
        myList.Insert(2);
        myList.Insert(3);
        myList.Insert(4);
        myList.Insert(5);

        Console.WriteLine("Elements");
        myList.DisplayList();

        int positionToDelete = 2;
        myList.DeleteNode(positionToDelete);

        Console.WriteLine("after Delet" + positionToDelete + ":");
        myList.DisplayList();
    }
}                             //-------Big O = O(1)
