using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Autor { get; set; }
        public int Categoria { get; set; }

        public Libro(int id, string titulo, int autor, int categoria)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Categoria = categoria;
        }

        public Libro()
        {
        }
    }
}
