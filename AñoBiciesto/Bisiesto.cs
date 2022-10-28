using System;

namespace AñoBiciesto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //AÑO BISIESTO
            int año;
            do
            {
                Console.Write("Ingrese el año: ");
                año = int.Parse(Console.ReadLine());


                if (año % 4 == 0)
                {
                    //Console.WriteLine($"{año} - Es un año biciesto");
                    if (año % 100 == 0)
                    {
                        if (año % 400 == 0)
                        {
                            Console.WriteLine($"{año} - Es un año biciesto");
                        }


                        else
                        {
                            Console.WriteLine($"{año} - NO es un año biciesto");
                        }


                    }
                    else
                    {
                        Console.WriteLine($"{año} - Es un año biciesto");
                    }
                }
                else
                {
                    Console.WriteLine($"{año} - No es un año biciesto");
                }

                Console.WriteLine("\nEnter continuar, Ctr + C terminar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
