using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprar_passagens
{
    internal class Compra_passagem
    {

        public string Codigo;
        public string Valor;
        public string Local;

        public Compra_passagem()
        {
            this.Codigo = "";
            this.Valor = "";
            this.Local = "";

        }

        public Compra_passagem(string codigo, string valor, string local)
        {
            this.Codigo = codigo;
            this.Valor = valor;
            this.Local = local;
        }
    }
}
