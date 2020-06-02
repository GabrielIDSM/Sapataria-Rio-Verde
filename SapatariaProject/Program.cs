using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SapatariaProject.UI;

namespace SapatariaProject
{
    static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmTelaInicial frmT = new frmTelaInicial();
            frmT.Visible = false;
            Application.Run(frmT);
        }

        public static void EncerraAplicacao()
        {
            Application.Exit();
        }
    }
}
