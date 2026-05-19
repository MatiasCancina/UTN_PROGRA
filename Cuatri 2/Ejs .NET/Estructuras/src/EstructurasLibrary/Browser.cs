namespace EstructurasLibrary;

public class Browser
{
    public History Historial { get; set; }
    public string CurrentUrl { get; set; }

    public Browser()
    {
        this.Historial = new History();
    }

    public void GoTo(string url)
    {
        this.Historial.Push(this.CurrentUrl); // guardamos la url actual en el historial
        this.CurrentUrl = url;
    }

    public void GoBack()
    {
        this.CurrentUrl = this.Historial.Pop(); // volvemos a la url anterior
    }

    public void PrintHistory()
    {
        this.Historial.PrintHistory();
    }
}