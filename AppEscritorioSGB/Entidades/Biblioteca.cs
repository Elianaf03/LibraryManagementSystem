using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorioSGB.Entidades
{
    public static class Biblioteca
    {
        public static List<Libro> ListaLibros { get; set; }
        public static List<Autor> ListaAutores { get; set; }
        public static List<Categoria> ListaCategorias { get; set; }

        static Biblioteca()
        {
            ListaCategorias = new List<Categoria>();
            ListaAutores = new List<Autor>();
            ListaLibros = new List<Libro>();
        }

        #region CATEGORIA

        public static void AgregarCategoria(Categoria cat)
        {
            ListaCategorias.Add(cat);
        }

        public static List<Categoria> ListarCategorias()
        {
            return ListaCategorias;
        }

        public static void ModificarCategoria(Categoria cat)
        {
            int index = ListaCategorias.FindIndex(c => c.Id == cat.Id);
            if (index != -1)
            {
                ListaCategorias[index] = cat;
            }
        }

        public static void EliminarCategoria(Categoria cat)
        {
            ListaCategorias.RemoveAll(c => c.Id == cat.Id);
        }

        public static void EliminarCategoria(int id)
        {
            ListaCategorias.RemoveAll(c => c.Id == id);
        }

        public static int ObtenerUltimoID()
        {
            return ObtenerUltimoId<Categoria>(ListaCategorias);
        }

        // Metodo generico para obtener Id de cualquier lista de alguna clase
        public static int ObtenerUltimoId<T>(List<T> lista)
        {
            int ultimoId = 0;
            if (lista.Count > 0)
            {
                var lastItem = lista[lista.Count - 1];
                var idProp = lastItem.GetType().GetProperty("Id");
                if (idProp != null && idProp.PropertyType == typeof(int))
                {
                    ultimoId = (int)idProp.GetValue(lastItem);
                }
            }
            return ultimoId;
        }
        #endregion

        #region AUTOR

        public static void AgregarAutor(Autor aut)
        {
            ListaAutores.Add(aut);
        }

        public static List<Autor> ListarAutores()
        {
            return ListaAutores;
        }

        public static void ModificarAutor(Autor aut)
        {
            int index = ListaAutores.FindIndex(c => c.Id == aut.Id);
            if (index != -1)
            {
                ListaAutores[index] = aut;
            }
        }

        public static void EliminarAutor(Autor aut)
        {
            ListaAutores.RemoveAll(c => c.Id == aut.Id);
        }

        public static void EliminarAutor(int id)
        {
            ListaAutores.RemoveAll(c => c.Id == id);
        }

        public static int ObtenerUltimoIDAutor()
        {
            return ObtenerUltimoId<Autor>(ListaAutores);
        }
        #endregion

        #region LIBRO
        public static void AgregarLibro(Libro lib)
        {
            ListaLibros.Add(lib);
        }

        public static List<Libro> ListarLibros()
        {
            return ListaLibros;
        }

        public static void ModificarLibro(Libro lib)
        {
            int index = ListaLibros.FindIndex(c => c.Id == lib.Id);
            if (index != -1)
            {
                ListaLibros[index] = lib;
            }
        }

        public static void EliminarLibro(Libro lib)
        {
            ListaLibros.RemoveAll(c => c.Id == lib.Id);
        }

        public static void EliminarLibro(int id)
        {
            ListaLibros.RemoveAll(c => c.Id == id);
        }

        public static int ObtenerUltimoIDLibro()
        {
            return ObtenerUltimoId<Libro>(ListaLibros);
        }

        public static Autor ObtenerAutorLibro(int id)
        {
            Autor autor = new Autor();
            int indes = ListaLibros.FindIndex(li => li.Id == id);
            if (indes != -1)
            {
                autor = ListaLibros[indes].Autor;
            }
            return autor;
        }

        public static Categoria ObtenerCategoriaLibro(int id)
        {
            Categoria categoria = new Categoria();
            int indes = ListaLibros.FindIndex(li => li.Id == id);
            if (indes != -1)
            {
                categoria = ListaLibros[indes].Categoria;
            }
            return categoria;
        }
        #endregion


    }
}
