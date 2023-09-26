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
    public partial class CalcSimples : Form
    {
        public CalcSimples()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            lblResultado.Text = "";
            lblSinal.Text = "?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(n1.Text);
            int b = int.Parse(n2.Text);
            int resultado = a + b;
            string result = resultado.ToString();

            lblResultado.Text = result;
            lblSinal.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(n1.Text);
            int b = int.Parse(n2.Text);
            int resultado = a - b;
            string result = resultado.ToString();

            lblResultado.Text = result;
            lblSinal.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(n1.Text);
            int b = int.Parse(n2.Text);
            int resultado = a * b;
            string result = resultado.ToString();

            lblResultado.Text = result;
            lblSinal.Text = "x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(n1.Text);
            int b = int.Parse(n2.Text);
            int resultado = a / b;
            string result = resultado.ToString();

            lblResultado.Text = result;
            lblSinal.Text = "÷";
        }
    }
}
