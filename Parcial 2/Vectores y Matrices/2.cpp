//? Ingresar un valor entero N (< 30) y a continuación un conjunto de N elementos. Si el último elemento del conjunto tiene un valor menor que 10 imprimir los negativos y en caso contrario los demás

#include <iostream>
using namespace std;

int main() {
    const int MAX = 30;
    int N;
    int arr[MAX];

    // Ingresar un valor N menor que 30
    do {
        cout << "Ingrese un valor N (< 30): ";
        cin >> N;
    } while (N <= 0 || N >= MAX);

    // Ingresar N elementos en el arreglo
    cout << "Ingrese " << N << " elementos:" << endl;
    for (int i = 0; i < N; i++) {
        cin >> arr[i];
    }

    // Verificar el último elemento y decidir qué imprimir
    if (arr[N - 1] < 10) {
        cout << "Elementos negativos:" << endl;
        for (int i = 0; i < N; i++) {
            if (arr[i] < 0) {
                cout << arr[i] << " ";
            }
        }
    } else {
        cout << "Elementos no negativos:" << endl;
        for (int i = 0; i < N; i++) {
            if (arr[i] >= 0) {
                cout << arr[i] << " ";
            }
        }
    }
    cout << endl;

    return 0;
}