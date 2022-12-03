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
        public string mensagem = "";
        public bool acessa(int codigo)
        {
            ValidaProduto validaproduto = new ValidaProduto();
            tem = validaproduto.verificacod(codigo);
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
