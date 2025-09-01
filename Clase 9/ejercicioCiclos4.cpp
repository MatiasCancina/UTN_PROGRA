// Hacer un programa que me pregunte cuántas veces quiero saludarlo, y que repita “hola” la cantidad de veces que lo solicitó el usuario.

#include <iostream>
using namespace std;

int main()
{
    int cantidadSaludos;

    cout << "Cuantas veces queres que te salude? ";
    cin >> cantidadSaludos;

    for (int i = 1; i <= cantidadSaludos; i++)
    {
        cout << "Hola usuario! Este es el saludo " << i << endl;
    }
}