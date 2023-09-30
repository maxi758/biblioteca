using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Lector
    {
        string nombre;
        string apellido;
        int dni;
        List<Libro> librosPrestados = new List<Libro>();

        public Lector(string nombre, string apellido, int dni, List<Libro> librosPrestados)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.librosPrestados = librosPrestados;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public List<Libro> LibrosPrestados { get => librosPrestados; set => librosPrestados = value; }


    }
}
