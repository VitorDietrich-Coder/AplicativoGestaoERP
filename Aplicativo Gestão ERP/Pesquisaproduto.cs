using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class PesquisaProduto
    {
        public object pesquisaproduto(string valor)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoGET.conn))
                {
                    conexao.Open();
                    var sqlquery = "Select * From CadProduto where Id like '%" + valor + "' or Nome Like '%" + valor + "'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlquery, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            finally
            {
            }
        }
    }
}
