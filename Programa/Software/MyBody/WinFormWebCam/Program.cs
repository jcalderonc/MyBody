using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace WinFormWebCam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Argumentos)
        {
            if (Argumentos.Length > 0)
            {
                int ID = int.Parse(Argumentos[0].ToString());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Principal(ID));
            }
            else
            {
                MessageBox.Show("No se puede ejecutar este componente sin parametros.");   
            }
        }
    }
}
