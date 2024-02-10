using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Forms
{
    public partial class Calculadora : Form
    {
        bool cond;

        public double valor1;

        public double valor2;

        public int operacao;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Números
        private void bd0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void bd1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
        }

        private void bd2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }

        private void bd3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }

        private void bd4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";
        }

        private void bd5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";
        }

        private void bd6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";
        }

        private void bd7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";
        }

        private void bd8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";
        }

        private void bd9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";
        }

        //Funções das operações

        private void btMais_Click(object sender, EventArgs e)
        {
            Calculos obj = new Calculos();

            operacao = 1;

            if(valor1 == 0)
            {
                tbOperacao.Text = tbDisplay.Text + " +";
                valor1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = "";
            }
            else
            {
                btIgual_Click(sender, e);
            }
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            Calculos obj = new Calculos();

            operacao = 2;

            if (valor1 == 0)
            {
                tbOperacao.Text = tbDisplay.Text + " -";
                valor1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = "";
            }
            else
            {
                btIgual_Click(sender, e);
            }
        }

        private void btVezes_Click(object sender, EventArgs e)
        {
            Calculos obj = new Calculos();

            operacao = 3;

            if (valor1 == 0)
            {
                tbOperacao.Text = tbDisplay.Text + " x";
                valor1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = "";
            }
            else
            {
                btIgual_Click(sender, e);
            }
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            Calculos obj = new Calculos();

            operacao = 4;

            if (valor1 == 0)
            {
                tbOperacao.Text = tbDisplay.Text + " /";
                valor1 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = "";
            }
            else
            {
                btIgual_Click(sender, e);
            }
        }

        //Funções auxiliares

        private void btReset_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            tbOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            string displayCompl = "";

            for (int i = 0; i < tbDisplay.Text.Length - 1; i++)
            {
                displayCompl += tbDisplay.Text[i];
            }

            tbDisplay.Text = displayCompl;
        }

        private void btSinal_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text[0] == '-')
            {
                string displayCompl = "";

                for (int i = 1; i < tbDisplay.Text.Length; i++)
                {
                    displayCompl += tbDisplay.Text[i];
                }

                tbDisplay.Text = displayCompl;
            }
            else
            {
                string modificado = tbDisplay.Text.Insert(0, "-");
                tbDisplay.Text = modificado;
            }
        }

        private void btPonto_Click(object sender, EventArgs e)
        {
            cond = false;

            for (int i = 0; i < tbDisplay.Text.Length; i++)
            {
                if (tbDisplay.Text[i] == ',')
                {
                    cond = true;
                    MessageBox.Show("Insira apenas uma vírgula");
                }
            }

            if (cond == false)
            {
                tbDisplay.Text += ",";
            }
        }

        //Função igual

        private void btIgual_Click(object sender, EventArgs e)
        {
            Calculos obj = new Calculos();

            double result = 0;

            if(tbDisplay.Text == "")
            {
               MessageBox.Show("Insira um valor");
            }
            else
            {
                valor2 = double.Parse(tbDisplay.Text);

                switch (operacao)
                {
                    case 1:
                        result = obj.Soma(valor1, valor2);
                        break;

                    case 2:
                        result = obj.Sub(valor1, valor2);
                        break;

                    case 3:
                        result = obj.Multi(valor1, valor2);
                        break;

                    case 4:
                        result = obj.Divi(valor1, valor2);
                        break;

                    default:
                        MessageBox.Show("Insira uma operação para o cálculo");
                        break;
                }

                tbDisplay.Text = result.ToString();
                valor1 = 0;
                valor2 = 0;
                operacao = 0;
                tbOperacao.Text = "";
            }
        }

    }

    class Calculos
    {

        public double Soma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Sub(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multi(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Divi(double valor1, double valor2)
        {
            if(valor1 == 0 || valor2 == 0)
            {
                throw new Exception("Não é possiível divisão por 0");
            }

            return valor1 / valor2;
        }

        //Func<int> Sub = () => { return valor1 - valor2; };
    }
}
