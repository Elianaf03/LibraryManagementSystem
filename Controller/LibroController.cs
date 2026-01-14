using Entities;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LibroController
    {
        LibroDao libroDao = new LibroDao();
        public DataTable ListarLibro(string titulo)
        {
            return libroDao.listarLibro(titulo);
        }

        public DataTable ListarLibrosString()
        {
            return libroDao.listarLibrosString();
        }

        public void agregarlibro(Libro libro)
        {
            libroDao.agregarLibros(libro);
        }

        public void editarlibro(Libro libro)
        {
            libroDao.editarLibros(libro);
        }

        public void eliminarlibro(int id)
        {
            libroDao.eliminarLibros(id);
        }
    }
}
