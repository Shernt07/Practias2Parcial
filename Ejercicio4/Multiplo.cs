using System;

namespace Ejercicio4
{
    class MainClass
    {
        //NUMERO MULTIPLO DE OTRO
        public static void Main(string[] args)
        {

            int NumEnt;
            int Mult;
            int counter = 0;
            int Respuesta;
            

            Console.WriteLine("Ingrese un numero: ");
            NumEnt = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero para saber si es multiplo: ");
            Mult = int.Parse(Console.ReadLine());

            if (NumEnt % Mult == 0)
            {
                Console.WriteLine("Si es {1} multilpo de {045}", NumEnt, Mult);
            }
            else
            {
                Console.WriteLine("No es {1} multilpo de {0}", NumEnt, Mult);
            }


            /*for (int s=0;s<=1000; s++)
            {
                counter += 1;

                int Respuesta = Mult * counter;
                return Respuesta;
              
            }

            if (Respuesta)
            {
                
            }
            */

            Console.ReadKey();
        
        }
    }
}
