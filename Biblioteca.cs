namespace biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();
        private List<Lector> lectores = new List<Lector>();

        public List<Libro> Libros { get => libros; set => libros = value; }
        public List<Lector> Lectores { get => lectores; set => lectores = value; }

        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libroEncontrado = BuscarLibro(titulo);
            if (libroEncontrado == null)
            {
                Libro libro = new Libro(titulo, autor, editorial);
                Libros.Add(libro);
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
                Libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public bool AgregarListadoLibros(params string[] lista) { 
            bool resultado = true;
            foreach (string titulo in lista)
            {
                Libro libroEncontrado = BuscarLibro(titulo);
                if (libroEncontrado == null)
                {
                    Libros.Add(libroEncontrado);
                }
                else
                {
                    return false;
                }
            }
            return resultado;
        }

        public void MostrarLibros()
        {
            foreach (Libro libro in Libros)
            {
                libro.MostrarLibro();
                Console.WriteLine();
            }
        }

        public Libro BuscarLibro(string titulo)
        {
            Libro libroEncontrado = null;
            foreach (Libro libro in Libros)
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
                Libros.Remove(libroEncontrado);
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

        public bool RealizarPrestamo(string titulo, Lector lector)
        {
            bool resultado = false;
            Libro libroEncontrado = BuscarLibro(titulo);
            if (lector == null || titulo.Any() || libroEncontrado == null || libroEncontrado.Prestado)
            {
                return resultado;
            }
            else
            {
                if (Lectores.Contains(lector))
                {
                    libroEncontrado.Prestado = true;
                    resultado = true;
                }
            }
            return resultado;

        }

        public Lector BuscarLectorPorDni(int dni)
        {
            Lector lectorEncontrado = null;
            foreach(Lector lector in Lectores) { 
                if (lector.Dni == dni)
                {
                    lectorEncontrado = lector;
                }
            }
            return lectorEncontrado;
        }

    }
}
