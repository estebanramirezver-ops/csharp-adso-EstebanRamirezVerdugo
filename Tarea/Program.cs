using System;

class Program
{
    static void Linea()
    {
        Console.WriteLine("==================================================");
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Linea();
        Console.WriteLine("   INICIA LA PARTE DE MATRICES");
        Linea();
        Console.WriteLine();

        Matrices.Ejecutar();

        Console.WriteLine();
        Linea();
        Console.WriteLine("   TERMINA LA PARTE DE MATRICES");
        Console.WriteLine("   INICIA LA PARTE DE VECTORES");
        Linea();

        Vectores.Ejecutar();

        Console.WriteLine();
        Linea();
        Console.WriteLine("   TERMINA LA PARTE DE VECTORES");
        Linea();
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}

class Matrices
{
    static Random rnd = new Random();

    public static void Ejecutar()
    {
        Reto01();
        Reto02();
        Reto03();
        Reto04();
        Reto05();
        Reto06();
        Reto07();
        Reto08();
        Reto09();
        Reto10();
    }

    // ---------- Funciones de apoyo ----------

    // Devuelve una fila de la matriz como texto separado por tabulaciones
    static string FilaTexto(int[,] m, int fila, int cols)
    {
        string texto = "";
        for (int j = 0; j < cols; j++)
        {
            if (j > 0)
            {
                texto = texto + "\t";
            }
            texto = texto + m[fila, j];
        }
        return texto;
    }

    static void ImprimirMatriz(int[,] m, int filas, int cols)
    {
        for (int i = 0; i < filas; i++)
        {
            Console.WriteLine(FilaTexto(m, i, cols));
        }
    }

    // Devuelve los primeros "cantidad" elementos del vector separados por coma
    static string VectorTexto(int[] v, int cantidad)
    {
        string texto = "";
        for (int i = 0; i < cantidad; i++)
        {
            if (i > 0)
            {
                texto = texto + ", ";
            }
            texto = texto + v[i];
        }
        return texto;
    }

    // ---------- Retos ----------

    static void Reto01()
    {
        int N = 3, M = 4;
        int valor = 2;
        int[,] matriz1 = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matriz1[i, j] = rnd.Next(1, 11);
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matriz1[i, j] = matriz1[i, j] * valor;
            }
        }

