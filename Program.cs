using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.TelaLogin;

namespace ProjetoDesafio
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
            Application.Run(new FrmLogar());
        }
    }
}
