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
        SqlConnection con = new SqlConnection();

        public VerificaCadastro()
        {
            con.ConnectionString = @"Data Source=LAPTOP-CE4Q030Q;Initial Catalog=GestEstoque;Integrated Security=True";
        }
        public SqlConnection conecta()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconecta()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}