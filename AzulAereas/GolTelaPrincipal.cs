using AzulAereas;
using Comprar_passagens;
using ContaScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


/*
    {GolAereas}
    Aplicação baseada no site da Gol Linhas Aereas
    @type Class/ Forms
    @author Felipe Matthew,
    @author Felipe Rocha,
    @author Gabriel Marques,
    @author Gustavo Neves,
    @author Mateus Gimenes,
    @since 12/10/2022

*/





namespace telaPrincipal
{
    public partial class GolTelaPrincipal : Form
    {
        //Instanciamos todas as classes para acessarmos apartir dessa tela principal 

        GolChek_in chek_In = new GolChek_in();
        GolSobre sobre = new GolSobre();
        Trabalhe_conosco trabalhe_conosco = new Trabalhe_conosco();
        ContaGol conta = new ContaGol();
        GolAjuda ajuda = new GolAjuda();
        Form1 passagem = new Form1();

        public GolTelaPrincipal()
        {

            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void façaSuaViagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passagem.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            passagem.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GolTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void centralDeAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ajuda.Show();
            //Mostramos a tela de Ajuda
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            chek_In.Show();
            //Mostramos a tela de Check-In
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trabalhe_conosco.Show();
            //Mostramos a tela de Trabalhe conosco
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sobre.Show();
            //Mostramos a tela de Sobre

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           conta.Show();
            //Mostramos a tela de Conta
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
