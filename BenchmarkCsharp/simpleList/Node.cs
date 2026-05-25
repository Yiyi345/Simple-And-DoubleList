using System;

namespace Co.Edu.Uptc.Csharp.SimpleList
{
    public class Node<T> 
    {
        public T Value { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T value) 
        {
            Value = value;
            Next = null;
        }
    }
}