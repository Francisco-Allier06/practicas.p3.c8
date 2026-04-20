namespace array02
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---BLOQUE ARRAYS 2---");
            //ejercicio 1 foreach con array de enteros
           
           int[]  numeros = new int[10];
           int suma = 0;
           for (int i =0; i < numeros.Length; i++)
           {
            Console.WriteLine("Ingrese un numero:");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
           }
           int mayor = numeros[0];
           int menor = numeros[0];

           foreach (int numero in numeros)
           {
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
           }
           Console.WriteLine("La suma de los numeros es: {0}", suma);
           Console.WriteLine("El numero mayor es: {0}", mayor);
           Console.WriteLine("El numero menor es: {0}", menor);

          // ejercicio 2 foreach con array de strings
              string[] nombres = new string[5];
              Console.WriteLine("Ingrese 5 nombres:");
              for (int i = 0; i < nombres.Length; i++)
              {
                nombres[i] = Console.ReadLine();
              }
              Console.WriteLine("Los nombres ingresados son:");
              foreach (string nombre in nombres)
              {
                Console.WriteLine(nombre);
              }
            // ejercicio 3 foreach con array de doubles
                double[] precios = new double[5];
                Console.WriteLine("Ingrese 5 precios:");
                for (int i = 0; i < precios.Length; i++)
                {
                    precios[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Los precios ingresados son:");
                foreach (double precio in precios)
                {
                    Console.WriteLine(precio);
                }
            // ejercicio 4 foreach con array de chars
                char[] letras = new char[5];
                Console.WriteLine("Ingrese 5 letras:");
                for (int i = 0; i < letras.Length; i++)
                {
                    letras[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Las letras ingresadas son:");
                foreach (char letra in letras)
                {
                    Console.WriteLine(letra);
                }
            // ejercicio 5 foreach con array de booleans
                bool[] respuestas = new bool[5];
                Console.WriteLine("Ingrese 5 respuestas (true/false):");
                for (int i = 0; i < respuestas.Length; i++)
                {
                    respuestas[i] = bool.Parse(Console.ReadLine());
                }
                Console.WriteLine("Las respuestas ingresadas son:");
                foreach (bool respuesta in respuestas)
                {
                    Console.WriteLine(respuesta);
                }
        }   

    }
}