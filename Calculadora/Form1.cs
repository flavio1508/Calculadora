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
        decimal valor1 = 0,  valor2 = 0;
        string aoperacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            if(aoperacao == "SOMA"){
                decimal resultado = new Soma().somar(valor1, valor2);
                textResultado.Text = Convert.ToString(resultado);
            }else if(aoperacao == "SUB")
            {decimal resultado = new subtracao().Subtrair(valor1, valor2);
                textResultado.Text = Convert.ToString(resultado);
            }else if(aoperacao == "MULT")
            {
                decimal resultado = new Multiplicacao().multiplicar(valor1, valor2);
                textResultado.Text = Convert.ToString(resultado);
            }else 
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            aoperacao = "SUB";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            aoperacao = "MULT";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            aoperacao = "DIV";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao.Text = ""; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            aoperacao = "SOMA";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Soma");
            }
        }
    }
}
