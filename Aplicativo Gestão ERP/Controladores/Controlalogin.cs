using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class Controlalogin
    { 
        public bool tem;
        public String mensagem = "";
        public bool acessa(String email)
        {
            ValidaEmail login1 = new ValidaEmail();
            tem = login1.verificaemail(email);
            if (login1.mensagem.Equals(""))
            {

                this.mensagem = login1.mensagem;
            }
            return tem;

        }
        public String Cadastrar(String email)
        {
            return mensagem;

        }
    }
}

