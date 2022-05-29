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
            Login login = new Login();
            tem = login.verificalogin(email, senha);
            if (login.mensagem.Equals(""))
            {

                this.mensagem = login.mensagem;

            }
            return tem;

        }
        public String Cadastrar(String email, String Senha)
        {
            return mensagem;

             }
           }
        }