using System;

namespace Co.Edu.Uptc.Csharp.SimpleList
{
    public class SimpleList<T>
    {
        private Node<T>? head;

        public SimpleList()
        {
            head = null;
        }

        public SimpleList(Node<T> head)
        {
            this.head = head;
        }

        public bool Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temporalNode = head;
                while (temporalNode.Next != null)
                {
                    temporalNode = temporalNode.Next;
                }
                temporalNode.Next = newNode;
            }
            return true;
        }

        public T? Get(int index)
        {
            Node<T>? temporalNode = head;
            if (index >= 0 && index < Size())
            {
                for (int i = 0; i <= index; i++)
                {
                    if (index == i)
                    {
                        return temporalNode!.Value;
                    }
                    temporalNode = temporalNode!.Next;
                }
            }
            return default;
        }

        public int Size()
        {
            Node<T>? temporalNode = head;
            int size = 0;
            while (temporalNode != null)
            {
                size++;
                temporalNode = temporalNode.Next;
            }
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public bool Remove(object? o)
        {
            if (head == null || o == null) return false;

            bool isFounded = false;
            Node<T>? actual = head;
            Node<T>? previous = head;
            if (actual.Value != null && actual.Value.Equals(o))
            {
                head = head.Next;
                isFounded = true;
            }
            else
            {
                while (actual != null && !isFounded)
                {
                    if (actual.Value != null && actual.Value.Equals(o))
                    {
                        previous!.Next = actual.Next;
                        isFounded = true;
                    }
                    else
                    {
                        previous = actual;
                        actual = actual.Next;
                    }
                }
            }
            return isFounded;
        }

        public bool Contains(object? o)
        {
            if (o == null) return false;

            Node<T>? temporalNode = head;
            while (temporalNode != null)
            {
                if (temporalNode.Value != null && temporalNode.Value.Equals(o))
                {
                    return true;
                }
                temporalNode = temporalNode.Next;
            }
            return false;
        }
    }
}