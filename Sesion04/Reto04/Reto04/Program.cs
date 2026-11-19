int opcion = 0;
const double notaAprobacion = 3.0;

// Separador decimal de tu computador: "," en Colombia, "." en otros países
string separadorDecimal = ".";
if (1.5.ToString().Contains(","))
{
    separadorDecimal = ",";
}

Dictionary<string, List<double>> notasaprendices = new(StringComparer.OrdinalIgnoreCase);

do
{
    Console.WriteLine("\nMarque la opcion que necesite:\n1. Registrar Aprendiz\n2. Agregar nota\n3. Listar todo\n4. Ranking de mayor a menor promedio\n5. Mejores aprendices y cuantos aprobaron\n6. Eliminar Aprendiz\n7. Salir del programa");
    int.TryParse((Console.ReadLine() ?? "").Trim(), out opcion);
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            RegistrarAprendiz();
            break;
        case 2:
            AgregarNota();
            break;
        case 3:
            ListarTodo();
            break;
        case 4:
            Ranking();
            break;
        case 5:
            MejoresYAprobados();
            break;
        case 6:
            EliminarAprendiz();
            break;
        case 7:
            Console.WriteLine("¡Hasta pronto!");
            break;
        default:
            Console.WriteLine("Opción no válida. Elige del 1 al 7.");
            break;
    }
} while (opcion != 7);


// ================= MÉTODOS (uno por opción) =================

void RegistrarAprendiz()
{
    Console.WriteLine("========REGISTRO DEL ALUMNO NUEVO==========");

    Console.WriteLine("Ingrese el nombre del aprendiz: ");
    string nombre = (Console.ReadLine() ?? "").Trim();

    if (nombre == "")
    {
        Console.WriteLine("El nombre no debe estar vacío");
    }
    else if (notasaprendices.ContainsKey(nombre))
    {
        Console.WriteLine("El nombre ya está registrado");
    }
    else
    {
        notasaprendices.Add(nombre, []);   // lista de notas vacía
        Console.WriteLine("Aprendiz '" + nombre + "' registrado.");
    }
}

void AgregarNota()
{
    Console.WriteLine("=========AGREGAR NOTA=========");

    Console.WriteLine("Ingrese el nombre del aprendiz: ");
    string nombre = (Console.ReadLine() ?? "").Trim();

    if (!notasaprendices.TryGetValue(nombre, out List<double>? notas))
    {
        Console.WriteLine("Ese aprendiz no existe");
        return;
    }

    Console.WriteLine("Agregue la nota nueva (0 a 5): ");
    string textoNota = (Console.ReadLine() ?? "").Trim();

    // Acepta 4.5 o 4,5: cambia el punto y la coma por el separador de tu computador
    textoNota = textoNota.Replace(".", separadorDecimal).Replace(",", separadorDecimal);

    bool esNumero = double.TryParse(textoNota, out double nota);

    if (!esNumero)
    {
        Console.WriteLine("Eso no es un número");
    }
    else if (nota > 5.0 || nota < 0)
    {
        Console.WriteLine("La nota ingresada no es válida");
    }
    else
    {
        notas.Add(nota);
        Console.WriteLine("La nota " + nota + " fue agregada a " + nombre);
    }
}

void ListarTodo()
{
    Console.WriteLine("=========LISTADO=========");

    if (notasaprendices.Count == 0)
    {
        Console.WriteLine("No hay aprendices registrados");
        return;
    }

    foreach (var par in notasaprendices)
    {
        if (par.Value.Count == 0)
        {
            Console.WriteLine($"{par.Key,-15} 0 notas · Sin promedio");
        }
        else
        {
            double promedio = par.Value.Average();
            string juicio = "D";

            if (promedio >= notaAprobacion)
            {
                juicio = "A";
            }

            Console.WriteLine($"{par.Key,-15} {par.Value.Count} notas · Promedio {promedio:N1} · Juicio {juicio}");
        }
    }
}

void Ranking()
{
    Console.WriteLine("=========RANKING=========");

    // El Where evita el error de Average() con listas vacías
    var ranking = notasaprendices
        .Where(x => x.Value.Count > 0)
        .OrderByDescending(x => x.Value.Average())
        .ToList();

    if (ranking.Count == 0)
    {
        Console.WriteLine("No hay aprendices con notas");
        return;
    }

    int puesto = 1;
    foreach (var par in ranking)
    {
        Console.WriteLine($"{puesto}. {par.Key,-15} Promedio {par.Value.Average():N1}");
        puesto++;
    }
}

void MejoresYAprobados()
{
    Console.WriteLine("=========MEJORES Y APROBADOS=========");

    var conNotas = notasaprendices
        .Where(x => x.Value.Count > 0)
        .ToList();

    if (conNotas.Count == 0)
    {
        Console.WriteLine("No hay aprendices con notas");
        return;
    }

    double mejorPromedio = conNotas.Max(x => x.Value.Average());
    var mejores = conNotas.Where(x => x.Value.Average() == mejorPromedio).ToList();

    Console.WriteLine($"Mejor promedio: {mejorPromedio:N1}");
    foreach (var par in mejores)
    {
        Console.WriteLine("- " + par.Key);
    }

    int aprobados = conNotas.Count(x => x.Value.Average() >= notaAprobacion);
    Console.WriteLine($"Aprobaron {aprobados} de {conNotas.Count} aprendices");
}

void EliminarAprendiz()
{
    Console.WriteLine("=========ELIMINAR APRENDIZ=========");

    Console.WriteLine("Ingrese el nombre del aprendiz a eliminar: ");
    string nombre = (Console.ReadLine() ?? "").Trim();

    if (notasaprendices.Remove(nombre))
    {
        Console.WriteLine("Aprendiz '" + nombre + "' eliminado");
    }
    else
    {
        Console.WriteLine("Ese aprendiz no existe");
    }
}