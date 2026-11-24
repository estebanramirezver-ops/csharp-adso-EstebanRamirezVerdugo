namespace Practica07
{
    public class Celular
    {
        private string _marca = "";
        private int _bateria;

        public Celular(string marca, int bateria = 100)
        {
            Marca = marca;
            Bateria = bateria;
        }

        public string Marca
        {
            get => _marca;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La marca del dispositivo es obligatoria");
                _marca = value.Trim();
            }
        }

        public int Bateria
        {
            get => _bateria;
            private set => _bateria = Math.Clamp(value, 0, 100);
        }

        public void Cargar(int porcentaje)
        {
            if (porcentaje <= 0)
                throw new ArgumentException("El porcentaje debe ser mayor que 0");
            Bateria += porcentaje;
        }
    }
}
