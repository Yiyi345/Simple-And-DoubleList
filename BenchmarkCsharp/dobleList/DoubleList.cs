using System;

namespace Co.Edu.Uptc.Csharp.DoubleList
{
    public class DoubleList<T>
    {
        private NodeDoubleList<T>? head;
        private int size;

        public DoubleList()
        {
            head = null;
            size = 0;
        }

        public int Size()
        {
            if (size == int.MaxValue)
            {
                return int.MaxValue;
            }
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool Contains(object? o)
        {
            if (o == null)
            {
                throw new ArgumentNullException(nameof(o), "La lista no permite datos nulos");
            }

            NodeDoubleList<T>? auxNode = head;

            while (auxNode != null)
            {
                if (auxNode.Value!.Equals(o))
                {
                    return true;
                }

                auxNode = auxNode.Next;
            }

            return false;
        }

        public object?[] ToArray()
        {
            if (IsEmpty())
            {
                return Array.Empty<object>();
            }

            object?[] array = new object?[size];

            NodeDoubleList<T>? current = head;

            int index = 0;

            while (current != null)
            {
                array[index] = current.Value;
                current = current.Next;
                index++;
            }

            return array;
        }

        public bool Add(T e)
        {
            NodeDoubleList<T> newNode = new NodeDoubleList<T>(e);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                NodeDoubleList<T>? current = head;

                while (current!.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
                newNode.Previous = current;
            }

            size++;

            return true;
        }

        public bool Remove(object? o)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Value!.Equals(o))
            {
                head = head.Next;

                if (head != null)
                {
                    head.Previous = null;
                }

                size--;

                return true;
            }

            NodeDoubleList<T>? aux = head;

            while (aux != null)
            {
                if (aux.Value!.Equals(o))
                {
                    aux.Previous!.Next = aux.Next;

                    if (aux.Next != null)
                    {
                        aux.Next.Previous = aux.Previous;
                    }

                    size--;

                    return true;
                }

                aux = aux.Next;
            }

            return false;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Índice fuera de rango: {index}");
            }

            NodeDoubleList<T>? aux = head;

            for (int i = 0; i < index; i++)
            {
                aux = aux!.Next;
            }

            return aux!.Value;
        }
    }
}