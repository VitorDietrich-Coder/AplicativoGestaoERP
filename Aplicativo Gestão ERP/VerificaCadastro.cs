using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Aplicativo_Gestão_ERP
{
    public class VerificaCadastro
    {
        SqlConnection conexao = new SqlConnection(ConexaoGET.conn);
        public SqlConnection conecta()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        public void desconecta()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}