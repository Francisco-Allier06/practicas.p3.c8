using   System;

namespace array01
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("---BLOQUE  ARRAYS---");
           //ejercicio 1
           int[] numeros = new int[5]; // declaracion de un array de enteros con 5 elementos
              numeros[0] = 10; // asignacion de valores al array
                numeros[1] = 20;
                numeros[2] = 30;
                numeros[3] = 40;
                numeros[4] = 50;
            Console.WriteLine("ELEMENTOS DEL ARRAY:");
            for (int i = 0; i < numeros.Length; i++) // bucle para imprimir los elementos del array
            {
            
            // ejercicio 2
                Console.WriteLine(numeros[i]);
            }
                string[] peliculas = { "Star Wars", "El Señor de los Anillos", "Matrix", "Inception", "Avatar" }; // declaracion e inicializacion de un array de strings
            Console.WriteLine("PELICULAS FAVORITAS:");
            for (int i = 0; i < peliculas.Length; i++) // bucle para imprimir los elementos del array
            {
                Console.WriteLine(peliculas[i]);
            }

            // ejercicio 3
             int[] notas = {85, 90, 78, 92, 88}; // declaracion e inicializacion de un array de enteros
            Console.WriteLine("NOTAS DE LOS ESTUDIANTES:");
            for (int i = 0; i < notas.Length; i++) // bucle para imprimir los elementos del array
            {
                Console.WriteLine(notas[i]);
            }

            //ejercicio 4
             double[] temperaturas = { 25.5, 30.2, 28.8, 22.1, 27.3 }; // declaracion e inicializacion de un array de doubles
            Console.WriteLine("TEMPERATURAS DIARIAS:");
            for (int i = 0; i < temperaturas.Length; i++) // bucle
            {
                Console.WriteLine(temperaturas[i]);
            }

            // ejercicio 5
             char[] letras = { 'A', 'B', 'C', 'D', 'E' }; // declaracion e inicializacion de un array de chars
            Console.WriteLine("LETRAS DEL ALFABETO:");
            for (int i = 0; i < letras.Length; i++) // bucle para imprimir los elementos del array
            {
                Console.WriteLine(letras[i]);
            }


        }
    }
}    