        Console.WriteLine("Ejercicio 1 (matriz x " + valor + ")");
        ImprimirMatriz(matriz1, N, M);
    }

    static void Reto02()
    {
        int[,] matriz2 = new int[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz2[i, j] = rnd.Next(1, 21);
            }
        }
        int buscado = 7;
        bool encontrado = false;
        int filaEnc = -1, colEnc = -1;

        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 4; i++)
            {
                if (matriz2[i, j] == buscado)
                {
                    encontrado = true;
                    filaEnc = i;
                    colEnc = j;
                    break;
                }
            }
            if (encontrado == true)
            {
                break;
            }
        }

        Console.WriteLine("\nEjercicio 2 (buscando " + buscado + ")");
        ImprimirMatriz(matriz2, 4, 4);
        if (encontrado)
        {
            Console.WriteLine("Encontrado en fila " + filaEnc + ", columna " + colEnc);
        }
        else
        {
            Console.WriteLine("El valor no está en la matriz");
        }
    }

    static void Reto03()
    {
        int[,] matriz3 = new int[4, 5];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz3[i, j] = rnd.Next(0, 100);
            }
        }

        int mayor = matriz3[0, 0];
        int menor = matriz3[0, 0];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matriz3[i, j] > mayor)
                {
                    mayor = matriz3[i, j];
                }
                if (matriz3[i, j] < menor)
                {
                    menor = matriz3[i, j];
                }
            }
        }

        Console.WriteLine("\nEjercicio 3");
        ImprimirMatriz(matriz3, 4, 5);
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }

    static void Reto04()
    {
        double[,] clase = new double[30, 5];
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                clase[i, j] = rnd.Next(0, 41) / 10.0 + 1;   // notas entre 1.0 y 5.0
            }
        }

        Console.WriteLine("\nEjercicio 4");

        Console.WriteLine("a. Promedio por estudiante:");
        for (int i = 0; i < 30; i++)
        {
            double sumaEst = 0;
            for (int j = 0; j < 5; j++)
            {
                sumaEst = sumaEst + clase[i, j];
            }
            Console.WriteLine("Estudiante " + (i + 1) + ": " + (sumaEst / 5).ToString("F2"));
        }

        Console.WriteLine("b. Promedio por asignatura:");
        for (int j = 0; j < 5; j++)
        {
            double sumaAsig = 0;
            for (int i = 0; i < 30; i++)
            {
                sumaAsig = sumaAsig + clase[i, j];
            }
            Console.WriteLine("Asignatura " + (j + 1) + ": " + (sumaAsig / 30).ToString("F2"));
        }

        double sumaTotal = 0;
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                sumaTotal = sumaTotal + clase[i, j];
            }
        }
        Console.WriteLine("c. Promedio general de la clase: " + (sumaTotal / 150).ToString("F2"));
    }

    static void Reto05()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                A[i, j] = rnd.Next(0, 10);
                B[i, j] = rnd.Next(10, 20);
            }
        }

        Console.WriteLine("\nEjercicio 5");
        Console.WriteLine("Antes:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("A: " + FilaTexto(A, i, 3) + "   |   B: " + FilaTexto(B, i, 3));
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int temp = A[i, j];
                A[i, j] = B[i, j];
                B[i, j] = temp;
            }
        }

        Console.WriteLine("Después:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("A: " + FilaTexto(A, i, 3) + "   |   B: " + FilaTexto(B, i, 3));
        }
    }

    static void Reto06()
    {
        int R = 3, S = 5;
        int[,] matriz6 = new int[3, 4];
        int multR = 1;
        int multS = 1;
        int posicion = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (posicion % 2 == 0)
                {
                    matriz6[i, j] = R * multR;
                    multR++;
                }
                else
                {
                    matriz6[i, j] = S * multS;
                    multS++;
                }
                posicion++;
            }
        }

        Console.WriteLine("\nEjercicio 6 (R=" + R + ", S=" + S + ")");
        ImprimirMatriz(matriz6, 3, 4);
    }

    static void Reto07()
    {
        int[,] matriz7 = new int[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz7[i, j] = rnd.Next(0, 100);
            }
        }

        int[] X = new int[12];
        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                X[k] = matriz7[i, j];
                k++;
            }
        }

        // Ordenar de mayor a menor (selección)
        for (int i = 0; i < k - 1; i++)
        {
            int posMayor = i;
            for (int j = i + 1; j < k; j++)
            {
                if (X[j] > X[posMayor])
                {
                    posMayor = j;
                }
            }
            int temp = X[i];
            X[i] = X[posMayor];
            X[posMayor] = temp;
        }

        Console.WriteLine("\nEjercicio 7");
        ImprimirMatriz(matriz7, 3, 4);
        Console.WriteLine("Vector X descendente: " + VectorTexto(X, k));
    }

    static void Reto08()
    {
        int filas8 = 4, cols8 = 4;
        int[,] matriz8 = new int[filas8, cols8];
        for (int i = 0; i < filas8; i++)
        {
            for (int j = 0; j < cols8; j++)
            {
                matriz8[i, j] = rnd.Next(1, 21);
            }
        }

        int suma8 = 0, cant8 = 0;
        if (filas8 == cols8)
        {
            // Matriz cuadrada: elementos sobre la diagonal principal
            for (int i = 0; i < filas8; i++)
            {
                for (int j = 0; j < cols8; j++)
                {
                    if (j > i)
                    {
                        suma8 = suma8 + matriz8[i, j];
                        cant8++;
                    }
                }
            }
        }
        else
        {
            // No cuadrada: elementos del borde
            for (int i = 0; i < filas8; i++)
            {
                for (int j = 0; j < cols8; j++)
                {
                    if (i == 0 || i == filas8 - 1 || j == 0 || j == cols8 - 1)
                    {
                        suma8 = suma8 + matriz8[i, j];
                        cant8++;
                    }
                }
            }
        }

        Console.WriteLine("\nEjercicio 8");
        ImprimirMatriz(matriz8, filas8, cols8);
        double promedio8 = (double)suma8 / cant8;
        Console.WriteLine("Promedio: " + promedio8.ToString("F2"));
    }

    static void Reto09()
    {
        int filas9 = 4, cols9 = 4;
        int[,] matriz9 = new int[filas9, cols9];
        for (int i = 0; i < filas9; i++)
        {
            for (int j = 0; j < cols9; j++)
            {
                matriz9[i, j] = rnd.Next(1, 21);
            }
        }

        int suma9 = 0, cant9 = 0;
        if (filas9 == cols9)
        {
            // Matriz cuadrada: elementos bajo la diagonal principal
            for (int i = 0; i < filas9; i++)
            {
                for (int j = 0; j < cols9; j++)
                {
                    if (j < i)
                    {
                        suma9 = suma9 + matriz9[i, j];
                        cant9++;
                    }
                }
            }
        }
        else
        {
            // No cuadrada: primera y última columna
            for (int i = 0; i < filas9; i++)
            {
                suma9 = suma9 + matriz9[i, 0] + matriz9[i, cols9 - 1];
                cant9 = cant9 + 2;
            }
        }

        Console.WriteLine("\nEjercicio 9");
        ImprimirMatriz(matriz9, filas9, cols9);
        double promedio9 = (double)suma9 / cant9;
        Console.WriteLine("Promedio: " + promedio9.ToString("F2"));
    }

    static void Reto10()
    {
        int filas10 = 4, cols10 = 4;
        int[,] matriz10 = new int[filas10, cols10];
        for (int i = 0; i < filas10; i++)
        {
            for (int j = 0; j < cols10; j++)
            {
                matriz10[i, j] = rnd.Next(0, 100);
            }
        }

        Console.WriteLine("\nEjercicio 10");
        Console.WriteLine("Antes:");
        ImprimirMatriz(matriz10, filas10, cols10);

        // Ordenar cada columna de menor a mayor (selección)
        for (int j = 0; j < cols10; j++)
        {
            for (int i = 0; i < filas10 - 1; i++)
            {
                int posMenor = i;
                for (int f = i + 1; f < filas10; f++)
                {
                    if (matriz10[f, j] < matriz10[posMenor, j])
                    {
                        posMenor = f;
                    }
                }
                int temp = matriz10[i, j];
                matriz10[i, j] = matriz10[posMenor, j];
                matriz10[posMenor, j] = temp;
            }
        }

        Console.WriteLine("Después:");
        ImprimirMatriz(matriz10, filas10, cols10);
    }
}

