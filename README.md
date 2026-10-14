# Comparación de instrucciones: Python, JavaScript y C#

En este documento comparo 6 instrucciones básicas en tres lenguajes de programación: **Python**, **JavaScript** y **C#**.

## Tabla comparativa

| # | Instrucción | Python | JavaScript | C# |
|---|-------------|--------|------------|----|
| 1 | Mostrar un mensaje en pantalla | `print("Hola")` | `console.log("Hola");` | `Console.WriteLine("Hola");` |
| 2 | Declarar una variable | `edad = 18` | `let edad = 18;` | `int edad = 18;` |
| 3 | Condicional if | `if edad >= 18:` | `if (edad >= 18) { }` | `if (edad >= 18) { }` |
| 4 | Ciclo for (repetir 5 veces) | `for i in range(5):` | `for (let i = 0; i < 5; i++) { }` | `for (int i = 0; i < 5; i++) { }` |
| 5 | Declarar un arreglo o lista | `numeros = [1, 2, 3]` | `let numeros = [1, 2, 3];` | `int[] numeros = { 1, 2, 3 };` |
| 6 | Definir una función | `def sumar(a, b):`<br>`    return a + b` | `function sumar(a, b) { return a + b; }` | `static int Sumar(int a, int b) { return a + b; }` |

## Diferencias principales

- **Tipado:** en Python y JavaScript no se escribe el tipo de la variable al declararla; en C# sí (`int`, `string`, `double`, etc.).
- **Bloques de código:** Python usa dos puntos (`:`) e indentación; JavaScript y C# usan llaves `{ }`.
- **Fin de instrucción:** JavaScript y C# terminan cada instrucción con punto y coma (`;`); en Python no es necesario.
- **Funciones:** Python usa `def`, JavaScript usa `function` y C# requiere indicar el tipo de retorno y de los parámetros.
