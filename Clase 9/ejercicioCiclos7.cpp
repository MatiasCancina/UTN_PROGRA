#include <iostream>
using namespace std;

int main()
{
    int numeroA, numeroB, opcionUsuario;
    string otraOperacion = "SI";

    while (otraOperacion == "SI" || otraOperacion == "si")
    {
        // pedir los numeros
        cout << " Ingrese el primer numero: ";
        cin >> numeroA;

        cout << " Ingrese el segundo numero: ";
        cin >> numeroB;

        // mostrar las opciones
        cout << "Que desea hacer con los numeros?" << endl;
        cout << "1: SUMA || 2: RESTA || 3: MULTIPLICACIÓN || 4 DIVISIÓN" << endl;

        cin >> opcionUsuario;

        // realizar operacion segun la opcion elegida
        switch (opcionUsuario)
        {
        case 1:
            cout << numeroA + numeroB;
            break;
        case 2:
            cout << numeroA - numeroB;
            break;
        case 3:
            cout << numeroA * numeroB;
            break;
        case 4:
            if (numeroB != 0)
            {
                cout << numeroA / numeroB;
            }
            else
                cout << "No se puede dividir por cero";
            break;
        default:
            cout << " Su opcion no existe";
            break;
        }

        cout << endl << "Desea realizar otra operacion? (SI / NO)";
        cin >> otraOperacion;
    }
}