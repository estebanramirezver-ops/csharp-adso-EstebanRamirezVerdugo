using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Vehiculo
    {
        public class Vehiculos
        {
            public string Placa { get; }

            public int Ruedas { get; }

            public Vehiculos(string placa, int ruedas)
            {
                Placa = placa.ToUpper();
                Ruedas = ruedas;
                Console.WriteLine("1. Constructor de Vehiculo");
            }

            public class Carros : Vehiculos
            {
                public int Puestos { get; }

                public Carros(string placa, int puestos) : base(placa, 4)
                {
                    Puestos = puestos;
                    Console.WriteLine("2. Constructor de carro");
                }
            }

        }
    }
}
