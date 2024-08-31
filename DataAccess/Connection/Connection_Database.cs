using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Connection
{
    //esto es la cadena de conexion
    public class Connection_Database
    {
        private SqlConnection c = new SqlConnection("Data Source=ELIASALAS\\SQLEXPRESS;Initial Catalog=capasCRUD;Integrated Security=True;");
        
        public SqlConnection OpenConnection() 
            // Esto abre la conexión
        
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }

        public SqlConnection CloseConnection()
            // Esta cierra la conexión
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;
        }
    }
}
