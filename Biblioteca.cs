using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libroEncontrado = BuscarLibro(titulo);
            if (libroEncontrado == null)
            {
                Libro libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public bool AgregarLibro(Libro libro)
        {
            bool resultado = false;
            Libro libroEncontrado = BuscarLibro(libro.Titulo);
            if (libroEncontrado == null)
            {
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void MostrarLibros()
        {
            foreach (Libro libro in libros)
            {
                libro.MostrarLibro();
                Console.WriteLine();
            }
        }

        public Libro BuscarLibro(string titulo)
        {
            Libro libroEncontrado = null;
            foreach (Libro libro in libros)
            {
                if (libro.Titulo == titulo)
                {
                    libroEncontrado = libro;
                }
            }
            return libroEncontrado;
        }

        public bool EliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libroEncontrado = BuscarLibro(titulo);
            if (libroEncontrado != null)
            {
                libros.Remove(libroEncontrado);
                resultado = true;
            }
            return resultado;
        }

        public bool PrestarLibro(string titulo)
        {
            bool resultado = false;
            Libro libroEncontrado = BuscarLibro(titulo);
            if (libroEncontrado != null)
            {
                libroEncontrado.PrestarLibro();
                resultado = true;
            }
            return resultado;
        }

    }
}
