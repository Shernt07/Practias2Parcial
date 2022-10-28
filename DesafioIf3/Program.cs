using System;

namespace DesafioIf3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero = 0, Suma = 0, Promedio, Contador =0 ;
            string validacion = "";
            //Console.WriteLine("Ingrese los valores");
            //numero = int.Parse(Console.ReadLine());

            while (validacion != "fin")
            {
                Console.Write("Escriba una calificacion: ");
                numero = int.Parse(Console.ReadLine());
                if (numero>0 && numero<= 10)
                {
                    Suma = Suma + numero;
                    Contador += 1;
                    Promedio = Suma / Contador;
                    Console.Write("Para terminar escriba fin, si no cualquier otra tecla\n");
                    validacion = (Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Calificación no valida, debe ser del 1-10");
                }
            }
                Promedio = Suma / Contador;
            Console.WriteLine($"\nEl promedio del alumno es de: {Promedio}\n");

            Console.ReadKey();
                
        }
    }
}
