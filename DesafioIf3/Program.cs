using System;

namespace DesafioIf3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero = 0, Suma = 0, Promedio, Contador =0 ;

            //string Comprobacion = "fin";

            //while (Comprobacion == "fin")
            //{

            Console.WriteLine("Ingrese los valores");

            numero = int.Parse(Console.ReadLine());

            while (numero > 0 && numero <= 10)
                {
                    Console.WriteLine("Ingrese los valores");

                    numero = int.Parse(Console.ReadLine());

                    Suma += numero;
                    Contador += 1;

                    //Promedio = Suma / Contador;
                }

                Promedio = Suma / Contador;

                Console.WriteLine($"El promedio del alumno es de: {Promedio}");

                //Console.Write("Para dejar de meter numeros pon fin, de lo contrario cualquier otra tecla");

                Console.Write("fin = parar or otra cosa para seguir");
                //Comprobacion = Console.ReadLine();

            //}

            Console.ReadKey();
                
        }
    }
}
