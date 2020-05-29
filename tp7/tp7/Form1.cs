using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp7
{
    public partial class Form1 : Form
    {
        Calculadora calcular;
        public Form1()
        {
            InitializeComponent();
            calcular = new Calculadora();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text += cinco.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text += cuatro.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* calcular.Resultado = pantalla.Text;
            if (calcular.Resultado.Contains("+"))
            {
                string[] operadores = pantalla.Text.Split(Convert.ToChar("+"));
                pantalla.Clear();
                pantalla.Text = calcular.calculo(operadores[0], "+", operadores[1]);
            }
           */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text += siete.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "/";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                if (calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                calcular.Dato1 = null;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(calcular.Dato1 != null)
            {
                calcular.Dato1 = pantalla.Text;
                calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);
                calcular.Dato1 = null;
                pantalla.Text = calcular.Resultado;
            }
            else 
            //  pantalla.Text.Contains("+");
            {

                string[] arreglo = pantalla.Text.Split(Convert.ToChar("+"));
                calcular.calculo(arreglo[0], "+", arreglo[1]);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pantalla.Text += cero.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            pantalla.Text += coma.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "*";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                if (calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                calcular.Dato1 = null;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text += tres.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text += dos.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pantalla.Text += uno.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "-";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                if (calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                calcular.Dato1 = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text += seis.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "+";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                if(calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                //calcular.Dato1 = null;
            }



        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            calcular.Resultado = null;
            calcular.Dato1 = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text += ocho.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text += nueve.Text;

        }
    }
}
