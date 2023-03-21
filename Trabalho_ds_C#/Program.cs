/**
Arquivo principal que contém o ponto de entrada do programa
@author Víctor Gabriel Cruz Pereira

  **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_ds_C_
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
