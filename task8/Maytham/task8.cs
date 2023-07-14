using System;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        this.Data = data;
        this.Next = null;
    }
}

public class Queue<T>
{
    private Node<T> front;
    private Node<T> rear;

    public Queue()
    {
        this.front = this.rear = null;
    }

    public void Enqueue(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (this.rear == null)
        {
            this.front = this.rear = newNode;
            return;
        }

        this.rear.Next = newNode;
        this.rear = newNode;
    }

    public void Dequeue()
    {
        if (this.front == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node<T> temp = this.front;
        this.front = this.front.Next;

        if (this.front == null)
        {
            this.rear = null;
        }

        Console.WriteLine("Removed item: " + temp.Data);
    }

    public void PrintQueue()
    {
        Node<T> temp = this.front;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        Console.WriteLine("Queue elements are: ");
        q.PrintQueue();

        q.Dequeue();
        Console.WriteLine("Queue elements are: ");
        q.PrintQueue();

        q.Enqueue(4);
        Console.WriteLine("Queue elements are: ");
        q.PrintQueue();
    }
}
//q13
using System;
using System.Collections.Generic;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        this.Data = data;
        this.Next = null;
    }
}

public class Queue<T>
{
    private Node<T> front;
    private Node<T> rear;

    public Queue()
    {
        this.front = this.rear = null;
    }

    public void Enqueue(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (this.rear == null)
        {
            this.front = this.rear = newNode;
            return;
        }

        this.rear.Next = newNode;
        this.rear = newNode;
    }

    public List<T> DequeueAll()
    {
        List<T> items = new List<T>();
        while (this.front != null)
        {
            items.Add(this.front.Data);
            this.front = this.front.Next;
        }
        return items;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(3);
        q.Enqueue(3);
        q.Enqueue(6);
        q.Enqueue(7);
        q.Enqueue(8);
        q.Enqueue(9);

        List<int> items = q.DequeueAll();
        items.Sort();

        double median;
        int count = items.Count;

        if (count % 2 == 0)
        {
            median = (items[count / 2 - 1] + items[count / 2]) / 2.0;
        }
        else
        {
            median = items[count / 2];
        }

        Console.WriteLine("Median is " + median);
    }
}




//q
