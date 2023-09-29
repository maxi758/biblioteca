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
            Libro libro1 = new Libro("El señor de los anillos", "J.R.R. Tolkien", "IVREA");
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro("El hobbit", "J.R.R. Tolkien", "IVREA");
            biblioteca.MostrarLibros();

        }
    }
}
