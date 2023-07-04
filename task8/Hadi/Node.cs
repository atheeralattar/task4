using System;

    internal class Node <T>
    {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public T Data { get; set; } 
        
        public Node(T Data) 
        {
        this.Data = Data;
        this.Next = null;
        this.Previous = null;
        }
    }
