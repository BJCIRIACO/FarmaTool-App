using System;
using System.Windows.Forms;

namespace FarmaTool
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());

            //Creando objeto sp para cerrar el splash con condicional
            Splash sp = new Splash();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }

        }


    }
}
