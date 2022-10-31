using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprar_passagens
{
    public partial class Form1 : Form

    {

        Compra_passagem comp = new Compra_passagem();


        //Variaveis para aparecer dentro co Check-in
        public static string resg_cod;
        public static string resg_local;
        public static string resg_valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp.Valor = "R$1200";
            comp.Local = " Rio de Janeiro";
            comp.Codigo = "11223344";
            label6.Text = comp.Codigo;

            //Valores de cada viagem
            resg_cod = comp.Codigo;
            resg_local = comp.Local;
            resg_valor = comp.Valor;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comp.Valor = "R$1100";
            comp.Local = "Recife";
            comp.Codigo = "55667788";
            label7.Text = comp.Codigo;

            //Valores de cada viagem
            resg_cod = comp.Codigo;
            resg_local = comp.Local;
            resg_valor = comp.Valor;

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comp.Valor = "R$1900";
            comp.Local = " Fortaleza";
            comp.Codigo = "991010112020";
            label12.Text = comp.Codigo;

            //Valores de cada viagem

            resg_cod = comp.Codigo;
            resg_local = comp.Local;
            resg_valor = comp.Valor;

          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
