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
Console.WriteLine($"Se muestra en este mensaje si hay un numero mayor o igual a 80, sino aparece Miguel es GAY: {(string.Join(", ", mayoro80))}");