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
    public class AutorDao : ConexionSQL
    {
        public DataTable listarAutores()
        {
            DataTable lstAutores = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Autores";
                    command.CommandType = CommandType.Text;
                    leerFilas = command.ExecuteReader();
                    lstAutores.Load(leerFilas);
                    leerFilas.Close();
                    return lstAutores;
                }
            }
        }

        public DataTable listarAutoresString()
        {
            DataTable lstAutores = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarAutoresString";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstAutores.Load(leerFilas);
                    leerFilas.Close();
                    return lstAutores;
                }
            }
        }

        public void agregarAutores(Autor autor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre", autor.Nombre);
                    command.Parameters.AddWithValue("@apellido", autor.Apellido);
                    command.CommandText = "INSERT INTO Autores VALUES (@nombre, @apellido)";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void editarAutores(Autor autor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", autor.Id);
                    command.Parameters.AddWithValue("@nombre", autor.Nombre);
                    command.Parameters.AddWithValue("@Apellido", autor.Apellido);
                    command.CommandText = "UPDATE Autores SET Nombre = @nombre, Apellido = @Apellido WHERE IdAutor=@id";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void eliminarAutores(int idautor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", idautor);
                    command.CommandText = "DELETE Autores WHERE IdAutor=@id";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
