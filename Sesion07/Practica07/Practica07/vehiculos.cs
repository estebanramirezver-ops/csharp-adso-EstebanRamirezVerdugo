namespace Practica07
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

        public override string ToString() => $"Placa: {Placa}, Ruedas: {Ruedas}";
    }

    public class Carros : Vehiculos
    {
        public int Puestos { get; }

        public Carros(string placa, int puestos) : base(placa, 4)
        {
            Puestos = puestos;
            Console.WriteLine("2. Constructor de carro");
        }

        public override string ToString() => $"{base.ToString()}, Puestos: {Puestos}";
    }
}
