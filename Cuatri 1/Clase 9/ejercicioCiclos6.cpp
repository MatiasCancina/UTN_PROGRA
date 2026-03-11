// Que un programa te salude mientras le digas hola. Cuando le digas chau termine.

#include <iostream>
using namespace std;

int main()
{
    string saludo;

    cout << "Decime hola para saludarte, o chau para terminar:" << endl;
    cin >> saludo;

    while (saludo == "hola")
    {
        cout << "Hola usuario! Si queres que te salude de nuevo decime hola o chau para despedirnos:" << endl;
        cin >> saludo;
    }
    cout << "Chau! Que tengas un buen dia!";
}