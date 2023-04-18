using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class comandos
    {
        int resultado;
        int valor1;
        int valor2;

        public void soma(int valor1, int valor2)
        {
            resultado = valor1 + valor2;
        }

        public void sub(int valor1, int valor2)
        {
            resultado = valor1 - valor2;
        }

        public void mult(int valor1, int valor2)
        {
            resultado = valor1 * valor2;
        }

        public void divisao(int valor1, int valor2)
        {
            resultado = valor1 / valor2;
        }

        public void modulo(int valor1, int valor2)
        {
            resultado = valor1 % valor2;
        }
    }
}
