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
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.LibrosPrestados = librosPrestados;
        }

        public Lector(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public List<Libro> LibrosPrestados { get => librosPrestados; set => librosPrestados = value; }

        public void MostrarLector()
        {
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("DNI:" + Dni);
            Console.WriteLine("Préstamos de libros vigentes: " + CantidadPrestamos());
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

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nDNI: " + Dni + "\nPrestamos de libros vigentes:" + CantidadPrestamos() ;
        }
    }
}
