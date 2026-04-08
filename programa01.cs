namespace Programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---SISTEMA DE GIMNASIO---");
            Console.WriteLine("Bienvenido al sistema de gimnasio");
            Console.WriteLine("----ingresa tus datos----");
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Peso:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("----datos ingresados----");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("----gracias por ingresar tus datos----");
            Console.WriteLine("el cliente " + nombre + " tiene " + edad + " años, pesa " + peso + " kg y mide " + altura + " metros.");
            
        }
    }
}