using System;
using System.Collections.Generic;

namespace Task7
{
    class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Stack is empty. Cannot pop item.");
                return default(T);
            }

            T POP = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return POP;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Stack is empty. No item to peek.");
                return default(T);
            }

            return items[items.Count - 1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public int Count()
        {
            return items.Count;
        }

        public bool AllSatisfy(Func<T, bool> condition)
        {
            foreach (var item in items)
            {
                if (!condition(item))
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack of integers
            Stack<int> stack = new Stack<int>();

            // Push elements onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            int poppedItem = stack.Pop();
            Console.WriteLine("Popped item: " + poppedItem);
            int topItem = stack.Peek();
            Console.WriteLine("Top " + topItem);
            bool isEmpty = stack.IsEmpty();
            Console.WriteLine("Is stack empty: " + isEmpty);
            int count = stack.Count();
            Console.WriteLine("Stack count: " + count);

            
            bool cond = stack.AllSatisfy(x => x > 5);
            Console.WriteLine("All elements are greater than 5: " + cond);
        }
    }
}
