namespace EstructurasLibrary;

public class MyQueue<T>
{
    private MyNode<T> first; // frente de la cola (se extrae de aqui)
    private MyNode<T> last; // final de la cola (se agrega aqui)

    public MyQueue()
    {
        first = null; // cola vacia
        last = null;
    }

    // verificar si esta vacia
    public bool isEmpty()
    {
        return first == null && last == null;
    }

    public void Enqueue(T value)
    {
        var newNode = new MyNode<T>(value);
        if (isEmpty())
        {
            first = newNode; // si la cola esta vacia, el nuevo nodo es el primero y el ultimo
        }
        else
        {
            last.Next = newNode; // el ultimo actual apunta al nuevo
        }
        last = newNode; // el nuevo nodo se convierte en el nuevo ultimo
    }

    // sacar del frente (DESESTRUCTIVO)
    public T Dequeue()
    {
        if (isEmpty())
        {
            return default; // Precaucion: verificar antes de llamar
        }

        T value = first.Value;
        first = first.Next; // el frente pasa a ser el siguiente

        if (first == null) // si la cola queda vacia, actualizar el final
        {
            last = null;
        }

        return value;
    }
}