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
    public class CategoriaDao: ConexionSQL
    {
        public DataTable listarCategorias()
        {
            DataTable lstCategorias = new DataTable();
            using ( var connection= GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Categorias";
                    command.CommandType = CommandType.Text;
                    leerFilas = command.ExecuteReader();
                    lstCategorias.Load(leerFilas);
                    leerFilas.Close();
                    connection.Close();
                    return lstCategorias;
                }
            }
        }

        public DataTable listarCategoriasString()
        {
            DataTable lstLibros = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarCategoriasString";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstLibros.Load(leerFilas);
                    leerFilas.Close();
                    connection.Close();
                    return lstLibros;
                }
            }
        }

        public void agregarCategorias(Categoria categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    command.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                    command.CommandText = "INSERT INTO Categorias VALUES (@nombre, @descripcion)";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }

        public void editarCategorias(Categoria categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", categoria.Id);
                    command.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    command.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                    command.CommandText = "UPDATE Categorias SET Nombre = @nombre, Descripcion = @descripcion WHERE IdCategoria = @id";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                   
                }
            }
        }

        public void eliminarCategorias(int idcategoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", idcategoria);
                    command.CommandText = "DELETE Categorias WHERE IdCategoria=@id";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }
    }
}
