using System;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Programa de formación: ");
        string programa = Console.ReadLine();

        Console.Write("Número de ficha: ");
        string ficha = Console.ReadLine();

        Console.Write("Una frase que te represente: ");
        string frase = Console.ReadLine();

        string titulo = "TARJETA DE PRESENTACIÓN";
        string linea1 = $"Nombre: {nombre}";
        string linea2 = $"Programa: {programa}";
        string linea3 = $"Ficha: {ficha}";
        string linea4 = $"Frase: {frase}";

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔" + new string('═', 48) + "╗");
        Console.WriteLine($"║ {titulo,-46} ║");
        Console.WriteLine("╠" + new string('═', 48) + "╣");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"║ {linea1,-46} ║");
        Console.WriteLine($"║ {linea2,-46} ║");
        Console.WriteLine($"║ {linea3,-46} ║");
        Console.WriteLine($"║ {linea4,-46} ║");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╚" + new string('═', 48) + "╝");

        Console.ResetColor();

        Console.ReadKey();
    }
}