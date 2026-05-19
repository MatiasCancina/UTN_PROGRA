namespace EstructurasLibrary;

public class History : MyStack<string>
{
    public override void Push(string value)
    {
        if (value == null) return;
        base.Push(value);
    }

    public void PrintHistory()
    {
        var aux = new History();
        while (!this.isEmpty())
        {
            var url = this.Pop();
            aux.Push(url);
            Console.WriteLine(url);
        }

        while (!aux.isEmpty())
        {
            this.Push(aux.Pop());
        }
    }
}