using System;

namespace Notas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Multiplo de un numero falta

            //Falta el factorial

            //Falta el primo

            //Falta los primeros 3 retos

            string desicion;
            float Calificacion, Acumulado, Promedio, Materias;
            desicion = "";
            Materias = 0;
            Acumulado = 0;
            Promedio = 0;

            while (desicion != "fin")
            {
                Console.Write("Ingrese una Calificacion: ");
                Calificacion = int.Parse(Console.ReadLine());
                Materias++;
                Acumulado = Acumulado + Calificacion;
                Promedio = Acumulado / Materias;
                Console.Write("Desea finalizar [fin] sino Enter: ");
                desicion = (Console.ReadLine());
            }

            Console.WriteLine("El promedio de " + Materias + " es: " + Promedio);
            Console.ReadLine();
        }
    }
}
