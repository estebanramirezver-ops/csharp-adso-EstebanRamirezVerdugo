using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    public class libros
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Paginas { get; private set; }
        public bool Disponible { get; private set; } = true;

        public libros(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;

        }

    }
}
