using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplicativo_Gestão_ERP
{
        public  class Conexao
        {
        SqlConnection Conn = new SqlConnection(ConexaoGET.conn);

        public SqlConnection conectar()
        {
            if (Conn.State == System.Data.ConnectionState.Closed)
            { 
                Conn.Open();
            
            }
            return Conn;
        }
        public SqlConnection desconectar()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();

            }
            return Conn;
        }
    }
}
