using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzulAereas
{

    public class Cliente
    {
        private string nome;
        private string sobrenome;
        private string datanasc;
        private string genero;
        private string nacionalidade;
        private string cpf;
        private string tipodedoc;
        private string doc;
        private string email;
        private string confemail;
        private string senha;
        private string confsenha;

        public Cliente()
        {
            this.nome = "";
            this.sobrenome = "";
            this.datanasc = "";
            this.genero = "";
            this.nacionalidade = "";
            this.cpf = "";
            this.tipodedoc = "";
            this.doc = "";
            this.email = "";
            this.confemail = "";
            this.senha = "";
            this.confsenha = "";
        }

        public Cliente(string p_nome,
                       string p_sobrenome,
                       string p_datanasc,
                       string p_genero,
                       string p_nacionalidade,
                       string p_cpf,
                       string p_tipodedoc,
                       string p_doc,
                       string p_email,
                       string p_confemail,
                       string p_senha,
                       string p_confsenha)
        {
            this.nome = p_nome;
            this.sobrenome = p_sobrenome;
            this.datanasc = p_datanasc;
            this.genero = p_genero;
            this.nacionalidade = p_nacionalidade;
            this.cpf = p_cpf;
            this.tipodedoc = p_tipodedoc;
            this.doc = p_doc;
            this.email = p_email;
            this.confemail = p_confemail;
            this.senha = p_senha;
            this.confsenha = p_confsenha;
        }

        // Getters e Setters

        //Nome
        public string getNome() { return nome; }
        public void setNome(string p_nome) { this.nome = p_nome; }

        //Sobrenome
        public string getSobrenome() { return sobrenome; }
        public void setSobrenome(string p_sobrenome) { this.sobrenome = p_sobrenome; }

        //Data de nascimento
        public string getDatanasc() { return datanasc; }
        public void setDatanasc(string p_datanasc) { this.datanasc = p_datanasc; }

        //Gênero
        public string getGenero() { return genero; }
        public void setGenero(string p_genero) { this.genero = p_genero; }

        //Nacionalidade
        public string getNacionaidade() { return nacionalidade; }
        public void setNacionalidade(string p_nacionalidade) { this.nacionalidade = p_nacionalidade; }

        //Cpf
        public string getCpf() { return cpf; }
        public void setCpf(string p_cpf) { this.cpf = p_cpf; }

        //Tipo de Doc
        public string getTipodedoc() { return tipodedoc; }
        public void setTipodedoc(string p_tipodedoc) { this.tipodedoc = p_tipodedoc; }

        //Número do Documento
        public string getDoc() { return doc; }
        public void setDoc(string p_doc) { this.doc = p_doc; }

        //Email
        public string getEmail() { return email; }
        public void setEmail(string p_email) { this.email = p_email; }

        //Confirma Email
        public string getConfemail() { return confemail; }
        public void setConfemail(string p_confemail) { this.confemail = p_confemail; }

        //Senha
        public string getSenha() { return senha; }
        public void setSenha(string p_senha) { this.senha = p_senha; }

        //Confirma senha
        public string getConfsenha() { return confsenha; }
        public void setConfsenha(string p_confsenha) { this.senha = p_confsenha; }
    }



}
