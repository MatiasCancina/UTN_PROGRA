//? Ingresar un valor entero N (< 25). A continuación ingresar un conjunto VEC de N componentes. Si la suma de las componentes resulta mayor que cero imprimir las de índice impar, sino los otros elementos.

#include <iostream>
using namespace std;    

int main() {
    const int MAX_SIZE = 25;
    int N;
    int VEC[MAX_SIZE];
    int suma = 0;

    cout << "Ingrese un valor entero N (< 25): ";
    cin >> N;

    if (N < 1 || N >= MAX_SIZE) {
        cerr << "Valor de N no válido." << endl;
        return 1;
    }

    cout << "Ingrese " << N << " elementos para el vector VEC:" << endl;
    for (int i = 0; i < N; i++) {
        cin >> VEC[i];
        suma += VEC[i];
    }

    if (suma > 0) {
        cout << "Elementos en índices impares:" << endl;
        for (int i = 0; i < N; i += 2) {
            cout << VEC[i] << endl;
        }
    } else {
        cout << "Elementos en índices pares:" << endl;
        for (int i = 1; i < N; i += 2) {
            cout << VEC[i] << endl;
        }
    }

    return 0;
}