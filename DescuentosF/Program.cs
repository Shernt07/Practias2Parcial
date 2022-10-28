using System;

namespace DescuentosF
{
    class MainClass
    {        
        public static void Main(string[] args)
        {
            do
            {
                inicial();

                Console.WriteLine("\nEntre para continuarl, Ctr + C para finalizar\n");
                Console.ReadKey();
            } while (true);
            
        }


        static void inicial()
        {
            int Escritorios;

            Console.Clear();
            Console.WriteLine("Cantidad de escritorios a comprar: ");
            Escritorios = int.Parse(Console.ReadLine());

            if (Escritorios < 5)
            {
                Console.WriteLine($"el total a pagar con un 10% de descuento es: {descuento(Escritorios, 0.1)}");

            }
            else if (Escritorios >= 5 && Escritorios < 10)
            {
                Console.WriteLine($"El 20% de descuento al precio es igual a {descuento(Escritorios, 0.2)}");
            }
            else
            {
                Console.WriteLine($"El 40% de descuento al precio es igual a {descuento(Escritorios, 0.4)}");
            }
        }


        static double descuento(int cantidadEscritorios, double porcentaje)
        {

            double Precio;
            double Descuento;
            double Total;

            Precio = cantidadEscritorios * 6500;
            Descuento = Precio * porcentaje;
            Total = Precio - Descuento;
            return Total;
        }
    }
}
