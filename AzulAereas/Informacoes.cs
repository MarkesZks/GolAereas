public class Informacoes
{
    //GroupBox 1
    private string nome;
    private string sobrenome;
    private string email;
    private string telefone;

    //GroupBox 2
    private string logradouro;
    private string cep;
    private string cidade;
    private string estado;

    //GroupBox 3
    private string sobre_voce;

    //GroupBox 4
    private string vaga;

    public Informacoes()
    {
        this.nome = "";
        this.sobrenome = "";
        this.email = "";
        this.telefone = "";
        this.logradouro = "";
        this.cep = "";
        this.cidade = "";
        this.estado = "";
        this.sobre_voce = "";
        this.vaga = "";
    }

    public Informacoes(string p_nome, string p_sobrenome, string p_email, string p_telefone, string p_logradouro, string p_cep,
        string p_cidade, string p_estado, string p_sobre_voce, string p_vaga)
    {
        this.nome = p_nome;
        this.sobrenome = p_sobrenome;
        this.email = p_email;
        this.telefone = p_telefone;
        this.logradouro = p_logradouro;
        this.cep = p_cep;
        this.cidade = p_cidade;
        this.estado = p_estado;
        this.sobre_voce = p_sobre_voce;
        this.vaga = p_vaga;
    }

    //Nome
    public string getnome() { return nome; }
    public void setnome(string p_nome) { this.nome = p_nome; }

    //Sobrenome
    public string getsobrenome() { return sobrenome; }
    public void setsobrenome(string p_sobrenome) { this.sobrenome = p_sobrenome; }

    //Email
    public string getemail() { return email; }
    public void setemail(string p_email) { this.email = p_email; }

    //Telefone
    public string gettelefone() { return telefone; }
    public void settelefone(string p_telefone) { this.telefone = p_telefone; }

    //Logradouro
    public string getlogradouro() { return logradouro; }
    public void setlogradouro(string p_logradouro) { this.logradouro = p_logradouro; }

    //CEP
    public string getCEP() { return cep; }
    public void setcep(string p_cep) { this.cep = p_cep; }

    //Cidade
    public string getcidade() { return cidade; }
    public void setcidade(string p_cidade) { this.cidade = p_cidade; }

    //Estado
    public string getestado() { return estado; }
    public void setestado(string p_estado) { this.estado = p_estado; }

    //Sobre você
    public string getsobre_voce() { return sobre_voce; }
    public void setsobre_voce(string p_sobre_voce) { this.sobre_voce = p_sobre_voce; }

    //Vaga
    public string getvaga() { return vaga; }
    public void setvaga(string p_vaga) { this.vaga = p_vaga; }
}
