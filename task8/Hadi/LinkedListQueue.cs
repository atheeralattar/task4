 internal class LinkedListQueue<T>
    {
        public int Count { get; set; }
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }
        public void Display()
        {
            int index = 1;
            var node = Front;
            while (index != Count + 1)
            {
                Console.WriteLine("Queue Element {0} : {1}", index, node.Data.ToString());
                node = node.Next;
                index++;
            }
        }
        public void Queue(Node<T> node)
        {
            if (Count == 0)
            {
                Front = node;
                Rear = node;
            }
            if (Count > 0)
            {
                var tempNode = Rear;
                node.Previous = tempNode;
                tempNode.Next = node;
            }
            Rear = node;
            Count++;
        }
        public void Queue(T Element)
        {
            Node<T> node = new Node<T>(Element);
            Queue(node);
        }

        public T DeQueue()
        {
            var temp = Front.Data;
            if (Count == 1)
            {
                Rear = null;
                Front = null;
                Count = 0;
            }
            if (Count > 1)
            {
                var tempNode = Front.Next;
                tempNode.Previous = null;
                Front = tempNode;
                Count--;
            }
            return temp;
        }

        //6.Write a C# program to reverse the elements of a queue.
        public void Reverse() 
        {
            var temp = Count;
            Stack<T> stack = new Stack<T>();
            while (temp > 0)
            {
                stack.Push(DeQueue());
                temp--;
            }
            temp = Count;
            while (stack.Count > 0)
            {
                Queue(stack.Pop());
            }
        }

        //9.Write a C# program to find the maximum element in a queue.
        public T Max() 
        {
            var temp = Count-1;
            var TempNode = Front.Next;
            var Max = Front.Data;
            while (temp > 0)
            { 
                if (Convert.ToInt64 (Max)< Convert.ToInt64(TempNode.Data))
                {
                    Max = TempNode.Data;
                }
                TempNode = TempNode.Next;
                temp--;
            }
            return Max;
        }
  }
