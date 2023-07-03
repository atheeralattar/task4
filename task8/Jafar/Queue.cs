using System;

public class Queue
{
    public int[] queue;
    private int Head = 0;
    private int Tail = 0;
    private int count = 0;
    public int Size;

    public Queue(int size)
    {
        Size = size;
        queue = new int[size];
    }

    public bool IsEmpty => count == 0;
    public bool IsFull => count == Size;

    public void Enqueue(int data)
    {
        if (IsFull)
        {
            Console.WriteLine("Queue Overflow");
            return;
        }

        queue[Tail] = data;
        Tail = (Tail + 1) % Size;
        count++;
    }

    public void Dequeue()
    {
        if (IsEmpty)
            throw new Exception("Queue is Empty");

        var element = queue[Head];
        Head = (Head + 1) % Size;
        count--;
        Console.Write($"\nElement ({element}) Dequeued");
    }

    public void Print()
    {
        Console.Write("\nQueue elements are: ");
        int index = Head;
        for (int i = 0; i < count; i++)
        {
            Console.Write(queue[index] + " ");
            index = (index + 1) % Size;
        }
    }

    public int Sum()
    {
        if (IsEmpty)
            throw new Exception("Queue is Empty");
        var sum = 0;
        int index = Head;
        for (int i = 0; i < count; i++)
        {
            sum += queue[index];
            index = (index + 1) % Size;
        }

        return sum;
    }

    public double Average()
    {
        if (IsEmpty)
            throw new Exception("Queue is Empty");

        var sum = Sum();
        var avg = sum / count;
        return avg;
    }
}