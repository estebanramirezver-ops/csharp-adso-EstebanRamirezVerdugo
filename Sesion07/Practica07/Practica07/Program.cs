using Practica07;

Celular celular = new("Samsung", 80);
Console.WriteLine($"{celular.Marca}: {celular.Bateria}%");

celular.Cargar(30);
Console.WriteLine($"Después de cargar: {celular.Bateria}%");

Carros carro = new("abc123", 5);
Console.WriteLine(carro);
