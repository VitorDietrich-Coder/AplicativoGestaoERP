using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public  class PesquisaProduto
    {
        public object pesquisaproduto(string cod)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexaoGET.conn))
                {
                    

                    con.Open();
                    var sqlquery = "Select * From CadProduto where Cód like '%" + cod + "' or Nome Like '%" + cod + "'";



                    using (SqlDataAdapter da = new SqlDataAdapter(sqlquery, con))
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
            { }
        }
    }
}
