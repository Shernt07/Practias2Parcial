using System;

namespace DesafioIf3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero = 0, Suma = 0, Promedio, Contador =0 ;
            string desicion = "";
            //Console.WriteLine("Ingrese los valores");
            //numero = int.Parse(Console.ReadLine());

            while (desicion != "fin")
            {
                Console.Write("Ingrese los valores: ");
                numero = int.Parse(Console.ReadLine());

                Suma = Suma + numero;
                Contador += 1;
                Promedio = Suma / Contador;
                Console.Write("Para terminar escriba fin, si no cualquier otra tecla\n");
                desicion = (Console.ReadLine());
                
            }
                Promedio = Suma / Contador;
            Console.WriteLine($"\nEl promedio del alumno es de: {Promedio}\n");

            Console.ReadKey();
                
        }
    }
}
