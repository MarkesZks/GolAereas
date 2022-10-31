using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



 //Pagina Trabalhe Conosco;
 


namespace WindowsFormsApp1
{
    public partial class Trabalhe_conosco : Form
    {
        // Instaciamos a classe de informçoes;
        Informacoes infs = new Informacoes();
        public Trabalhe_conosco()
        {
            InitializeComponent();
        }

        private void Trabalhe_conosco_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            //Anexo de Arquivos
            var anexo = new OpenFileDialog();

            anexo.Title = "Anexar currículo";

            if(anexo.ShowDialog() == DialogResult.OK)
            { textBox10.Text = anexo.FileName; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Armazena as informaçoes do candidato
            infs.setnome(textBox1.Text);
            infs.setsobrenome(textBox2.Text);
            infs.setemail(textBox3.Text);
            infs.settelefone(maskedTextBox1.Text);
            infs.setlogradouro(textBox5.Text);
            infs.setcep(maskedTextBox2.Text);
            infs.setcidade(textBox7.Text);
            infs.setestado(textBox6.Text);
            infs.setsobre_voce(textBox9.Text);
            infs.setvaga(comboBox1.Text);

            MessageBox.Show("Suas informações foram enviadas.\nBoa Sorte!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
