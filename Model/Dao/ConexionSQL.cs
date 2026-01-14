using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public abstract class ConexionSQL
    {
        private readonly string connectionString;
        public ConexionSQL()
        {   //alt + 92 para barra invertida
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Desktop\\LPOO1\\BaseDeDatos\\DB_Biblioteca.mdf;Integrated Security=True";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
