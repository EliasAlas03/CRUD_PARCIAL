using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita los estilos visuales de la aplicación, lo que permite que los controles de Windows Forms se dibujen con el estilo actual del sistema operativo.
            Application.EnableVisualStyles();

            // Configura el uso de la representación de texto compatible con el antiguo motor de renderizado GDI (Graphics Device Interface).
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia y ejecuta la aplicación, mostrando el formulario principal "Form1".
            Application.Run(new Form1());
        }
    }
}

