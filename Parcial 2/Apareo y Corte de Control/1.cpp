// Se dispone un vector de inscripción de alumnos a exámenes finales MAESTROFINALES y otro con las inscripciones del día de hoy DIAFINALES, ambos ordenados ascendente por código de materia y con el siguiente diseño : Nro de legajo(8 dígitos) Código de materia(6 dígitos) ApellidoNombre(cadena)
// Se pide desarrollar un procedimiento que complete un nuevo vector de inscripciones a finales FINALESACT resultante del apareo de los dos vectores anteriores, con el mismo orden y diseño.

#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

struct Inscripcion {
    int legajo;
    int codigoMateria;
    string apellidoNombre;
};

void aparearInscripciones(const vector<Inscripcion>& maestroFinales, const vector<Inscripcion>& diaFinales, vector<Inscripcion>& finalesAct) {
    int i = 0, j = 0;
    while (i < maestroFinales.size() && j < diaFinales.size()) {
        if (maestroFinales[i].codigoMateria == diaFinales[j].codigoMateria) {
            finalesAct.push_back(maestroFinales[i]);
            i++;
            j++;
        } else if (maestroFinales[i].codigoMateria < diaFinales[j].codigoMateria) {
            i++;
        } else {
            j++;
        }
    }
}

int main() {
    vector<Inscripcion> maestroFinales = {
        {12345678, 101010, "Juan Perez"},
        {23456789, 202020, "Maria Gomez"},
        {34567890, 303030, "Luis Rodriguez"}
    };

    vector<Inscripcion> diaFinales = {
        {45678901, 101010, "Ana Torres"},
        {56789012, 202020, "Carlos Sanchez"},
        {67890123, 404040, "Laura Martinez"}
    };

    vector<Inscripcion> finalesAct;
    aparearInscripciones(maestroFinales, diaFinales, finalesAct);

    cout << "Inscripciones a finales activas:\n";
    for (const auto& insc : finalesAct) {
        cout << "Legajo: " << insc.legajo << ", Código de Materia: " << insc.codigoMateria << ", Apellido y Nombre: " << insc.apellidoNombre << endl;
    }

    return 0;
}