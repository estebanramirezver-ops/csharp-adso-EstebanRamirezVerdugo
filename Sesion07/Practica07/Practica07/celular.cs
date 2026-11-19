using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    public class Celular
    {
        private string _marca = "";
        private int _bateria;

        public Celular(string Marca, int batery = 100)
        {
            Marca = _marca;
            _bateria = Math.Clamp(batery, 0 , 100);
        }

        public string Marca
        {
            get => _marca;
                private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La marca del dispositivo es obligatoria");
                    _marca = value;
                }
            }
        }

        public int batery
        {
            get => _bateria;
            private set
            {
                _bateria = Math.Clamp(value, 0, 100);
            }
        }

        public void load(int porcentaje)
        {
            
        }

        public int batery
        {
            //get { return _bateria; }

            //private set { batery = Math.Min(100, batery + porcentaje); }
        }
    }

}


