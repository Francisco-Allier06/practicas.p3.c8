namespace program07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---BLOQUE 5 constantes de calculo y control---");
            // ejercicio 1


            const double iva = 0.21; // constante de tipo double
            double precioProducto = 100.0; // variable de tipo double
            double precioConIva = precioProducto * (1 + iva); // calculo del precio con IVA
            bool esPrecioConIvaMayor = precioConIva > precioProducto; // control de comparacion de precios// variable de tipo string para simbolo de peso
            Console.WriteLine("EL PRECIO DEL PRODUCTO ES: " + precioProducto);
            Console.WriteLine("EL PRECIO CON IVA ES: "  + precioConIva);
            Console.WriteLine("EL PRECIO CON IVA ES MAYOR QUE EL PRECIO ORIGINAL " + esPrecioConIvaMayor);


            // ejercicio 2
            const double tasaInteres = 0.05; // constante de tipo double
            double montoPrestamo = 100000.0; // variable de tipo double
            double interesCalculado = montoPrestamo * tasaInteres; // calculo del interes
            bool esPrestamoAprobado = interesCalculado < 5000.0; // control de aprobacion del prestamo
            Console.WriteLine("EL MONTO DEL PRESTAMO ES: " + simboloPeso + montoPrestamo);
            Console.WriteLine("EL INTERES CALCULADO ES: " + simboloPeso + interesCalculado);
            Console.WriteLine("EL PRESTAMO ES APROBADO " + esPrestamoAprobado);


            // ejercicio 3
                    
           const double impuestopais = 0.15; // constante de tipo double
            double ingresoMensual = 50000.0; // variable de tipo double
         double impuestoCalculado = ingresoMensual * impuestopais; // calculo del impuesto
            Console.WriteLine("EL INGRESO MENSUAL ES: " + simboloPeso + ingresoMensual);
            Console.WriteLine("EL IMPUESTO CALCULADO ES: " + simboloPeso + impuestoCalculado);

            // ejercicio 4
            const double descuento = 0.10; // constante de tipo double
            double precioOriginal = 200.0; // variable de tipo double
            double descuentoCalculado = precioOriginal * descuento; // calculo del descuento
            double precioConDescuento = precioOriginal - descuentoCalculado; // calculo del precio con descuento
            Console.WriteLine("EL PRECIO ORIGINAL ES: " + simboloPeso + precioOriginal);
            Console.WriteLine("EL DESCUENTO CALCULADO ES: " + simboloPeso + descuentoCalculado);
            Console.WriteLine("EL PRECIO CON DESCUENTO ES: " + simboloPeso + precioConDescuento);



            // ejercicio 5

            const double tasaCambio = 0.85; // constante de tipo double
            double montoDolares = 1000.0; // variable de tipo double
            double montoEuros = montoDolares * tasaCambio; // calculo del monto en euros
            bool esCambioBeneficioso = montoEuros > montoDolares; // control de beneficio del cambio
            Console.WriteLine("EL MONTO EN DOLARES ES: " + simboloPeso + montoDolares);
            Console.WriteLine("EL MONTO EN EUROS ES: " + simboloPeso + montoEuros);
            Console.WriteLine("ES EL CAMBIO BENEFICIOSO " + esCambioBeneficioso);

                    
                 
            
        }
    }
}