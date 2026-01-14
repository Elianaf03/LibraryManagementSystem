using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorioSGB.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }

        public string DatosAutor
        {
            get{
                return ObtenerAutorString();
            }
        }

        public string DatosCategoria
        {
            get
            {
                return ObtenerCategoriaString();
            }
        }

        public Libro(int id, string titulo, Autor autor, Categoria categoria)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Categoria = categoria;
        }

        public Libro()
        {
        }

        public string ObtenerAutorString()
        {
            string dAutor;
            dAutor = this.Autor.Id + " - " +
                this.Autor.Nombre + " - " +
                this.Autor.Apellido;
            return dAutor;
        }

        public string ObtenerCategoriaString()
        {
            string dCategoria;
            dCategoria = this.Categoria.Id + " - " +
                this.Categoria.Nombre + " - " +
                this.Categoria.Descripcion;
            return dCategoria;
        }
    }
}
