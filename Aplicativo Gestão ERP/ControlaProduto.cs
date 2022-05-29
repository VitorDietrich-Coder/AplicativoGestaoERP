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
            ValidaProduto validaproduto = new ValidaProduto();
            tem = validaproduto.verificacod(cod);
            if (validaproduto.mensagem.Equals(""))
            {
                this.mensagem = validaproduto.mensagem;
            }
            return tem;
        }
        public String Cadastrar(String email)
        {
            return mensagem;

        }

    }
}
