using System;

namespace task9
{
    class Queue
    {

        private const int Size = 20;
        
        public static int Head { get; set; }
        
        public static int Tail { get; set; }
        
        public int[] Store = new int[Size];

        public Queue()
        {
            Tail = 0;
            Head = 0;
        }

        public bool IsEmpty()
        {
            return Tail == Head;
        }

        public static bool IsFull()
        {
            return (Queue.Head == Queue.Tail + 1) | (Queue.Head == 1 & Queue.Tail == Size); 
        }
        public int Dequeue()
        {
            
            if (IsEmpty())
            {
                Console.WriteLine("Underflow Error!");
                return 0;
            }
            else
            {
                var x = Store[Head];
                if (Head == Size)
                {
                    Head = 1;
                }
                else
                {
                    Head++;
                    
                }
                return x;
            }
            
        }

        public void Enqueue(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Overflow Error!");
            }
            else
            {
                Store[Tail] = element;
                if (Tail == Size)
                {
                    Tail = 1;
                }
                else
                {
                    Tail++;
                }
            }
        }

        public void Print()
        {
            foreach (var element in Store)
            {
                Console.WriteLine(element);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(12);
            myQueue.Enqueue(13);
            myQueue.Enqueue(14);
            myQueue.Print();
            myQueue.Dequeue();
            myQueue.Print();

        }
    }
}
