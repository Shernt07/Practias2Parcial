using System;

namespace Desafio_De_if
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Puntaje;
            string JugadorRecord;

            Console.Write("Ingrese su puntaje: ");
            Puntaje = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su nombre: ");
            JugadorRecord = Console.ReadLine();

            Player1(Puntaje,JugadorRecord);
            Console.ReadLine();

        }

        public static void Player1(int Puntaje ,string JugadorRecord)
        {
        

                int PuntajeDelJuego = 1000;
                string Campeón = "Set Hermor";

                if (Puntaje > PuntajeDelJuego)
                {
                    Console.WriteLine($"\nLa nueva puntuación mas alta es: {Puntaje}");
                    Console.WriteLine($"La puntación mas alta fue lograda por: {JugadorRecord}");
                }
                else
                {
                    Console.WriteLine($"\nLa puntación Record de {PuntajeDelJuego} NO fue superada, Buen intento");
                    Console.WriteLine($"El Campeón {Campeón} sigue en la cima.");
                }

            Console.ReadKey();
        }
    }
}
