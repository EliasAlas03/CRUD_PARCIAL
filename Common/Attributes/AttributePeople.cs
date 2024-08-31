using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attributes
{
    // Clase que define los atributos de una persona
    public class AttributePeople
    {
        // Campos privados para almacenar los valores de los atributos de la persona
        private int iD; // ID de la persona
        private string nombre; // Nombre de la persona
        private string apellido; // Apellido de la persona
        private string sexo; // Sexo de la persona

        // Propiedades públicas para acceder y modificar los valores de los atributos
        public int ID
        {
            get => iD; // Obtiene el valor de ID
            set => iD = value; // Establece el valor de ID
        }

        public string Nombre
        {
            get => nombre; // Obtiene el valor de Nombre
            set => nombre = value; // Establece el valor de Nombre
        }

        public string Apellido
        {
            get => apellido; // Obtiene el valor de Apellido
            set => apellido = value; // Establece el valor de Apellido
        }

        public string Sexo
        {
            get => sexo; // Obtiene el valor de Sexo
            set => sexo = value; // Establece el valor de Sexo
        }
    }
}

