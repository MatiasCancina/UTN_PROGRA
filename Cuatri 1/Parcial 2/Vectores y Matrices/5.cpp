//? Ingresar un valor entero N(< 30). A continuación ingresar un conjunto UNO y luego otro conjunto DOS, ambos de N componentes.Generar e imprimir otro conjunto TRES intercalando los valores de posición impar de DOS y los valores de posición par de UNO.

#include <iostream>
using namespace std;

int main() {
    const int MAX_SIZE = 30;
    int N;
    int UNO[MAX_SIZE];
    int DOS[MAX_SIZE];
    int TRES[MAX_SIZE * 2]; // TRES tendrá el doble de tamaño

    cout << "Ingrese un valor entero N (< 30): ";
    cin >> N;

    if (N < 1 || N >= MAX_SIZE) {
        cerr << "Valor de N no válido." << endl;
        return 1;
    }

    cout << "Ingrese " << N << " elementos para el conjunto UNO:" << endl;
    for (int i = 0; i < N; i++) {
        cin >> UNO[i];
    }

    cout << "Ingrese " << N << " elementos para el conjunto DOS:" << endl;
    for (int i = 0; i < N; i++) {
        cin >> DOS[i];
    }

    // Intercalar elementos
    int index = 0;
    for (int i = 0; i < N; i++) {
        if (i % 2 == 1) { // Impar en DOS
            TRES[index++] = DOS[i];
        }
        if (i % 2 == 0) { // Par en UNO
            TRES[index++] = UNO[i];
        }
    }

    cout << "Conjunto TRES (intercalado):" << endl;
    for (int i = 0; i < index; i++) {
        cout << TRES[i] << endl;
    }

    return 0;
}