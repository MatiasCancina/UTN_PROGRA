//?  Ingresar un valor entero N (< 20). A continuación ingresar un conjunto VEC de N componentes. A partir de este conjunto generar otro FACT en el que cada elemento sea el factorial del elemento homólogo de VEC. Finalmente imprimir ambos vectores a razón de un valor de cada uno por renglón

#include <iostream>
using namespace std;

int factorial(int num) {
    if (num < 0) return 0; // Factorial no definido para negativos
    if (num == 0 || num == 1) return 1;
    int fact = 1;
    for (int i = 2; i <= num; i++) {
        fact *= i;
    }
    return fact;
}

int main() {
    const int MAX_SIZE = 20;
    int N;
    int VEC[MAX_SIZE];
    int FACT[MAX_SIZE];

    cout << "Ingrese un valor entero N (< 20): ";
    cin >> N;

    if (N < 1 || N >= MAX_SIZE) {
        cerr << "Valor de N no válido." << endl;
        return 1;
    }

    cout << "Ingrese " << N << " elementos para el vector VEC:" << endl;
    for (int i = 0; i < N; i++) {
        cin >> VEC[i];
        FACT[i] = factorial(VEC[i]);
    }

    cout << "Vector VEC:" << endl;
    for (int i = 0; i < N; i++) {
        cout << VEC[i] << endl;
    }

    cout << "Vector FACT:" << endl;
    for (int i = 0; i < N; i++) {
        cout << FACT[i] << endl;
    }

    return 0;
}