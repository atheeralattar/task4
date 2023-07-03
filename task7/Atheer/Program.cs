using System;
using System.Collections.Generic;
using System.Linq;

namespace StackImplementation
{
    internal class Stack
    {
        public static int Size= 1000;
        public int[] stack = new int[Size];
        public static int Top;

        public Stack()
        {
            Top = -1;
        }


        public void Pop()
        {
            Stack.Top--;
            Console.WriteLine("Top element is popped.");
         
        }

        public void Push(int element)
        {
            stack[++Top] = element;
            Console.WriteLine("Element {0} is pushed:", element);
            StackPrint();
        }


        public void StackPrint()
        {
            Console.WriteLine("------Stack Start-----");
            for (int i = Stack.Top; i >= 0; i--)

            {
                Console.WriteLine(stack[i]);
            }
            Console.WriteLine("------Stack End-----");
        }


        public void IsEmpty()
        {
            Console.WriteLine("Stack is empty: {0}", stack.Length == 0);
        }

        public void FindTop()
        {
            Console.WriteLine("Top element is: {0}", stack[Top]);
        }

        public static void SortStack(int[] stack)
        {
            Array.Sort(stack);
            Console.WriteLine(stack);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            var x = new Stack();
            x.IsEmpty();
            x.Push(10);
            x.Push(200);
            x.Push(130);
            x.Push(40);
            x.Pop();
            x.FindTop();
            x.SortStack(x.stack);
        }
    }
}