class Vectores
{
    static Random rnd = new Random();

    public static void Ejecutar()
    {
        Reto01();
        Reto02();
        Reto03();
        Reto04();
        Reto05();
        Reto06();
        Reto07();
        Reto08();
        Reto09();
        Reto10();
        Reto11();
        Reto12();
        Reto13();
        Reto14();
        Reto15();
        Reto16();
        Reto17();
        Reto18();
        Reto19();
        Reto20();
    }

    // ---------- Funciones de apoyo ----------

    // Devuelve los primeros "cantidad" elementos del vector separados por coma
    static string VectorTexto(int[] v, int cantidad)
    {
        string texto = "";
        for (int i = 0; i < cantidad; i++)
        {
            if (i > 0)
            {
                texto = texto + ", ";
            }
            texto = texto + v[i];
        }
        return texto;
    }

    // Dice si el número n ya está en los primeros "cantidad" elementos del vector
    static bool Contiene(int[] v, int cantidad, int n)
    {
        for (int i = 0; i < cantidad; i++)
        {
            if (v[i] == n)
            {
                return true;
            }
        }
        return false;
    }

    // ---------- Retos ----------

    static void Reto01()
    {
        Console.WriteLine("\nReto 1");
        int[] v = { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Ordenar de mayor a menor (burbuja)
        for (int i = 0; i < v.Length - 1; i++)
        {
            for (int j = 0; j < v.Length - 1 - i; j++)
            {
                if (v[j] < v[j + 1])
                {
                    int temp = v[j];
                    v[j] = v[j + 1];
                    v[j + 1] = temp;
                }
            }
        }

        Console.WriteLine(VectorTexto(v, v.Length));
    }

    static void Reto02()
    {
        Console.WriteLine("\nReto 2");
        Console.WriteLine("Números impares del 1 al 150:");
        for (int n = 1; n <= 150; n += 2)
        {
            Console.WriteLine(n);
        }

        int[] impares = new int[150];
        int cant = 0;
        for (int n = 1; n <= 150; n++)
        {
            if (n % 2 != 0 && n % 5 == 0)
            {
                impares[cant] = n;
                cant++;
            }
        }

        Console.WriteLine("Impares múltiplos de 5: " + VectorTexto(impares, cant));
    }

    static void Reto03()
    {
        Console.WriteLine("\nReto 3");
        int[] multiplos = new int[15];
        for (int i = 0; i < 15; i++)
        {
            multiplos[i] = 4 * (i + 1);
        }

        // El producto es muy grande (más de 10^21), no cabe en long, por eso BigInteger
        decimal producto = 1;
        for (int i = 0; i < 15; i++)
        {
            producto = producto * multiplos[i];
        }

        Console.WriteLine("La multiplicación de los múltiplos de 4 hasta 60 es: " + producto.ToString());
        Console.WriteLine(VectorTexto(multiplos, 15));
    }

    static void Reto04()
    {
        Console.WriteLine("\nReto 4");
        int[] numaleatorio = new int[30];
        for (int i = 0; i < 30; i++)
        {
            numaleatorio[i] = rnd.Next(10, 51);
        }
        Console.WriteLine(VectorTexto(numaleatorio, 30));

        int menor = numaleatorio[0];
        int posicion = 0;
        for (int i = 1; i < 30; i++)
        {
            if (numaleatorio[i] < menor)
            {
                menor = numaleatorio[i];
                posicion = i;
            }
        }
        Console.WriteLine("El número menor es: " + menor + " y su posición es: " + posicion);

        int cantidad = 0;
        for (int i = 0; i < 30; i++)
        {
            if (numaleatorio[i] == menor)
            {
                cantidad++;
            }
        }
        double porcentaje = (double)cantidad / 30 * 100;
        Console.WriteLine("El porcentaje de veces que aparece el número menor es: " + porcentaje.ToString("F2") + "%");
    }

    static bool NumPrimo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Reto05()
    {
        Console.WriteLine("\nReto 5");
        int[] listanums = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18 };

        Console.WriteLine("Los números en la lista son: " + VectorTexto(listanums, listanums.Length));

        int primos = 0;
        int noprimos = 0;

        for (int i = 0; i < listanums.Length; i++)
        {
            if (NumPrimo(listanums[i]))
            {
                primos++;
            }
            else
            {
                noprimos++;
            }
        }

        Console.WriteLine("La cantidad de numeros primos son: " + primos);
        Console.WriteLine("La cantidad de numeros no primos son: " + noprimos);
    }

