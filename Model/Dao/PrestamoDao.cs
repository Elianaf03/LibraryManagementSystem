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
    public class PrestamoDao : ConexionSQL
    {
        public DataTable listarPrestamosString()
        {
            DataTable lstPrestamos = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarPrestamosString";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstPrestamos.Load(leerFilas);
                    leerFilas.Close();
                    return lstPrestamos;
                }
            }
        }

        //listar detalle para prestamos
        public DataTable listarPrestamosDetalle()
        {
            DataTable lstPrestamos = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarPrestamosXSocio";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstPrestamos.Load(leerFilas);
                    leerFilas.Close();
                    return lstPrestamos;
                }
            }
        }

        //lista de libros prestados por id de usuario: roles
        public DataTable listarPrestamosXIdUsuario(int idUsuario)
        {
            DataTable lstPrestamos = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.CommandText = "sp_ListarPrestamosXIdUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstPrestamos.Load(leerFilas);
                    leerFilas.Close();
                    return lstPrestamos;
                }
            }
        }

        public void agregarPrestamos(Prestamo prestamo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@fechaPrestamo", prestamo.FechaPrestamo);
                    command.Parameters.AddWithValue("@fechaDevolucion", prestamo.FechaDevolucion);
                    command.Parameters.AddWithValue("@estado", prestamo.Estado);
                    command.Parameters.AddWithValue("@idUsuario", prestamo.IdUsuario);
                    command.CommandText = "sp_AgregarPrestamo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        //Registro de prestamo aplicando el concepto de maestro detalle
        public void registrarPrestamo(Prestamo prestamo, List<PrestamoDetalle> lst) //datos y la lista del DGV
        {
            //Definir tabla Detalle
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("IdLibro");

            int i = 1;
            //Recorrer y añadir al DataTable los datos de la lista
            foreach (var oElement in lst)
            {
                dt.Rows.Add(
                    i,
                    oElement.IdLibro);
                i++;
            }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_GuardarPrestamo";
                    var parametroLista = new SqlParameter("lstDetalle", SqlDbType.Structured); //definicion de un parametro como estructura
                    parametroLista.TypeName = "dbo.Detalle";    //le asigno el nombre del tipo de la BD
                    parametroLista.Value = dt;  //asignarle los datos que toma del DataTable por foreach
                    command.Parameters.Add(parametroLista);
                    command.Parameters.AddWithValue("@fechaDevolucion", prestamo.FechaDevolucion);
                    command.Parameters.AddWithValue("@estado", prestamo.Estado);
                    command.Parameters.AddWithValue("@idUsuario", prestamo.IdUsuario);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void editarPrestamos(Prestamo prestamo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@fechaPrestamo", prestamo.FechaPrestamo);
                    command.Parameters.AddWithValue("@fechaDevolucion", prestamo.FechaDevolucion);
                    command.Parameters.AddWithValue("@estado", prestamo.Estado);
                    command.Parameters.AddWithValue("@idUsuario", prestamo.IdUsuario);
                    command.CommandText = "sp_EditarPrestamo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void eliminarPrestamos(int idprestamo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", idprestamo);
                    command.CommandText = "sp_EliminarPrestamo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void devolverPrestamo(Prestamo prestamo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idPrestamo", prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@fechaPrestamo", prestamo.FechaPrestamo);
                    command.Parameters.AddWithValue("@fechaDevolucion", prestamo.FechaDevolucion);
                    command.Parameters.AddWithValue("@estado", prestamo.Estado);
                    command.Parameters.AddWithValue("@idUsuario", prestamo.IdUsuario);
                    command.CommandText = "sp_devolverPrestamo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        //muestra el detalle de un prestamos x id
        public DataTable mostrarDetallePrestamoXIdPrestamo(int idPrestamo)
        {
            DataTable lstLibrosPrestamos = new DataTable();

            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                    command.CommandText = "sp_detallePrestamoXIdPrestamo";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstLibrosPrestamos.Load(leerFilas);
                    leerFilas.Close();
                    return lstLibrosPrestamos;
                }
            }
        }

        // obtener Prestamo por ID
        public Prestamo obtenrPrestamoXId(int idPrestamo)
        {
            Prestamo pres = new Prestamo();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                    command.CommandText = "sp_obtenerPrestamoXId";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            pres.IdPrestamo = reader.GetInt32(0);
                            pres.FechaPrestamo = reader.GetDateTime(1);
                            pres.FechaDevolucion = reader.GetDateTime(2);
                            pres.Estado = reader.GetString(3);
                            pres.IdUsuario = reader.GetInt32(4);
                        }

                    }
                    return pres;

                }
            }
        }
    }
}
