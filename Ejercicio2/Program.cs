using System;

namespace Ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //NUMERO MAYOR

            //CONSTRUIR un programa que pida por pantalla 3 numeros y luego diga...
            //Cual es el mayor de los numeros ingresados

            //Declaración de variables
            int Num1;
            int Num2;
            int Num3;

            //&& es para agregar el and y no hacer los anidados

            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                Num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer numero: ");
                Num3 = int.Parse(Console.ReadLine());

                if (Num1 > Num2)
                {
                    if (Num1 > Num3)
                    {
                        Console.WriteLine($"el numero { Num1} es mayor que: {Num2} y {Num3} ");
                    }

                    if (Num2 > Num1)
                    {
                        if (Num2 > Num3)
                        {
                            Console.WriteLine($"El numero {Num2} es mayor que: {Num1} y {Num3}");
                        }
                    }

                    if (Num3 > Num1)
                    {
                        if (Num3 > Num2)
                        {
                            Console.WriteLine($"El numero {Num3} es mayor que: {Num1} y {Num2}");
                        }
                    }
                }

                Console.WriteLine("Desea seguir comparando pare y / o impares presione enter, salir de control c");
                Console.ReadKey();


                //&& es para agregar el and y no hacer los anidados

            } while (true);
        }
    }
}
