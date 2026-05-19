namespace EstructurasLibrary
{
    public class MyNode<T>
    {
        public T Value { get; }
        public MyNode<T> Next { get; set; }

        public MyNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}