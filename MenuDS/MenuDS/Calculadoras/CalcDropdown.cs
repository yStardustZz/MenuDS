using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MenuDS.Classes;

namespace MenuDS.Calculadoras
{
    public partial class CalcDropdown : Form
    {
        public CalcDropdown()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Operacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a, b;

            switch (Operacoes.Text)
            {
                case "Adição":
                    {
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);
                        decimal resultado = a + b;
                        string result = resultado.ToString();

                        lblResultado.Text = result;
                        break;
                    }
                case "Subtração":
                    {
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);
                        decimal resultado = a - b;
                        string result = resultado.ToString();

                        lblResultado.Text = result;
                        break;
                    }
                case "Multiplicação":
                    {
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);
                        decimal resultado = a * b;
                        string result = resultado.ToString();

                        lblResultado.Text = result;
                        break;
                    }
                case "Divisão":
                    {
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);
                        decimal resultado = a / b;
                        string result = resultado.ToString();

                        lblResultado.Text = result;
                        break;
                    }
                case "Potenciação":
                    {
                        Classes objCalc = new Classes();
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);
                        string result = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();
                        lblResultado.Text = result;

                        return;
                    }
                case "Comparação":
                    {
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);

                        if(a<b)
                        {

                            lblResultado.Text = "O 1º número é maior que o 2º número";
                        }

                        else if(a == b)
                        {

                            lblResultado.Text = "O 1º número é igual o 2º número";
                        }

                        else if(a>b)
                        {
                            lblResultado.Text = "O 1º número é menor que o 2º número";
                        }
                        break;
                    }

                case "Par ou Ímpar":
                    {
                        a = int.Parse(numero1.Text);
                        b = int.Parse(numero2.Text);
                        decimal Resultado = a % 2;
                        decimal Resultado2 = b % 2;

                        if (Resultado == 0 && Resultado2 == 0)
                        {
                            lblResultado.Text = "Ambos os números são pares.";
                        }

                        else if(Resultado != 0 && Resultado2 == 0)
                        {
                            lblResultado.Text = "O 1º número é ímpar e o 2º número é par.";
                        }

                        else if(Resultado == 0 && Resultado2 != 0)
                        {
                            lblResultado.Text = "O 1º número é par e o 2º número é ímpar.";
                        }

                        else if(Resultado != 0 && Resultado2 != 0 )
                        {
                            lblResultado.Text = "Ambos os números são ímpares.";
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}