    static void Reto06()
    {
        Console.WriteLine("\nReto 6");
        int[] nums = new int[60];
        for (int i = 0; i < 60; i++)
        {
            nums[i] = rnd.Next(1, 151);
        }

        int rangomenor = nums[0];
        int rangomayor = nums[0];
        int[] divisibles = new int[60];
        int cantDiv = 0;

        for (int i = 0; i < 60; i++)
        {
            if (nums[i] < rangomenor)
            {
                rangomenor = nums[i];
            }
            if (nums[i] > rangomayor)
            {
                rangomayor = nums[i];
            }
            if (nums[i] % 6 == 0)
            {
                divisibles[cantDiv] = nums[i];
                cantDiv++;
            }
        }

        Console.WriteLine("El número menor es: " + rangomenor);
        Console.WriteLine("El número mayor es: " + rangomayor);
        Console.WriteLine("Los números divisibles por 6 son: " + VectorTexto(divisibles, cantDiv));
    }

    static void Reto07()
    {
        Console.WriteLine("\nReto 7");
        int[] v1 = { 455 };
        int[] v2 = { 456 };
        int[] sumav = new int[v1.Length];

        for (int i = 0; i < v1.Length; i++)
        {
            sumav[i] = v1[i] + v2[i];
        }

        Console.WriteLine("La suma de los vectores es: " + VectorTexto(sumav, sumav.Length));
    }

