using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telaPrincipal;

//Tela para Login 


namespace AzulAereas
{
    public partial class GolLogin : Form
    {
        
        GolCadastro cadastro = new GolCadastro();
        GolTelaPrincipal golTelaPrincipal = new GolTelaPrincipal();

        public GolLogin()
        {
            InitializeComponent();
        }

        private void GolLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GolLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Verificamos se os campos digitados sao os mesmos do cadastro 
            if (email_login.Text != GolCadastro.varemail)
            { 
                MessageBox.Show(
                   "Email inválido",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );

                return;
            }
            //Verificamos se os campos digitados sao os mesmos do cadastro 
            if (senha_login.Text != GolCadastro.varsenha)
            {
                MessageBox.Show(
                   "Senha inválida",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );

                return;
            }
            //Entao mostrara a tela principal 
            this.Hide();
            golTelaPrincipal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
