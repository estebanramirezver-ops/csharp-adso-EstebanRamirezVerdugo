Console.OutputEncoding = System.Text.Encoding.UTF8; 
Console.Write("Contraseña: ");
string pass = Console.ReadLine() ?? "";

if (Validarcontrasena(pass))
{
    Console.WriteLine("Contraseña válida siga con el proceso");
}
else
{
    Console.WriteLine("Credenciales Inválidas");
}

static bool Validarcontrasena(string pass)
{
    bool valida = true;

    bool tieneCantidad = pass.Length >= 8;
    bool tieneMayuscula = false;
    bool tieneminuscula = false;
    bool tienenumero = false;
    bool tieneEspacio = false;

    foreach (char c in pass)
    {
        if (char.IsUpper(c))
        {
            tieneMayuscula = true;
        }
        else if (char.IsLower(c))
        {
            tieneminuscula = true;
        }
        else if (char.IsDigit(c))
        {
            tienenumero = true;
        }
        else if (char.IsWhiteSpace(c))
        {
            tieneEspacio = true;
        }
    }

    Console.WriteLine();
    Console.WriteLine("Resultados de la validación");

    if (tieneCantidad)
        Console.WriteLine("✅ - Mínimo 8 caracteres");
    else
        Console.WriteLine("❌ - Mínimo 8 caracteres");

    if (tieneMayuscula)
        Console.WriteLine("✅ - Al menos una mayúscula");
    else
        Console.WriteLine("❌ - Al menos una mayúscula");

    if (tieneminuscula)
        Console.WriteLine("✅ - Al menos una minúscula");
    else
        Console.WriteLine("❌ - Al menos una minúscula");

    if (tienenumero)
        Console.WriteLine("✅ - Al menos un número");
    else
        Console.WriteLine("❌ - Al menos un número");

    if (!tieneEspacio)
        Console.WriteLine("✅ - Sin espacios");
    else
        Console.WriteLine("❌ - Sin espacios");

    int cantidad = 0;

    if (tieneCantidad) cantidad++;
    if (tieneMayuscula) cantidad++;
    if (tieneminuscula) cantidad++;
    if (tienenumero) cantidad++;
    if (!tieneEspacio) cantidad++;

    Console.WriteLine($"Cumple con {cantidad} reglas");

    if (cantidad <= 2)
        Console.WriteLine("Contraseña de Nivel Débil");
    else if (cantidad <= 4)
        Console.WriteLine("Contraseña de Nivel Media");
    else
        Console.WriteLine("Contraseña de Nivel Fuerte");

    if (cantidad < 5)
    {
        valida = false;
    }

    Console.WriteLine();
    return valida;
}