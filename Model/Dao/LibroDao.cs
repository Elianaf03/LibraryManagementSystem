using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class LibroDao : ConexionSQL
    {
        public DataTable listarLibrosString()
        {
            DataTable lstLibros = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarLibrosString";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstLibros.Load(leerFilas);
                    leerFilas.Close();
                    return lstLibros;
                }
            }
        }

        public DataTable listarLibro(string titulo)
        {
            DataTable lstLibros = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.CommandText = "sp_ListarLibro";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstLibros.Load(leerFilas);
                    leerFilas.Close();
                    return lstLibros;
                }
            }
        }
      
        public void agregarLibros(Libro libro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@idAutor", libro.Autor);
                    command.Parameters.AddWithValue("@idCategoria", libro.Categoria);
                    command.CommandText = "sp_AgregarLibro";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void editarLibros(Libro libro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", libro.Id);
                    command.Parameters.AddWithValue("@titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@idAutor", libro.Autor);
                    command.Parameters.AddWithValue("@idCategoria", libro.Categoria);
                    command.CommandText = "sp_EditarLibro";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void eliminarLibros(int idlibro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", idlibro);
                    command.CommandText = "sp_EliminarLibro";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
