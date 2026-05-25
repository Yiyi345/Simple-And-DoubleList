namespace Co.Edu.Uptc.Csharp.DoubleList
{
    public class NodeDoubleList<T>
    {
        public T Value { get; set; }
        public NodeDoubleList<T>? Next { get; set; }
        public NodeDoubleList<T>? Previous { get; set; }

        public NodeDoubleList(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}