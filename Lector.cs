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

        public Lector(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public List<Libro> LibrosPrestados { get => librosPrestados; set => librosPrestados = value; }

        public void MostrarLector()
        {
            Console.WriteLine("Nombre:", Nombre);
            Console.WriteLine("Apellido:", Apellido);
            Console.WriteLine("DNI:", Dni);
            Console.WriteLine("Préstamos de libros vigentes:", LibrosPrestados.Count);
        }
        public int CantidadPrestamos()
        {
            return LibrosPrestados.Count;
        }
        public bool PedirLibro(Libro libro)
        {
            bool resultado = false;
            if( this.CantidadPrestamos() < 3)
            {
                this.LibrosPrestados.Add(libro);
                resultado = true;
            }
            return resultado;
        }
    }
}
