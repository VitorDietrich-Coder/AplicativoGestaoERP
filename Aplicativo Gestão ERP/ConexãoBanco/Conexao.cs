using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplicativo_Gestão_ERP
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection(ConexaoGET.conn);

        public SqlConnection conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();

            }
            return conexao;
        }
        public SqlConnection desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();

            }
            return conexao;
        }
    }
}
