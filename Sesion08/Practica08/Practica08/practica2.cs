using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Productos
{
    public string producto { get; set; }
    public int stock { get; set; }


    public Productos(string nombreProducto, int Stock)
    {
        nombreProducto = producto;
        Stock = stock;
    }

    public void Vender(int cantidad)
    {
        if (cantidad > stock)
        {
            throw new StockInsuficienteException(producto, stock);
        }

        stock -= cantidad;
        Console.WriteLine($"Vendiste {cantidad} de {producto}. Quedan {stock}.");
    }
}