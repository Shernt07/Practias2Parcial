using System;

namespace Ejercicio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //NUMERO ES PAR O IMPAR

            //Construir un programa que pida un numero y luego diga si este es par o no 

            int Num1;
            //bool Condition = true;
            //string condicion = "si";

            //string Cantidad = Console.ReadLine();


            do
            {
                Console.WriteLine("INGRESE UN NUMERO: ");
                Num1 = int.Parse(Console.ReadLine());

                if (Num1 % 2 == 0)
                {
                    Console.Write("El numero es par");
                }
                else
                {
                    Console.Write("El numero es impar");
                }

                //Console.Write("");
                Console.WriteLine("Desea seguir comparando pare y/o impares presione enter, salir de control c");

                Console.ReadKey();
            } while (true);                
           




        }
    }
}
