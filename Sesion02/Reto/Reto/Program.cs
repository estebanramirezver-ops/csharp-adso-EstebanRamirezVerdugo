using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;
            int saldo = 500000;
            int depsaldo = 0;
            int retsaldo = 0;
            int opc = 0;
            int intentos = 0;
            bool acceso = false;

            Console.WriteLine("Bienvenido a Bancolombia");

            do
            {
                Console.WriteLine("Ingresa la clave de tu cuenta: ");
                string pass = Console.ReadLine().Trim();

                if (pass == pin.ToString())
                {
                    acceso = true;
                }
                else
                {
                    intentos++;
                    Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
                }
            } while (!acceso && intentos < 3);

            if (acceso)
            {
                do
                {
                    do
                    {
                        Console.WriteLine("\nMarca la opción que necesitas\n1. Consultar Saldo\n2. Depositar\n3. Retirar\n4. Salir\n=============");
                    } while (!int.TryParse(Console.ReadLine().Trim(), out opc));

                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine($"Tu saldo actual es de {saldo}");
                            break;

                        case 2:
                            do
                            {
                                Console.WriteLine("¿Cuanto deseas depositar?");
                            } while (!int.TryParse(Console.ReadLine().Trim(), out depsaldo));

                            Console.WriteLine("¿A donde se dirige el deposito?: ");
                            string envio = Console.ReadLine().ToLower().Trim();

                            if (depsaldo > 0 && depsaldo % 10000 == 0)
                            {
                                saldo += depsaldo;
                                Console.WriteLine("Procesando la información......");
                                Console.WriteLine("Depósito Finalizado =)");
                            }
                            else
                            {
                                Console.WriteLine("Monto incorrecto o no es múltiplo de 10000");
                            }
                            break;

                        case 3:
                            do
                            {
                                Console.WriteLine("¿Cuanto deseas retirar?");
                            } while (!int.TryParse(Console.ReadLine().Trim(), out retsaldo));

                            Console.WriteLine("Ingrese el numero de cuenta a donde se va a retirar el dinero: ");
                            string retiro = Console.ReadLine().ToLower().Trim();

                            if (retsaldo > 0 && retsaldo % 10000 == 0 && retsaldo <= saldo)
                            {
                                saldo -= retsaldo;
                                Console.WriteLine("Procesando la información......");
                                Console.WriteLine("Retiro Finalizado =)");
                            }
                            else
                            {
                                Console.WriteLine("Monto incorrecto, no es múltiplo de 10000 o saldo insuficiente");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Gracias por confiar en nosotros, hasta pronto =(");
                            break;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                } while (opc != 4);
            }
            else
            {
                Console.WriteLine("Alcanzaste los tres intentos, tu cuenta fue baneada por nosotros");
            }
        }
    }
}
