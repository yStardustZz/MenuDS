using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDS.Calculadoras
{
    public partial class CalculadoraRadio : Form
    {
        double a, b ,result;
        public CalculadoraRadio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {
            if (numero1.Text != "")
            {
                a = Convert.ToDouble(numero1.Text);
            }
            else
            {
                numero2.Text = "0";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            result = a - b;
            lblResultado.Text = result.ToString();
            lblSinal.Text = "-";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            result = a * b;
            lblResultado.Text = result.ToString();
            lblSinal.Text = "x";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            result = a / b;
            lblResultado.Text = result.ToString();
            lblSinal.Text = "÷";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            result = Math.Pow(a, b);
            lblResultado.Text = result.ToString();
            lblSinal.Text = "^";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            result = a + b;
            lblResultado.Text = result.ToString();
            lblSinal.Text = "+";
        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {
            if (numero2.Text != "")
            {
                b = Convert.ToDouble(numero2.Text);
            }
            else
            {
                numero1.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            result = a + b;
            lblResultado.Text = result.ToString();
            lblSinal.Text = "+";
        }
    }
}
