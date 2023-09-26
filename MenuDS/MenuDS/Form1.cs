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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("1") && txtSenha.Text.Equals("1"))
                {
                    var MainMenu = new MenuDS();
                    MainMenu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário ou senha incorretos.",
                               ex.Message,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void Form1_Keydown(Object sender, KeyEventArgs e)
        {

            Button bot = new Button();

            if (e.KeyCode == Keys.Return)
            {
                button2_Click(bot, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(bot, e);
            }
        }
    }
}
