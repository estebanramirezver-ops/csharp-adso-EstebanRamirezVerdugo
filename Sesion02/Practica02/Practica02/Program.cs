using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su usuario: ");
            string user = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Ingrese su contraseña: ");
            string pass = Console.ReadLine().ToLower().Trim();

            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("Sea bienvenido administrador");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
            }

            Console.WriteLine("Bienvenido a la calculadora ");

            Console.WriteLine("Primero, ingrese un valor para la A: ");
            string entrada = Console.ReadLine().ToLower().Trim();
            int A = Convert.ToInt32(entrada);

            Console.WriteLine("Por último, ingrese un valor para la B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la opción que mejor le parezca a usted: \n1.Sumar\n2.Restar\n3.Multiplicar\n4.División\n5.Notas");

            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine($"La suma entre {A} + {B} es {A + B}");
                    break;
                case 2:
                    Console.WriteLine($"La resta entre {A} - {B} es {A - B}");
                    break;
                case 3:
                    Console.WriteLine($"La multiplicación entre {A} x {B} es {A * B}");
                    break;
                case 4:
                    if (B == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }
                    else
                        Console.WriteLine($"La división entre {A} ÷ {B} es {A / B}");
                    break;
                case 5:
                    double nota = Convert.ToDouble(Console.ReadLine());
                    if (nota < 0 && nota > 5)
                        Console.WriteLine("La nota debe ser entre 0.0 y 5.0");
                    else if (nota >= 4.6)
                        Console.WriteLine("Tu nota es Sobresaliente");
                    else if (nota >= 4.0)
                        Console.WriteLine("Tu nota es excelente");
                    else if (nota >= 3.0)
                        Console.WriteLine("Tu nota es regular");
                    break;
                default:
                    Console.WriteLine("Opción Incorreta u operación inválida");
                    break;
            }
   
        }


    }
}