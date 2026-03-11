// Un programa de facturación, en el cual se puedan ingresar facturas, con sus respectivos clientes y productos, y se pueda obtener al final del día los resultados de la venta. Las estructuras necesarias para poder cargar un conjunto(maximo 100 elementos) de facturas. Cada Factura deberá tener :
// ● Fecha(Contiene 3 valores, dia, mes y anio)
// ● Nro.de Factura
// ● Cliente Numero(entero)
// ● Items con el siguiente detalle(máximo 10 ítems).
// ○ SKU
// ○ Nombre
// ○ Precio
// ○ Cantidad
// Realizar un programa que comience con un menú que permita :
// ● Ingresar Clientes,
// ● Ingresar Facturas,
// ● Cierre de Caja.
// Los productos deben estar precargados por código en un vector.
// Ingreso de clientes : De cada cliente, se debe ingresar Nombre, Apellido y Mail.
// También se le debe asignar un número.
// Generar la estructura que se necesite.
// Ingreso de Facturas : Se debe ingresar todos los datos : Fecha, Nro de Cliente, Nro Factura, Items con SKU y Cantidad.
// Cierre de Caja : Se debe informar :
// ● Total $ de venta de la sesión.
// ● Factura de mayor importe.
// ● Promedio de facturación por factura.
// ● Promedio de items por factura(del total de items de cada factura, aunque sean de un mismo SKU).

#include <iostream>
#include <string>
using namespace std;

struct Fecha {
    int dia;
    int mes;
    int anio;
};

struct Item {
    int SKU;
    string nombre;
    float precio;
    int cantidad;
};

struct Factura {
    Fecha fecha;
    int nroFactura;
    int clienteNumero;
    Item items[10];
    int cantidadItems;
};

struct Cliente {
    int numero;
    string nombre;
    string apellido;
    string mail;
};

const int MAX_CLIENTES = 100;
const int MAX_FACTURAS = 100;
const int MAX_PRODUCTOS = 100;

Cliente clientes[MAX_CLIENTES];
Factura facturas[MAX_FACTURAS];
Item productos[MAX_PRODUCTOS] = {
    {1, "ProductoA", 10.0, 0},
    {2, "ProductoB", 20.0, 0},
    {3, "ProductoC", 30.0, 0}
};

int totalClientes = 0;
int totalFacturas = 0;

void ingresarCliente() {
    if (totalClientes >= MAX_CLIENTES) {
        cout << "No se pueden ingresar más clientes." << endl;
        return;
    }
    Cliente nuevoCliente;
    nuevoCliente.numero = totalClientes + 1;
    cout << "Ingrese nombre del cliente: ";
    cin >> nuevoCliente.nombre;
    cout << "Ingrese apellido del cliente: ";
    cin >> nuevoCliente.apellido;
    cout << "Ingrese mail del cliente: ";
    cin >> nuevoCliente.mail;
    clientes[totalClientes++] = nuevoCliente;
    cout << "Cliente ingresado con número: " << nuevoCliente.numero << endl;
}

void ingresarFactura() {
    if (totalFacturas >= MAX_FACTURAS) {
        cout << "No se pueden ingresar más facturas." << endl;
        return;
    }
    Factura nuevaFactura;
    cout << "Ingrese fecha (dia mes anio): ";
    cin >> nuevaFactura.fecha.dia >> nuevaFactura.fecha.mes >> nuevaFactura.fecha.anio;
    cout << "Ingrese número de factura: ";
    cin >> nuevaFactura.nroFactura;
    cout << "Ingrese número de cliente: ";
    cin >> nuevaFactura.clienteNumero;

    cout << "Ingrese cantidad de ítems (máximo 10): ";
    cin >> nuevaFactura.cantidadItems;
    for (int i = 0; i < nuevaFactura.cantidadItems; i++) {
        int sku, cantidad;
        cout << "Ingrese SKU del ítem " << (i + 1) << ": ";
        cin >> sku;
        cout << "Ingrese cantidad del ítem " << (i + 1) << ": ";
        cin >> cantidad;

        // Buscar el producto por SKU
        bool encontrado = false;
        for (const auto& producto : productos) {
            if (producto.SKU == sku) {
                nuevaFactura.items[i] = producto;
                nuevaFactura.items[i].cantidad = cantidad;
                encontrado = true;
                break;
            }
        }
        if (!encontrado) {
            cout << "Producto con SKU " << sku << " no encontrado." << endl;
            i--; // Repetir este ítem
        }
    }
    facturas[totalFacturas++] = nuevaFactura;
    cout << "Factura ingresada correctamente." << endl;
}

void cierreDeCaja() {
    float totalVentas = 0;
    float mayorImporte = 0;
    int totalItems = 0;

    for (int i = 0; i < totalFacturas; i++) {
        float importeFactura = 0;
        for (int j = 0; j < facturas[i].cantidadItems; j++) {
            importeFactura += facturas[i].items[j].precio * facturas[i].items[j].cantidad;
            totalItems += facturas[i].items[j].cantidad;
        }
        totalVentas += importeFactura;
        if (importeFactura > mayorImporte) {
            mayorImporte = importeFactura;
        }
    }

    cout << "Total de ventas del día: $" << totalVentas << endl;
    cout << "Factura de mayor importe: $" << mayorImporte << endl;
    if (totalFacturas > 0) {
        cout << "Promedio de facturación por factura: $" << (totalVentas / totalFacturas) << endl;
        cout << "Promedio de ítems por factura: " << (float)totalItems / totalFacturas << endl;
    } else {
        cout << "No se ingresaron facturas." << endl;
    }
}

int main() {
    int opcion;
    do {
        cout << "Menú de Facturación:" << endl;
        cout << "1. Ingresar Cliente" << endl;
        cout << "2. Ingresar Factura" << endl;
        cout << "3. Cierre de Caja" << endl;
        cout << "4. Salir" << endl;
        cout << "Seleccione una opción: ";
        cin >> opcion;

        switch (opcion) {
            case 1:
                ingresarCliente();
                break;
            case 2:
                ingresarFactura();
                break;
            case 3:
                cierreDeCaja();
                break;
            case 4:
                cout << "Saliendo del programa." << endl;
                break;
            default:
                cout << "Opción no válida. Intente nuevamente." << endl;
        }
    } while (opcion != 4);

    return 0;
}