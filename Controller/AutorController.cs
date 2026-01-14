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
    public class AutorController
    {
        AutorDao autorDao = new AutorDao();
        public DataTable ListarAutores()
        {
            return autorDao.listarAutores();
        }

        public DataTable ListarAutoresString()
        {
            return autorDao.listarAutoresString();
        }

        public void agregarautor(Autor autor)
        {
            autorDao.agregarAutores(autor);
        }

        public void editarautor(Autor autor)
        {
            autorDao.editarAutores(autor);
        }

        public void eliminarautor(int id)
        {
            autorDao.eliminarAutores(id);
        }
    }
}
