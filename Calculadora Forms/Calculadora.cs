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
            }
            else
            {
                btIgual_Click(sender, e);
            }

            tbDisplay.Text = "";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            Calculos obj = new Calculos();

            valor2 = double.Parse(tbDisplay.Text);

            switch (operacao)
            {
                case 1:
                    double result = obj.Soma(valor1,valor2);
                    tbDisplay.Text = result.ToString();
                    break;

                /*case 2:
                    tbDisplay.Text = obj.Sub().ToString();
                    break;

                case 3:
                    tbDisplay.Text = obj.Multi().ToString();
                    break;

                case 4:
                    tbDisplay.Text = obj.Divi().ToString();
                    break;

                default:
                    MessageBox.Show("Insira uma operação para o cálculo");adsad
                    break;*/

            valor1 = 0;
            valor2 = 0;
            operacao = 0;
            tbOperacao.Text = "";
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
