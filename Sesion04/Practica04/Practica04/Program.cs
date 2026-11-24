List<int> pares = [2, 4, 5, 8, 10, 20, 22, 23];

//foreach (int n in pares) { 

//if (n % 2 == 0)
// {
//    Console.WriteLine(String.Join(", ", n));
//}

//}
//var top3 = pares.OrderByDescending(n => n).Take(3).ToList();
//Console.WriteLine(string.Join(", ", top3));

var mayoro80 = pares.Where(n => n >= 80).ToList();
Console.WriteLine($"Números mayores o iguales a 80: {(string.Join(", ", mayoro80))}");