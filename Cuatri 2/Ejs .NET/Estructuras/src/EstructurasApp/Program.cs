using EstructurasLibrary;

var pila = new Stack<int>();

var miPila = new MyStack<int>();

miPila.Push(1); // head -> [1] -> null 
miPila.Push(2); // head -> [2] -> [1] -> null
miPila.Push(3); // head -> [3] -> [2] -> [1] -> null

Console.WriteLine(miPila.Pop()); 
Console.WriteLine(miPila.Pop());  
Console.WriteLine(miPila.Pop()); 

var miCola = new MyQueue<int>();

miCola.Enqueue(1); // first -> [1] -> null <- last
miCola.Enqueue(2); // first -> [1] -> [2] -> null
miCola.Enqueue(3); // first -> [1] -> [2] -> [3] -> null

Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());

Console.WriteLine("Ejercicio 1 de pilas");

var navegador = new Browser();
navegador.GoTo("google.com");
navegador.GoTo("facebook.com");
navegador.GoTo("twitter.com");
navegador.GoBack();
navegador.GoTo("linkedin.com");

navegador.PrintHistory();