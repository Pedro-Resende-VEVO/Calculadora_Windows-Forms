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

            obj.operacao = 1;

            if(obj.valor1 == 0) //Erro aqui, assim o valor vai ser sempre 0 pois ele é inserido só dentro do if
            {
                tbOperacao.Text = tbDisplay.Text + " +";
                obj.valor1 = int.Parse(tbDisplay.Text);
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

            obj.valor2 = int.Parse(tbDisplay.Text);

            switch (obj.operacao)
            {
                case 1:
                    tbDisplay.Text = obj.Soma().ToString();
                    break;

                case 2:
                    tbDisplay.Text = obj.Sub().ToString();
                    break;

                case 3:
                    tbDisplay.Text = obj.Multi().ToString();
                    break;

                case 4:
                    tbDisplay.Text = obj.Divi().ToString();
                    break;

                default:
                    MessageBox.Show("Insira uma operação para o cálculo");
                    break;
            }

            obj.valor1 = 0;
            obj.valor2 = 0;
            obj.operacao = 0;
            tbOperacao.Text = "";
        }
    }

    class Calculos
    {
        public double valor1;

        public double valor2;

        public int operacao;

        public double Soma()
        {
            return valor1 + valor2;
        }

        public double Sub()
        {
            return valor1 - valor2;
        }

        public double Multi()
        {
            return valor1 * valor2;
        }

        public double Divi()
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
