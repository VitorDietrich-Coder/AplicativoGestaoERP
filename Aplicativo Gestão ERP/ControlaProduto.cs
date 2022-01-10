using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    internal class ControlaProduto
    {

        public bool tem;
        public String mensagem = "";
        public bool acessa(String cod)
        {
            ValidaProduto codz = new ValidaProduto();
            tem = codz.verificacod(cod);
            if (codz.mensagem.Equals(""))
            {

                this.mensagem = codz.mensagem;

            }
            return tem;

        }
        public String Cadastrar(String email)
        {
            return mensagem;

        }

    }
}