    static void Reversa(int[] v)
    {
        int i = 0;
        int j = v.Length - 1;

        while (i < j)
        {
            int temp = v[i];
            v[i] = v[j];
            v[j] = temp;
            i++;
            j--;
        }
    }

    static void Reto08()
    {
        Console.WriteLine("\nReto 8");
        int[] v = { 1, 2, 3, 4, 5 };
        Reversa(v);
        Console.WriteLine("El vector invertido es: " + VectorTexto(v, v.Length));
    }

    static void ReversaRango(int n1, int n2)
    {
        while (n1 >= n2)
        {
            Console.WriteLine(n1);
            n1--;
        }
    }

    static void RotarDerecha(int[] v)
    {
        int ultimo = v[v.Length - 1];
        for (int i = v.Length - 1; i > 0; i--)
        {
            v[i] = v[i - 1];
        }
        v[0] = ultimo;
    }

    static void Reto09()
    {
        Console.WriteLine("\nReto 9");
        int[] v = { 1, 2, 3, 4, 5 };
        RotarDerecha(v);
        Console.WriteLine("El vector rotado a la derecha es: " + VectorTexto(v, v.Length));
    }

    static void Reto10()
    {
        Console.WriteLine("\nReto 10");
        int[] v = new int[100];
        for (int i = 0; i < 100; i++)
        {
            v[i] = i + 1;
        }

        int suma = 0;
        for (int i = 0; i < v.Length; i++)
        {
            suma = suma + v[i];
        }
        double prom = (double)suma / v.Length;

        int[] mayores = new int[100];
        int cantMayores = 0;
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] > prom)
            {
                mayores[cantMayores] = v[i];
                cantMayores++;
            }
        }
        Console.WriteLine("Los números mayores al promedio son: " + VectorTexto(mayores, cantMayores));
        Console.WriteLine("El promedio de los números del 1 al 100 es: " + prom);
    }

    static void Reto11()
    {
        Console.WriteLine("\nReto 11");
        int days = 30;
        int[] temperatures = new int[days];
        for (int i = 0; i < days; i++)
        {
            temperatures[i] = rnd.Next(-10, 46);
        }

        Console.WriteLine("Las temperaturas registradas durante los últimos 30 días son: " + VectorTexto(temperatures, days));

        int bajocero = 0;
        int calido = 0;

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] < 0)
            {
                bajocero++;
            }
            if (temperatures[i] > 35)
            {
                calido++;
            }
        }

        Console.WriteLine("El número de días con temperaturas bajo cero es: " + bajocero);
        Console.WriteLine("El número de días con temperaturas mayores a 35 grados es: " + calido);
    }

    static void Reto12()
    {
        Console.WriteLine("\nReto 12");
        int[] v = { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Vector: " + VectorTexto(v, v.Length));

        int[] pares = new int[v.Length];
        int[] impares = new int[v.Length];
        int[] positivos = new int[v.Length];
        int[] negativos = new int[v.Length];
        int cantPares = 0, cantImpares = 0, cantPositivos = 0, cantNegativos = 0;

        for (int i = 0; i < v.Length; i++)
        {
            int n = v[i];

            if (n % 2 == 0)
            {
                pares[cantPares] = n;
                cantPares++;
            }
            else
            {
                impares[cantImpares] = n;
                cantImpares++;
            }

            if (n > 0)
            {
                positivos[cantPositivos] = n;
                cantPositivos++;
            }
            else if (n < 0)
            {
                negativos[cantNegativos] = n;
                cantNegativos++;
            }
        }

        Console.WriteLine("Pares: " + VectorTexto(pares, cantPares));
        Console.WriteLine("Impares: " + VectorTexto(impares, cantImpares));
        Console.WriteLine("Positivos: " + VectorTexto(positivos, cantPositivos));
        Console.WriteLine("Negativos: " + VectorTexto(negativos, cantNegativos));
    }

    static void Reto13()
    {
        Console.WriteLine("\nReto 13");
        int[] A = { 34, 56, 23, 89, 12, 45, 67, 90, 11, 22 };
        int[] B = { 78, 89, 90, 11, 22 };
        int[] C = { 12, 34, 56, 78, 90 };

        // D = A + B + C (concatenados)
        int[] D = new int[A.Length + B.Length + C.Length];
        int pos = 0;
        for (int i = 0; i < A.Length; i++)
        {
            D[pos] = A[i];
            pos++;
        }
        for (int i = 0; i < B.Length; i++)
        {
            D[pos] = B[i];
            pos++;
        }
        for (int i = 0; i < C.Length; i++)
        {
            D[pos] = C[i];
            pos++;
        }

        Console.WriteLine("Vector D: " + VectorTexto(D, D.Length));
    }

    static void Reto14()
    {
        Console.WriteLine("\nReto 14");
        int[] A = { 90 };
        int[] B = { 22 };

        long productoA = 1;
        for (int i = 0; i < A.Length; i++)
        {
            productoA = productoA * A[i];
        }

        long productoB = 1;
        for (int i = 0; i < B.Length; i++)
        {
            productoB = productoB * B[i];
        }

        long producto = productoA * productoB;
        Console.WriteLine("La multiplicación de los elementos de A y B es: " + producto);
    }

    // Genera un vector de números aleatorios (1 a 20) sin repetir
    static int[] GenerarConjunto(int cantidad)
    {
        int[] conjunto = new int[cantidad];
        int llenos = 0;
        while (llenos < cantidad)
        {
            int n = rnd.Next(1, 21);
            if (!Contiene(conjunto, llenos, n))
            {
                conjunto[llenos] = n;
                llenos++;
            }
        }
        return conjunto;
    }

    static void Reto15()
    {
        Console.WriteLine("\nReto 15");
        int[] A = GenerarConjunto(10);
        int[] B = GenerarConjunto(10);
        int[] interseccion = new int[10];
        int cantInter = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (Contiene(B, B.Length, A[i]))
            {
                interseccion[cantInter] = A[i];
                cantInter++;
            }
        }

        Console.WriteLine("A: " + VectorTexto(A, A.Length));
        Console.WriteLine("B: " + VectorTexto(B, B.Length));
        Console.WriteLine("Interseccion: " + VectorTexto(interseccion, cantInter));
    }

    static void Reto16()
    {
        int[] ventas = new int[30];
        for (int i = 0; i < 30; i++)
        {
            ventas[i] = rnd.Next(100, 1100);
        }

        int suma = 0;
        for (int i = 0; i < 30; i++)
        {
            suma = suma + ventas[i];
        }
        double promedio = (double)suma / 30;

        Console.WriteLine("\nEjercicio 16");
        Console.WriteLine("Promedio de ventas: " + promedio.ToString("F2"));
        int contador16 = 0;
        for (int i = 0; i < 30; i++)
        {
            if (ventas[i] > promedio)
            {
                Console.WriteLine("Día " + (i + 1) + " (posición " + i + "): " + ventas[i]);
                contador16++;
            }
        }
        Console.WriteLine("Total de días sobre el promedio: " + contador16);
    }

    static void Reto17()
    {
        int[] edades = new int[500];
        for (int i = 0; i < 500; i++)
        {
            edades[i] = rnd.Next(0, 100);
        }

        int ninos = 0, adolescentes = 0, adultos = 0, ancianos = 0;

        for (int i = 0; i < 500; i++)
        {
            if (edades[i] < 12)
            {
                ninos++;
            }
            else if (edades[i] <= 17)
            {
                adolescentes++;
            }
            else if (edades[i] <= 64)
            {
                adultos++;
            }
            else
            {
                ancianos++;
            }
        }

        Console.WriteLine("\nEjercicio 17");
        Console.WriteLine("Niños: " + ninos);
        Console.WriteLine("Adolescentes: " + adolescentes);
        Console.WriteLine("Adultos: " + adultos);
        Console.WriteLine("Ancianos: " + ancianos);
    }

    static void Reto18()
    {
        int[] codigos = { 101, 102, 101, 103, 102, 101, 104, 103, 101, 102 };

        int[] codigosUnicos = new int[codigos.Length];   // códigos sin repetir
        int[] cantidades = new int[codigos.Length];      // cuántas veces aparece cada uno
        int cantUnicos = 0;

        for (int i = 0; i < codigos.Length; i++)
        {
            bool encontrado = false;

            for (int j = 0; j < cantUnicos; j++)
            {
                if (codigos[i] == codigosUnicos[j])
                {
                    cantidades[j]++;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                codigosUnicos[cantUnicos] = codigos[i];
                cantidades[cantUnicos] = 1;
                cantUnicos++;
            }
        }

        Console.WriteLine("\nEjercicio 18");
        for (int i = 0; i < cantUnicos; i++)
        {
            Console.WriteLine("Producto " + codigosUnicos[i] + ": " + cantidades[i] + " veces");
        }
    }

    static void Reto19()
    {
        int N = 10;
        int[] vector = new int[N];
        for (int i = 0; i < N; i++)
        {
            vector[i] = rnd.Next(1, 51);
        }

        Console.WriteLine("\nEjercicio 19");
        Console.WriteLine("Original: " + VectorTexto(vector, N));

        int[] resultado = new int[N];
        int pos = 0;

        // primero se copian los pares
        for (int i = 0; i < N; i++)
        {
            if (vector[i] % 2 == 0)
            {
                resultado[pos] = vector[i];
                pos++;
            }
        }
        // luego se copian los impares
        for (int i = 0; i < N; i++)
        {
            if (vector[i] % 2 != 0)
            {
                resultado[pos] = vector[i];
                pos++;
            }
        }

        Console.WriteLine("Reorganizado: " + VectorTexto(resultado, N));
    }

    static void Reto20()
    {
        int n = 10;
        int[] datos = new int[n];
        for (int i = 0; i < n; i++)
        {
            datos[i] = rnd.Next(0, 100);
        }

        Console.WriteLine("\nEjercicio 20");
        Console.WriteLine("Antes: " + VectorTexto(datos, n));

        for (int i = 0; i < n - 1; i++)
        {
            int posMenor = i;

            for (int j = i + 1; j < n; j++)
            {
                if (datos[j] < datos[posMenor])
                {
                    posMenor = j;
                }
            }

            // intercambiar el menor encontrado con la posición i
            int temp = datos[i];
            datos[i] = datos[posMenor];
            datos[posMenor] = temp;
        }

        Console.WriteLine("Después: " + VectorTexto(datos, n));
    }
}