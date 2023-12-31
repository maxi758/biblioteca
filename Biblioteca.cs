﻿namespace biblioteca
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

        public bool AgregarListadoLibros(params Libro[] lista) { 
            bool resultado = true;
            foreach (Libro libro in lista)
            {
                Libro libroEncontrado = BuscarLibro(libro.Titulo);
                if (libroEncontrado == null)
                {
                    Libros.Add(libro);
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

            if (Test.VerificarString(titulo))
            {
                foreach (Libro libro in Libros)
                {
                    if (libro.Titulo == titulo)
                    {
                        libroEncontrado = libro;
                    }
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

        private bool PrestarLibro(string titulo)
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

        public string RealizarPrestamo(string titulo, int dni)
        {
            string resultado;

            Libro libroEncontrado = BuscarLibro(titulo);
            
            if (libroEncontrado == null)
            {
                resultado = "LIBRO INEXISTENTE";
            }
            else
            {
                if (libroEncontrado.Prestado)
                {
                    resultado = "EL LIBRO YA FUE PRESTADO";
                }
                else
                {
                    Lector lector = BuscarLectorPorDni(dni);

                    if (lector == null)
                    {
                        resultado = "LECTOR INEXISTENTE";
                    }
                    else
                    {
                        if (lector.PedirLibro(libroEncontrado))
                        {
                            PrestarLibro(titulo);
                            resultado = "PRESTAMO EXITOSO";
                        }
                        else
                        {
                            resultado = "TOPE DE PRESTAMO ALCANZADO";
                        }
                    }

                }                   
            }
            
            return resultado;

        }
        public bool AgregarLector(Lector lector)
        {
            bool resultado = false;
            Lector lectorEncontrado = BuscarLectorPorDni(lector.Dni);
            if (lectorEncontrado == null)
            {
                Lectores.Add(lector);
                resultado = true;
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

        public void MostrarLectores()
        {
            foreach (Lector lector in Lectores)
            {
                lector.MostrarLector();
                Console.WriteLine();
            }
        } 

    }
}
