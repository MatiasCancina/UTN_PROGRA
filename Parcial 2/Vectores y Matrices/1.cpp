//? Ingresar un valor N (< 25). Generar un arreglo de N componentes en el cual las mismas contengan los primeros números naturales pares e imprimirlo.

#include <iostream>
using namespace std;

int main() {
    const int MAX = 25;
    int N;
    int arr[MAX];

    // Ingresar un valor N menor que 25
    do {
        cout << "Ingrese un valor N (< 25): ";
        cin >> N;
    } while (N <= 0 || N >= MAX);

    // Generar el arreglo con los primeros N números naturales pares
    for (int i = 0; i < N; i++) {
        arr[i] = i * 2;
    }

    // Imprimir el arreglo
    cout << "Los primeros " << N << " números naturales pares son:" << endl;
    for (int i = 0; i < N; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}