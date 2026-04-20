using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        Console.WriteLine("---BLOQUE 5: constantes---");
        
        // explicacion de constantes
        Console.WriteLine("1 TIPO CONSTANTE");
        Console.WriteLine("UNA CONSTANTE ES UN VALOR QUE NO PUEDE CAMBIARSE DESPUES DE HABER SIDO ASIGNADO");
        // ejercicio 1
        const  string nombre = "ANDRES UTZ"; // constante de tipo string
        Console.WriteLine("NOMBRE: " + nombre);
        // ejercicio 2
        const int edad = 20; // constante de tipo entero
        Console.WriteLine("la variable edad es de tipo entero y su valor es: " + edad);
        Console.WriteLine("EDAD: " + edad);
        // ejercicio 3
        const double pi = 3.1416; // constante de tipo double
        Console.WriteLine("la variable pi es de tipo double y su valor es: " + pi);
        Console.WriteLine("PI: " + pi);
        // ejercicio 4
        const char letra = 'A'; // constante de tipo char
        Console.WriteLine("la variable letra es de tipo char y su valor es: " + letra);
        Console.WriteLine("LETRA: " + letra);
        // ejercicio 5
        const bool esMayorDeEdad = true; // constante de tipo booleano
        Console.WriteLine("la variable esMayorDeEdad es de tipo booleano y su valor es: " + esMayorDeEdad);
        Console.WriteLine("ES MAYOR DE EDAD: " + esMayorDeEdad);

    }

}
