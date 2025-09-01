// Hacer un programa que enumere los números del 1 hasta el que el usuario desee.

#include <iostream>
using namespace std;

int main()
{
    int cantNums;

    cout << "Ingrese la cantidad de numeros que queres enumerar ";
    cin >> cantNums;

    for (int i = 0; i < cantNums; i++)
    {
        cout << i + 1 << endl;
    }
}