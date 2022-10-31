using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContaScreen;

namespace AzulAereas
{
    public partial class GolCadastro : Form
    {

        //Criamos variaveis publicas para recebermos e enviarmos para outras classes


        public static string varemail;
        public static string varsenha;
        public static string varnome;
        public static string varsobrenome;
        public static string vargenero;
        public static string varnacionalidade;
        public static string varcpf;
        public static string vartipodedoc;
        public static string vardoc;
        public static string vardata;

        Cliente client = new Cliente();


        //Conta
        public static string name_value;

        public GolCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void GolCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validations
            //Campos Vazios
            if (
                (nome.Text == "") ||
                (sobrenome.Text == "") ||
                (data_nasc.Text == "") ||
                (genero.Text == "") ||
                (nacionalidade.Text == "") ||
                (cpf.Text == "") ||
                (tipo_documento.Text == "") ||
                (numero_documento.Text == "") ||
                (email.Text == "") ||
                (confemail.Text == "") ||
                (senha.Text == "") ||
                (confsenha.Text == ""))
            {

                MessageBox.Show(
                    "Preencha todos os campos corretamente!!!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return;
            }

            //Valida email
            if (email.Text != confemail.Text)
            {
                MessageBox.Show(
                   "Os emails precisam ser iguais",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );

                return;
            }

            //Valida senha
            if (senha.Text != confsenha.Text)
            {
                MessageBox.Show(
                   "As senhas precisam ser iguais",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );

                return;
            }




            //Setters
            client.setNome(nome.Text);
            client.setSobrenome(sobrenome.Text);
            client.setDatanasc(data_nasc.Text);
            client.setGenero(genero.Text);
            client.setNacionalidade(nacionalidade.Text);
            client.setCpf(cpf.Text);
            client.setTipodedoc(tipo_documento.Text);
            client.setDoc(numero_documento.Text);
            client.setEmail(email.Text);
            client.setConfemail(confemail.Text);
            client.setSenha(senha.Text);
            client.setConfsenha(confsenha.Text);

            //Static Getters

            varemail = client.getEmail();
            varsenha = client.getSenha();
            varnome = client.getNome();
            varsobrenome = client.getSobrenome();
            vargenero = client.getGenero();
            varnacionalidade = client.getNacionaidade();
            varcpf = client.getCpf();
            vartipodedoc = client.getTipodedoc();
            vardoc = client.getDoc();
            

            
            MessageBox.Show(
                   "Dados cadastrados com sucesso",
                   "Sucesso!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
           
            this.Hide();
        }
        

    }
}
