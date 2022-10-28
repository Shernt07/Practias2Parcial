using System;

namespace Ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaración de variables
            int num1;
            int num2;
            int num3;
            string orden;

            //Procedimientos

            Console.WriteLine("Escriba el primer numero: ");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba un segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());
            //Numero mayor
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El numero mayor es {num1} ");
            }

            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"El nuemro mayor es {num2} ");
            }

            if (num3>num1 && num3>num2)
            {
                Console.WriteLine($"El numero mayor es {num3}");
            }
            //Numero medio
            if (num1<num2 && num1>num3)
            {
                Console.WriteLine($"El numero medio es {num1}");
            }
            if (num1<num3 && num1>num2)
            {
                Console.WriteLine($"El numero medio es {num1}");
            }
            if (num2 < num1 && num2 > num3)
            {
                Console.WriteLine($"El numero medio es {num2}");
            }
            if (num2 < num3 && num2 > num1)
            {
                Console.WriteLine($"El numero medio es {num2}");
            }
            if (num3 < num1 && num3 > num2)
            {
                Console.WriteLine($"El numero medio es {num3}");
            }
            if (num3 < num2 && num3 > num1)
            {
                Console.WriteLine($"El numero medio es {num3}");
            }
            //Numero menor
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"El numero menor es {num1} ");
            }

            if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"El nuemro menor es {num2} ");
            }

            if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine($"El numero menor es {num3}");
            }

        }

    }
}
