using System;
using System.Runtime.Remoting.Messaging;

namespace Classes
{



    public class LinkedListCircular
    {

        public linkedListNode head;
        public linkedListNode tail;
        public int count;

        public LinkedListCircular()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddNodeToFront(int data)
        {
            linkedListNode node = new linkedListNode(data);
            if (head == null)
            {
                head = node;
                head.Next = head;


            }
            else
            {
                linkedListNode current = head;

                while (current.Next != head)
                {
                    current = current.Next;
                }

                node.Next = head;
                current.Next = node;
                head = node;
            }


        }

        public void PrintList()
        {
            linkedListNode runner = head;
            while (runner != null)
            {
                if (runner.Prev == null)
                {
                    Console.WriteLine("This is the list head: {0}", runner.Data);

                }
                else if (runner.Next == null)
                {
                    Console.WriteLine("This is the list tail: {0}", runner.Data);
                    break;
                }
                else
                {
                    Console.WriteLine("This is an in between node: {0}", runner.Data);
                }

                runner = runner.Next;
            }
        }


        public void PrintListReversed()
        {
            linkedListNode runner = tail;
            while (runner != null)
            {
                if (runner.Prev == null)
                {
                    Console.WriteLine("This is the list head: {0}", runner.Data);
                    break;

                }

                else
                {
                    Console.WriteLine("This is an in between node: {0}", runner.Data);
                    runner = runner.Prev;
                }


            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            //var list = new LinkedList();
            var list = new LinkedListCircular();
            list.AddNodeToFront(8);
            list.AddNodeToFront(5);
            list.AddNodeToFront(2);
            list.AddNodeToFront(1);
            Console.WriteLine("head: {0}", list.head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next.Data);

        }

    }
}