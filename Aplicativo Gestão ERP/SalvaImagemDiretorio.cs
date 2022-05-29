using Grpc.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    internal class SalvaImagemDiretorio
    {
        private string strCaminho;
        private string strNovaPasta;
        private string strTitulo;

        private void salvaImagem()
        {
            if (Directory.Exists(strTitulo))
            {
                //pegando caminho dentro do projeto
               // strCaminho = Server.MapPath("/Fotos");
      
                strNovaPasta = Path.Combine(strCaminho, strTitulo);

                //criando diretorio
                Directory.CreateDirectory(@"" + strNovaPasta + "");
            }


        }
    }
}
