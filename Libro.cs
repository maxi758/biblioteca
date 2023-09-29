using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Libro
    {
        string titulo;
        string autor;
        string editorial;
        bool prestado;

        public Libro(string titulo, string autor, string editorial)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Prestado = false;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public bool Prestado { get => prestado; set => prestado = value; }

        public void MostrarLibro()
        {
            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Editorial: " + editorial);
            Console.WriteLine("Prestado: " + prestado);
        }
        
        public void PrestarLibro()
        {
            if (prestado == false)
            {
                prestado = true;
            }
            else
            {
                Console.WriteLine("El libro ya se encuentra prestado");
            }
        }

        public override string ToString()
        {
            return "Titulo: " + titulo + "\nAutor: " + autor + "\nEditorial: " + editorial + "\nPrestado: " + prestado;
        }

    }
}
