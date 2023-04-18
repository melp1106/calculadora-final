using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Program
    {
        int resultado;
        int valor1;
        int valor2;
       
        
        
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }
}
