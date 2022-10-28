using System;

namespace Descuentos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaración de variables
            int Escritorios;

            //Procesos 
            Console.WriteLine("Cantidad de escritorios a comprar: ");
            Escritorios = int.Parse(Console.ReadLine());

            if (Escritorios < 5)
            {
                Console.WriteLine("10% de descuento");

                if (Escritorios >= 5 && Escritorios <10)
                {
                    Console.WriteLine("20% de descuento");

                    if (Escritorios >= 10)
                    {
                        Console.WriteLine("40% de descuento");
                    }
                }
            }

        }
    }
}
