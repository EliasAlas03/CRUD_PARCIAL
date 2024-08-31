using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.Entities; // Importa la capa de acceso a datos
using Common.Attributes; // Importa atributos comunes

namespace Domain.Crud
{
    // Clase para manejar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para personas
    public class CPersonas
    {
        // Instancia de la clase Persona, que contiene la lógica de acceso a la base de datos
        Persona persona = new Persona();

        // Método para mostrar datos llamando al método Mostrar de la clase Persona
        public DataTable Mostrar()
        {
            // Crea una tabla de datos para almacenar los resultados
            DataTable td = new DataTable();

            // Llama al método Mostrar de Persona y guarda el resultado en la tabla
            td = persona.Mostrar();

            // Devuelve la tabla con los datos
            return td;
        }

        // Método para buscar datos llamando al método Buscar de la clase Persona
        public DataTable Buscar(string Buscar)
        {
            // Crea una tabla de datos para almacenar los resultados de la búsqueda
            DataTable td = new DataTable();

            // Llama al método Buscar de Persona con el parámetro de búsqueda y guarda el resultado en la tabla
            td = persona.Buscar(Buscar);

            // Devuelve la tabla con los datos encontrados
            return td;
        }

        // Método para insertar datos llamando al método Insertar de la clase Persona
        public void Insertar(AttributePeople obj)
        {
            // Llama al método Insertar de Persona, pasando el objeto con los atributos de la persona
            persona.Insertar(obj);
        }

        // Método para modificar datos llamando al método Modificar de la clase Persona
        public void Modificar(AttributePeople obj)
        {
            // Llama al método Modificar de Persona, pasando el objeto con los atributos de la persona
            persona.Modificar(obj);
        }

        // Método para eliminar datos llamando al método Eliminar de la clase Persona
        public void Eliminar(AttributePeople obj)
        {
            // Llama al método Eliminar de Persona, pasando el objeto con el ID de la persona a eliminar
            persona.Eliminar(obj);
        }
    }
}

