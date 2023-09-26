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
    public partial class CalcCientifica : Form
    {
        public CalcCientifica()
        {
            InitializeComponent();
        }

        decimal vNumAnt;
        string vOperacao;
        bool vLimpar = false;

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            switch (vOperacao)
            {
                case "+":
                    {
                        lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                        break;
                    }
                case "-":
                    {
                        lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                        break;
                    }
                case "x":
                    {
                        lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                        break;
                    }
                case "÷":
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                        break;
                    }
            }
            lblVisor.Focus();
        }

        private void btnNumero(object sender, EventArgs e)
        {
            string vNumero = ((Button)sender).Text;

            if(vLimpar)
            {
                lblVisor.Text = "";
                vLimpar = false;
            }

            if(lblVisor.Text == "0")
            {
                lblVisor.Text = "";
            }

            if((vNumero == "," && !lblVisor.Text.Contains(","))
                || vNumero!=",")
                if ((vNumero =="," && lblVisor.Text.IndexOf(',') == -1)
                    || vNumero != ",")
                {
                    lblVisor.Text += vNumero;
                }

            lblVisor.Focus();
        }

        private void btnOperacao(object sender, EventArgs e)
        {
            vOperacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lblVisor.Text);
            vLimpar = true;
            lblVisor.Focus();
        }

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            Button bot = new Button();
            //label2.Text = e.KeyCode.ToString();
            //if((e.KeyCode>=Keys.D0 && e.KeyCode=<=Keys.D9))
            //{
            //    bot.Text = e.KeyCode.ToString().Substring(1, 1);
            //    btnNumero(bot, e);
            //    return;
            //}

            //else if((e.KeyCode == Keys.Oemcomma))
            //{
            //    bot.Text = ",";
            //    btnNumero(bot, e);
            //    return;
            //}
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if(lblVisor.Text == "")
            {
                lblVisor.Text = "0";
            }
        }
    }
}
