using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            do
            {
                Console.Clear();
                int Count;
                int Facto;
                int Resul = 1;
                Console.Write("Escriba un numero para sacar su factorial: ");
                Facto = int.Parse(Console.ReadLine());

                for (Count = 1; Count <= Facto; Count++)
                {
                    Resul = Resul * Count;
                }
                Console.WriteLine($"\nEL resultado es: {Resul}\n");

                Console.WriteLine("Para continuar presione enter si desea salir Ctrl + C");
                Console.ReadKey();
            } while (true);
        }
    }
}
