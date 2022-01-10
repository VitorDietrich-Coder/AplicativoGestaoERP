using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
  public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String email, String senha)
        {
            Login login1 = new Login();
            tem = login1.verificalogin(email, senha);
            if (login1.mensagem.Equals(""))
            {

                this.mensagem = login1.mensagem;

            }
            return tem;

        }
        public String Cadastrar(String email, String Senha)
        {
            return mensagem;

             }
           }
        }