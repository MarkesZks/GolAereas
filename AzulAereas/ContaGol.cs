using AzulAereas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaScreen
{

    public partial class ContaGol : Form
    {


      

        public ContaGol()
        {




            InitializeComponent();


        }


        private void ContaGol_Load(object sender, EventArgs e)
        {

            //Pegamos as variaveis dos cadastro e mostramos nos labels 
            label3.Text = GolCadastro.varnome;
            label5.Text = GolCadastro.varsobrenome;
            label6.Text = GolCadastro.varcpf;
            label8.Text = GolCadastro.varemail;
            label9.Text = GolCadastro.varnacionalidade;
            label11.Text = GolCadastro.vardoc;
            label12.Text = GolCadastro.vargenero;
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
