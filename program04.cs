namespace programa04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---BLOQUE TEXTOS NOMBRES----");
            string nombre1 = "Allier";
            string nombre2 = "Francisco";
            Console.WriteLine("TIPO DE DATO TEXTO:(string)");
            Console.WriteLine("se utiliza para representar textos ejemplo un nombre");
         //
           string nombreCompleto = nombre1 + " " + nombre2;
            Console.WriteLine("el nombre completo es: " + nombreCompleto);
            Console.WriteLine("valor guardado: " + nombreCompleto);
            //
            string saludo = "Hola, " + nombre1 + " " + nombre2 + "!";
         //
         string mensaje = saludo + " Bienvenido a la clase de programación.";
            Console.WriteLine(mensaje);
            Console.WriteLine("valor guardado: " + mensaje);
            //
            string despedida = "Nos vemos en la siguiente clase, " + nombre1 + " " + nombre2 + ".";
            Console.WriteLine(despedida);   
                       
        }
    }
}