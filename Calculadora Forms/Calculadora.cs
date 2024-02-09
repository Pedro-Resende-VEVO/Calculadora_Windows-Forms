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
        bool ordem = true;

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

        private void bd1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
        }

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
