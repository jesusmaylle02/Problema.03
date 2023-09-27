using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema._03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear(); 

            int maxPersonas = 0;
            int asistentesActuales = 3;

            Console.WriteLine("Ingrese un número máximo de personas: ");
            while (!int.TryParse(Console.ReadLine(), out maxPersonas) || maxPersonas <= 0)
            {
                Console.WriteLine("Error: Por favor ingrese un número válido mayor que cero.");
            }

            Console.WriteLine("========================================");
            Console.WriteLine("El número máximo establecido es de " + maxPersonas + " personas.");
            Console.WriteLine("Presione una tecla para comenzar a contar...");

            Console.ReadKey();

            Console.Clear(); 

            Console.WriteLine("=================================");
            Console.WriteLine("| Asistentes actuales | " + asistentesActuales);
            Console.WriteLine("| Aforo               | " + (asistentesActuales * 100 / maxPersonas) + "%");
            Console.WriteLine("| Máximo              | " + maxPersonas + " personas");
            Console.WriteLine("====================================");

            Console.WriteLine("Presione [i] si ingresa una persona");
            Console.WriteLine("[s] si sale una persona");
            Console.WriteLine("[x] para terminar");

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.I:
                        if (asistentesActuales < maxPersonas)
                        {
                            asistentesActuales++;
                        }
                        break;
                    case ConsoleKey.S:
                        if (asistentesActuales > 0)
                        {
                            asistentesActuales--;
                        }
                        break;
                    default:
                        break;
                }

                Console.Clear(); 

                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " + asistentesActuales);
                Console.WriteLine("| Aforo               | " + (asistentesActuales * 100 / maxPersonas) + "%");
                Console.WriteLine("| Máximo              | " + maxPersonas + " personas");
                Console.WriteLine("====================================");

                Console.WriteLine("Presione [i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");

            } while (key.Key != ConsoleKey.X);

            Console.WriteLine("Gracias por su tiempo<3");

            Console.ReadKey();

        }
    }
}
