using System;

class Program
{
    static void Main()
    {
        // Permite que la consola muestre bien las tildes y el símbolo °
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ---------- Ejercicio 1: segundos a reloj ----------
        Console.Write("Escribe los segundos: ");
        if (int.TryParse(Console.ReadLine(), out int segundos))
        {
            int horas = segundos / 3600;               // horas completas
            int minutos = (segundos % 3600) / 60;      // minutos que sobran después de las horas
            int segundosRestantes = segundos % 60;     // segundos que sobran después de los minutos
            Console.WriteLine($"{horas} h {minutos} min {segundosRestantes} s");
        }
        else
        {
            Console.WriteLine("Eso no es un número entero.");
        }

        // ---------- Ejercicio 2: grados Celsius a Fahrenheit ----------
        Console.Write("Escribe los grados Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;  // fórmula de conversión
            Console.WriteLine($"{celsius} °C = {fahrenheit:N1} °F");
        }
        else
        {
            Console.WriteLine("Eso no es un número válido.");
        }

        // ---------- Ejercicio 3: promedio de 3 notas ----------
        Console.Write("Nota 1: ");
        bool nota1Valida = double.TryParse(Console.ReadLine(), out double nota1);
        Console.Write("Nota 2: ");
        bool nota2Valida = double.TryParse(Console.ReadLine(), out double nota2);
        Console.Write("Nota 3: ");
        bool nota3Valida = double.TryParse(Console.ReadLine(), out double nota3);

        // Solo calculamos el promedio si las 3 notas son válidas
        if (nota1Valida && nota2Valida && nota3Valida)
        {
            double promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Promedio: {promedio:N1}");
        }
        else
        {
            Console.WriteLine("Alguna nota no es válida.");
        }

        // Esperamos una tecla para que la ventana no se cierre sola
        Console.ReadKey();
    }
}