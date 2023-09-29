using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDS
{
    public partial class MenuDS : Form
    {
        public MenuDS()
        {
            InitializeComponent();
        }

        private void calculadoraSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CalcSimplesOpen = new Calculadoras.CalcSimples();
            CalcSimplesOpen.Show();
            this.Visible = false;
        }

        private void calculadoraCientíficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CalcCienOpen = new CalcCientifica();
            CalcCienOpen.Show();
            this.Visible = false;
        }

        private void calcOrientadaAObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CalcSelectOpen = new Calculadoras.CalcDropdown();
            CalcSelectOpen.Show();
            this.Visible = false;
        }

        private void calcOrientadaAObjetoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var CalcRadioOpen = new Calculadoras.CalculadoraRadio();
            CalcRadioOpen.Show();
            this.Visible = false;
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
