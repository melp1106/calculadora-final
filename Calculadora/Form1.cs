using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        decimal resultado;
        int indent = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "1";
            }
            else
            if(txtTela.Text.Length >= 8)
            {
                
            } else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "1";
                }
                else
                {
                    txtTela.Text += "1";
                }
            }
            

        }
            

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "2";
            }
            else
            if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "2";
                }
                else
                {
                    txtTela.Text += "2";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "3";
            }
            else
             if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "3";
                }
                else
                {
                    txtTela.Text += "3";
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "4";
            }
            else
             if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "4";
                }
                else
                {
                    txtTela.Text += "4";
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "5";
            }
            else
             if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "5";
                }
                else
                {
                    txtTela.Text += "5";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "6";
            }
            else
            if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "6";
                }
                else
                {
                    txtTela.Text += "6";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "7";
            }
            else
            if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "7";
                }
                else
                {
                    txtTela.Text += "7";
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "8";
            }
            else
             if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "8";
                }
                else
                {
                    txtTela.Text += "8";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "9";
            }
            else
            if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "";
                    txtTela.Text += "9";
                }
                else
                {
                    txtTela.Text += "9";
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString().Replace(',', '.'))
            {
                txtTela.Text = "";
                txtTela.Text += "0";
            }
            else
            if (txtTela.Text.Length >= 8)
            {

            }
            else
            {
                if (txtTela.Text.Equals("0"))
                {
                    txtTela.Text = "0";
                }
                else
                {
                    txtTela.Text += "0";
                }
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtTela.Text = "";
            valor1 = 0;
            valor2 = 0;

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtTela.Text == valor1.ToString())
            {
                
            }
            else
            if (txtTela.Text.Length >= 8)
            {

            }
            else 
            {
                if (txtTela.Text.Equals(""))
                {
                    txtTela.Text = "0.";
                }
                else if (txtTela.Text.Contains("."))
                {

                }else 
                {
                    txtTela.Text += ".";
                }
            }
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            //if (txtTela.Text == valor1.ToString())
            //{

            //}else
            //if (txtTela.Text.Length >= 8)
            //{

            //}
            //else
            //{
            //    if (txtTela.Text.Equals(""))
            //    {
            //        txtTela.Text = "";
            //    }
            //    else if (txtTela.Text.Contains(","))
            //    {

            //    }
            //    else if (txtTela.Text.Contains("."))
            //    {

            //    }
            //    else
            //    {
            //        txtTela.Text += ",";
            //    }
            //}
        }

        public void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = valor1.ToString("").Replace(',', '.');
            indent = 1;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = valor1.ToString("").Replace(',', '.');
            indent = 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = valor1.ToString("").Replace(',', '.');
            indent = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = valor1.ToString("").Replace(',', '.');
            indent = 4;
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = valor1.ToString("").Replace(',', '.');
            indent = 5;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            if(indent == 0)
            {
                
            }else if (indent == 1)
            {
                resultado = valor1 + valor2;
                txtTela.Text = resultado.ToString("F2").Replace(',','.');
            }else if(indent == 2)
            {
                resultado = valor1 - valor2;
                txtTela.Text = resultado.ToString("F2").Replace(',', '.');
            }else if(indent ==3)
            {
                resultado = valor1 * valor2;
                txtTela.Text = resultado.ToString("F2").Replace(',', '.');
            }else if (indent == 4)
            {
                resultado = valor1 / valor2;
                txtTela.Text = resultado.ToString("F2").Replace(',', '.');
            }else if (indent == 5)
            {
                    resultado =  (valor1 * valor2) /100;
                    txtTela.Text = resultado.ToString("F2").Replace(',', '.');
            }
            else { }
        }
    }
}
