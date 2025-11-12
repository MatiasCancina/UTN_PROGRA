// Se dispone de un conjunto de boletas de inscripción de alumnos (100 como máximo) a examen en el mes de mayo. Cada boleta tiene los siguientes datos: apellido, número de legajo, código de materia, día, mes y año del examen. Los datos finalizan con un legajo igual a 0. 
// a. Desarrollar un programa que, a partir del ingreso de las boletas mencionadas, por teclado genere un vector de inscripción de alumnos a exámenes finales según el siguiente diseño: 
// a. 1 Nro.de legajo(8 dígitos) 
// a.2 Código de materia(6 dígitos) 
// a.3 Día del examen(1..31) 
// a.4 Mes del examen(1..12) 
// a.5 Año del examen(4 dígitos) 
// a.6 Apellido(25 caract) 

// b.Dado el vector generado, desarrolle un procedimiento que genere un vector ordenado por número de legajo(cada registro debe tener los campos legajo y apellido y nombre) para todos los alumnos que se inscribieron una o más veces.Cada legajo debe ocupar una posición única y predecible.El intervalo de los legajos es 80001 a 80100 y están todos al menos una vez

#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

struct Boleta {
    int legajo;
    int codigoMateria;
    int dia;
    int mes;
    int anio;
    string apellido;
};

void ingresarBoletas(vector<Boleta>& boletas) {
    Boleta boleta;
    while (true) {
        cout << "Ingrese legajo (0 para terminar): ";
        cin >> boleta.legajo;
        if (boleta.legajo == 0) break;
        cout << "Ingrese codigo de materia: ";
        cin >> boleta.codigoMateria;
        cout << "Ingrese dia del examen: ";
        cin >> boleta.dia;
        cout << "Ingrese mes del examen: ";
        cin >> boleta.mes;
        cout << "Ingrese anio del examen: ";
        cin >> boleta.anio;
        cout << "Ingrese apellido: ";
        cin.ignore();
        getline(cin, boleta.apellido);
        boletas.push_back(boleta);
    }
}

int main() {
    vector<Boleta> boletas;
    ingresarBoletas(boletas);

    vector<pair<int, string>> inscriptos;

    for (const auto& boleta : boletas) {
        if (boleta.legajo >= 80001 && boleta.legajo <= 80100) {
            inscriptos.push_back({boleta.legajo, boleta.apellido});
        }
    }

    // Ordenar por legajo
    sort(inscriptos.begin(), inscriptos.end());
    cout << "Inscriptos ordenados por legajo:\n";
    for (const auto& inscripto : inscriptos) {
        cout << "Legajo: " << inscripto.first << ", Apellido: " << inscripto.second << endl;
    }
    
    return 0;
}
