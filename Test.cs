using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Test
    {
        public static void Main()
        {
            Libro libro1 = new Libro("El señor de los anillos: La Comunidad del Anillo", "J.R.R. Tolkien", "IVREA");
            Libro libro2 = new Libro("El señor de los anillos: Las Dos Torres", "J.R.R. Tolkien", "IVREA");
            Libro libro3 = new Libro("El señor de los anillos: El Retorno del Rey", "J.R.R. Tolkien", "IVREA");

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);
            biblioteca.AgregarLibro("El hobbit", "J.R.R. Tolkien", "IVREA");
            biblioteca.MostrarLibros();
            Lector lector = new Lector("maxi", "gil", 33149494);
            biblioteca.AgregarLector(lector);
            biblioteca.RealizarPrestamo("El señor de los anillos: La Comunidad del Anillo", 33149494);
            biblioteca.RealizarPrestamo("El señor de los anillos: Las Dos Torres", 33149494);
            biblioteca.RealizarPrestamo("El señor de los anillos: El Retorno del Rey", 33149494);
            biblioteca.RealizarPrestamo("El señor de los anillos", 33149494);
            Console.WriteLine(lector.CantidadPrestamos());
            biblioteca.RealizarPrestamo("El hobbit", 33149494);
            biblioteca.MostrarLibros();
            biblioteca.MostrarLectores();
            Libro libro4 = new Libro("El señor de los membrillo: La Comunidad del Anillo", "J.R.R. Tolkien", "IVREA");
            Libro libro5 = new Libro("El señor de los membrillos: Las Dos Torres", "J.R.R. Tolkien", "IVREA");
            Libro libro6 = new Libro("El señor de los membrillos: El Retorno del Rey", "J.R.R. Tolkien", "IVREA");
            biblioteca.AgregarListadoLibros(libro4, libro5, libro6);
            biblioteca.MostrarLibros();
        }
        public static bool VerificarString(string str)
        {
            bool resultado = true;
            if (string.IsNullOrEmpty(str) || str.Trim().Length == 0)
            {
                resultado = false;

            }

            return resultado;

        }
    }
}
