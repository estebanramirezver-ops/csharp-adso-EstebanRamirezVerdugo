using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(1, 101);
            bool acierto = false;
            int intentos = 0;
            int maxIntentos = 7;

            Console.WriteLine("Esta prueba va a tratar de acertar un número aleatorio en 7 intentos");
            Console.WriteLine("Elige un número entre 1 y 100");

            do
            {
                Console.Write($"Intento {intentos + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine().Trim());
                intentos++;

                if (numero < secreto)
                {
                    Console.WriteLine("El número secreto es mayor que el que elegiste");
                }
                else if (numero > secreto)
                {
                    Console.WriteLine("El número secreto es menor que el que elegiste");
                }
                else
                {
                    acierto = true;
                    Console.WriteLine($"¡Acertaste en {intentos} intentos!");
                }
            } while (!acierto && intentos < maxIntentos);

            if (!acierto)
            {
                Console.WriteLine($"Perdiste. El número secreto era {secreto}");
            }

        }
    }
}
