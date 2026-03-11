//  Una empresa carga los datos del presentismo de sus empleados ingresando por cada empleado: Legajo (entero de 8 dígitos) y por cada día del mes un 1 si se presentó a trabajar o un 0 si faltó. Para simplificar, todos los empleados trabajan 31 días. Realizar un programa que permita:
// a- Cargar los datos de N empleados, siendo N también informado por el usuario
// b- Informar los legajos de los tres empleados con mejor presentismo
// c- Informar el número del día con mayor ausentismo.

#include <iostream>
#include <vector>
using namespace std;

struct Empleado {
    int legajo;
    vector<int> presentismo; // 1 para presente, 0 para ausente
};

void cargarEmpleados(vector<Empleado>& empleados, int N) {
    for (int i = 0; i < N; ++i) {
        Empleado emp;
        cout << "Ingrese legajo del empleado " << (i + 1) << ": ";
        cin >> emp.legajo;
        emp.presentismo.resize(31);
        cout << "Ingrese presentismo para 31 días (1 para presente, 0 para ausente):\n";
        for (int j = 0; j < 31; ++j) {
            cin >> emp.presentismo[j];
        }
        empleados.push_back(emp);
    }
}

int main() {
    int N;
    cout << "Ingrese el número de empleados: ";
    cin >> N;

    vector<Empleado> empleados;
    cargarEmpleados(empleados, N);

    // b- Informar los legajos de los tres empleados con mejor presentismo
    vector<pair<int, int>> presentismoEmpleados; // par<legajo, dias_presentes>
    for (const auto& emp : empleados) {
        int dias_presentes = 0;
        for (int dia : emp.presentismo) {
            dias_presentes += dia;
        }
        presentismoEmpleados.push_back({emp.legajo, dias_presentes});
    }
    
    // c- Informar el número del día con mayor ausentismo.
    vector<int> ausentismoDias(31, 0);
    for (const auto& emp : empleados) {
        for (int j = 0; j < 31; ++j) {
            if (emp.presentismo[j] == 0) {
                ausentismoDias[j]++;
            }
        }
    }

    int dia_mayor_ausentismo = 0;
    for (int j = 1; j < 31; ++j) {
        if (ausentismoDias[j] > ausentismoDias[dia_mayor_ausentismo]) {
            dia_mayor_ausentismo = j;
        }
    }
    cout << "Día con mayor ausentismo: " << (dia_mayor_ausentismo + 1) << endl;

    
    return 0;
}