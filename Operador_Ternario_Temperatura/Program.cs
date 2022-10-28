using System;

namespace Operador_Ternario_Temperatura
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int Temp;
            string Respuesta;
            Console.Write("\nIngrese la temperatura actual: ");
            Temp = int.Parse(Console.ReadLine());


            Respuesta = Temp <= 15 ? "Hace mucho frio" : Temp >= 16 && Temp <= 28 ? "Hay un clima agradable" : "Hace mucho calor";
            Console.WriteLine(Respuesta);
            //Respuesta = Temp >= 16 && Temp <= 28 ? "Hay un clima agradable" : "";
            //Console.WriteLine(Respuesta);
            //Respuesta = Temp > 28 ? "Hace mucho calor" : "";
            //Console.WriteLine(Respuesta);

            Console.ReadKey();

        }
    }
}
