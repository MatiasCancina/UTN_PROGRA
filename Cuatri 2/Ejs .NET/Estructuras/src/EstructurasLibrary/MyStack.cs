namespace EstructurasLibrary
{
    public class MyStack<T>
    {
        private MyNode<T> head; // tope de pila (cabeza)

        public MyStack()
        {
            head = null; // pila vacia
        }

        // verificar si esta vacia
        public bool isEmpty()
        {
            return head == null;
        }

        public virtual void Push(T value)
        {
            var newNode = new MyNode<T>(value);
            newNode.Next = head; // el nuevo nodo apunta al ANTIGUO tope
            head = newNode; // el nuevo nodo se convierte en el nuevo tope
        }

        // extraer del tope (DESESTRUCTIVO)
        public T Pop()
        {
            if (isEmpty())
            {
                return default; // Precaucion: verificar antes de llamar
            }

            T value = head.Value;
            head = head.Next; // el tope pasa a ser el siguiente
            return value;
        }
    }
}