using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class Conectionlogin
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
        public void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}

