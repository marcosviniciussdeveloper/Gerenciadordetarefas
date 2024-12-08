using System;
using System.Windows.Forms;

namespace GerenciadorDeTarefas2._0
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Aqui é onde o Form1 é iniciado
        }
    }
}
