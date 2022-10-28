using System;

namespace Numero_Primo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //PROCESOS
            do
            {
                Console.Clear();
                int Num1 = 2;
                int Pedir;
                int Num2 = 0;
                int Num3;
                Console.Write("Ingrese el numero a examinar: ");
                Pedir = int.Parse(Console.ReadLine());

                while (Num1 < Pedir && Num2 == 0)
                {
                    Num3 = Pedir % Num1;
                    if (Num3 == 0)
                    {
                        Num2 = 1;
                    }
                    else
                    {
                        Num1 = Num1 + 1;
                    }
                }

                if (Num2 == 0)
                {
                    Console.WriteLine($"\nEl numero {Pedir} SI es primo\n");
                }
                else
                {
                    Console.WriteLine($"\nEl numero  {Pedir} NO es primo\n");
                }

                Console.Write("Presione cualquier tecla para seguir o Ctrl + C para salir: ");
                Console.ReadKey();
            } while (true);
           


        }
    }
}
