
using Comprar_passagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulAereas
{
    public partial class GolChek_in : Form
    {
        public GolChek_in()
        {
            InitializeComponent();

      
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void GolChek_in_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Condição para verificarmos se o numero inicializado da viagem está marcada

            if (textBox1.Text == Form1.resg_cod)
            {
                MessageBox.Show(
                   "Sua Viagem foi marcada!!",
                   "Ok",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
            }
            else
            {
                MessageBox.Show(
                 "Codigo não encontrado",
                 "Erro",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error
                 );
            }
        }
    }
}
