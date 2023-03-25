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
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                valor2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResult.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUB")
                {
                    txtResult.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULT")
                {
                    txtResult.Text = Convert.ToString(valor1 * valor2);
                }
                else
                {
                    txtResult.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.TextLength - 1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }
    }
}
