
using System;
using _20260414___Clase_09.Clases;

try
{
    Micro micro = new Micro(300, 5, 1);

    Moderado moderado = new Moderado(5);
    moderado.EsJefe = true;
    micro.Subir(moderado);
    Fiaca fiaca = new Fiaca();
    micro.Subir(fiaca);

    Claustrofobico claustrofobico = new Claustrofobico();
    micro.Subir(claustrofobico);


    Obsecuente empleadoObsecuente = new Obsecuente(fiaca);
    Obsecuente empleadoObsecuente2 = new Obsecuente(empleadoObsecuente);
    micro.Subir(empleadoObsecuente);
    micro.Subir(empleadoObsecuente2);

}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error no esperado. " + ex.Message);
}



// try
// {


//     double resultado = Math.Pow(5, 2);

//     Console.WriteLine("El resultado es: " + resultado);

//     Console.WriteLine("Cantidad de operaciones realizadas" + Calculadora.CantidadDeOperacionesRealizadas);
//     int resultadoSuma = Calculadora.Suma(5, 10);
//     Console.WriteLine("Cantidad de operaciones realizadas" + Calculadora.CantidadDeOperacionesRealizadas);
//     Calculadora objCalculadora = new Calculadora();

//     int resultadoResta = objCalculadora.Resta(10, 5);

//     Console.WriteLine("Cantidad de operaciones realizadas" + Calculadora.CantidadDeOperacionesRealizadas);

//     Console.WriteLine("El resultado de 5 + 10 es: " + resultadoSuma);
//     Console.WriteLine("El resultado de 10 - 5 es: " + resultadoResta);

//     Console.WriteLine("El valor de PI es : " + Calculadora.ValorPI);

//     Calculadora.Operacion operacion = Calculadora.Operacion.Suma;
//     Console.WriteLine("La operación es: " + operacion);

//     DayOfWeek dia = DayOfWeek.Monday;
//     DateTime fecha = new DateTime(2026, 4, 14);
//     dia = fecha.DayOfWeek;
//     Console.WriteLine("El día de la semana es: " + dia);

// }
// catch (FormatException ex)
// {
//     Console.WriteLine("El formato de la edad ingresada no es correcto. Usted es un maravilloso usuario " + ex.Message);
// }
// catch(DivideByZeroException  ex)
// {
//     Console.WriteLine("Uste d quiere dividir por cero y eso no se puede. ¡Animos!" + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Ha ocurrido un error no esperado. Usted es un maravilloso usuario " + ex.Message);
// }

// public class Calculadora
// {

//     public enum Operacion
//     {
//         Suma,
//         Resta,
//         Multiplicacion,
//         Division
//     }

//     public static int CantidadDeOperacionesRealizadas = 0;
//     public static readonly double ValorPI = 3.14;
//     public static int Suma(int a, int b)
//     {
//         CantidadDeOperacionesRealizadas++;
//         return a + b;
//     }

//     public int Resta(int a, int b)
//     {
//         return a - b;
//     }
// }  





// //Locomotora(double pPeso, double pVelocidadMaxima, double pArrastrePesoUtil)
// // Locomotora locomotora = new Locomotora(10, 100, 1000);

// // Deposito deposito = new Deposito();

// // deposito.AgregarLocomotoraEnFormacion(locomotora, formacion);
