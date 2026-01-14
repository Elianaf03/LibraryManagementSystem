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
    public class UsuarioDao : ConexionSQL
    {
        public bool login(string loginName, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@login", loginName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandText = "SELECT * FROM Usuario WHERE LoginName=@login AND Password=@pass";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioCache.IdUsuario = reader.GetInt32(0);
                            UsuarioCache.Nombre = reader.GetString(1);
                            UsuarioCache.Apellido = reader.GetString(2);
                            UsuarioCache.Dni = reader.GetInt32(3);
                            UsuarioCache.Correo = reader.GetString(4);
                            UsuarioCache.Direccion = reader.GetString(5);
                            UsuarioCache.LoginName = reader.GetString(6);
                            UsuarioCache.Password = reader.GetString(7);
                            UsuarioCache.Rol = reader.GetString(8);
                            byte[] imgData = (byte[])reader[9];
                            UsuarioCache.Foto = imgData;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

        public byte[] obtnerFoto(int idUsuario)
        {
            byte[] fotoDB = null;
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.CommandText = "sp_ObtnerFoto";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    if (leerFilas.Read())
                    {
                        fotoDB = (byte[])leerFilas.GetValue(0);
                    }
                    leerFilas.Close();
                    return fotoDB;
                }
            }
        }
        public DataTable listarUsuarios(string cTexto)
        {
            DataTable lstLibros = new DataTable();

            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarUsuarios";
                    command.Parameters.AddWithValue("@cTexto", cTexto);
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstLibros.Load(leerFilas);
                    leerFilas.Close();
                    return lstLibros;
                }
            }
        }
        public void agregarUsuario(Usuario usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@dni", usuario.Dni);
                    command.Parameters.AddWithValue("@correo", usuario.Correo);
                    command.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    command.Parameters.AddWithValue("@loginName", usuario.LoginName);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@rol", usuario.Rol);
                    command.Parameters.AddWithValue("@foto", usuario.Foto);
                    command.CommandText = "sp_AgregarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }
        public void editarUsuario(Usuario usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@dni", usuario.Dni);
                    command.Parameters.AddWithValue("@correo", usuario.Correo);
                    command.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    command.Parameters.AddWithValue("@loginName", usuario.LoginName);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@rol", usuario.Rol);
                    command.Parameters.AddWithValue("@foto", usuario.Foto);
                    command.CommandText = "sp_EditarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void eliminarUsuario(int idUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.CommandText = "sp_EliminarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public DataTable listarUsuariosFiltrado(string sp, string param)
        {
            string storProc = "sp_ListarXNombre";
            string parametro = "@nombre";
            if (sp == "XNombre")
            {
                storProc = "sp_ListarXNombre";
                parametro = "@nombre";
            }
            else
            {
                if (sp == "xApellido")
                {
                    storProc = "sp_ListarXApellido";
                    parametro = "@apellido";
                }
                else
                {
                    storProc = "sp_ListarXDni";
                    parametro = "@dni";
                }

            }

            DataTable lstUsuarioFiltrados = new DataTable();

            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue(parametro, param);
                    command.CommandText = storProc;
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstUsuarioFiltrados.Load(leerFilas);
                    leerFilas.Close();
                    return lstUsuarioFiltrados;
                }
            }
        }

        //obtener Usuario x id
        public Usuario obtenrUsuarioXId(int idUsuario)
        {
            Usuario usu = new Usuario();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    command.CommandText = "sp_obtenerUsuarioXId";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            usu.IdUsuario = reader.GetInt32(0);
                            usu.Nombre = reader.GetString(1);
                            usu.Apellido = reader.GetString(2);
                            usu.Dni = reader.GetInt32(3);//Convert.ToInt32(reader.GetString(3));
                            usu.Correo = reader.GetString(4);
                            usu.Direccion = reader.GetString(5);
                            usu.LoginName = reader.GetString(6);
                            usu.Password = reader.GetString(7);
                            usu.Rol = reader.GetString(8);

                            byte[] imgData = (byte[])reader[9];
                            usu.Foto = imgData;

                        }

                    }
                    return usu;
                    //else
                    //{
                    //    return false;
                    //}
                }
            }
        }
    }
}
