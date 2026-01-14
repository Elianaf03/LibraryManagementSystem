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
    public class CategoriaController
    {
        CategoriaDao categoriaDao = new CategoriaDao();
        public DataTable ListarCategorias()
        {
            return categoriaDao.listarCategorias();
        }

        public DataTable ListarCategoriasString()
        {
            return categoriaDao.listarCategoriasString();
        }

        public void agregarCategoria(Categoria categoria)
        {
            categoriaDao.agregarCategorias(categoria);
        }

        public void editarCategoria(Categoria categoria)
        {
            categoriaDao.editarCategorias(categoria);
        }

        public void eliminarCategoria(int id)
        {
            categoriaDao.eliminarCategorias(id);
        }
    }
}
