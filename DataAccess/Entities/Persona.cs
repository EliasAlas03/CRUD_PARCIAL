using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Persona
    {
        // Variables para manejar la conexión a la base de datos, comandos SQL, lectores de datos y tablas de datos
        Connection_Database c = new Connection_Database(); // Conexión a la base de datos
        SqlCommand cmd = new SqlCommand(); // Comando SQL
        SqlDataReader dr; // Lector de datos SQL
        DataTable td = new DataTable(); // Tabla de datos para almacenar los resultados

        // Método para mostrar datos
        public DataTable Mostrar()
        {
            try
            {
                // Configurar la conexión y el comando para ejecutar el procedimiento almacenado SP_Mostrar
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar";
                cmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar el comando y cargar los datos en la tabla
                dr = cmd.ExecuteReader();
                td.Load(dr);
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y almacenar el mensaje de error en una cadena
                string msj = ex.ToString();
            }
            finally
            {
                // Cerrar la conexión a la base de datos en el bloque finally
                cmd.Connection = c.CloseConnection();
            }
            return td; // Devolver la tabla con los datos
        }

        // Método para buscar datos utilizando un parámetro de búsqueda
        public DataTable Buscar(string Buscar)
        {
            try
            {
                // Configurar la conexión y el comando para ejecutar el procedimiento almacenado SP_Buscar
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Buscar";
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir el parámetro de búsqueda al comando
                cmd.Parameters.AddWithValue("@Buscar", Buscar);

                // Ejecutar el comando y cargar los datos en la tabla
                dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                td.Load(dr);
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y almacenar el mensaje de error en una cadena
                string msj = ex.ToString();
            }
            finally
            {
                // Cerrar la conexión a la base de datos en el bloque finally
                cmd.Connection = c.CloseConnection();
            }
            return td; // Devolver la tabla con los datos
        }

        // Método para insertar datos en la base de datos
        public void Insertar(AttributePeople obj)
        {
            try
            {
                // Configurar la conexión y el comando para ejecutar el procedimiento almacenado SP_Insertar
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Insertar";
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios al comando
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);

                // Ejecutar el comando para insertar los datos
                cmd.ExecuteNonQuery();

                // Limpiar los parámetros del comando
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y almacenar el mensaje de error en una cadena
                string msj = ex.ToString();
            }
            finally
            {
                // Cerrar la conexión a la base de datos en el bloque finally
                cmd.Connection = c.CloseConnection();
            }
        }

        // Método para modificar datos en la base de datos
        public void Modificar(AttributePeople obj)
        {
            try
            {
                // Configurar la conexión y el comando para ejecutar el procedimiento almacenado SP_Modificar
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Modificar";
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios al comando
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);

                // Ejecutar el comando para modificar los datos
                cmd.ExecuteNonQuery();

                // Limpiar los parámetros del comando
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y almacenar el mensaje de error en una cadena
                string msj = ex.ToString();
            }
            finally
            {
                // Cerrar la conexión a la base de datos en el bloque finally
                cmd.Connection = c.CloseConnection();
            }
        }

        // Método para eliminar datos de la base de datos
        public void Eliminar(AttributePeople obj)
        {
            try
            {
                // Configurar la conexión y el comando para ejecutar el procedimiento almacenado SP_Eliminar
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Eliminar";
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir el parámetro necesario al comando
                cmd.Parameters.AddWithValue("@ID", obj.ID);

                // Ejecutar el comando para eliminar los datos
                cmd.ExecuteReader();

                // Limpiar los parámetros del comando
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y almacenar el mensaje de error en una cadena
                string msj = ex.ToString();
            }
            finally
            {
                // Cerrar la conexión a la base de datos en el bloque finally
                cmd.Connection = c.CloseConnection();
            }
        }
    }
}
