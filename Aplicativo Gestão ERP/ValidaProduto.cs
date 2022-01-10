using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class ValidaProduto
    {
   
            public bool tem;
            public String mensagem = "";

            SqlCommand cmd = new SqlCommand();
            VerificaCad conn = new VerificaCad();
            SqlDataReader dre;
            public bool verificacod(String Cód)
            {
                cmd.CommandText = "select * from CadProduto where Cód = @Cód";
                cmd.Parameters.AddWithValue("@Cód", Cód);

                try
                {
                    cmd.Connection = conn.conecta();
                    dre = cmd.ExecuteReader();
                    if (dre.HasRows)
                    {
                        tem = true;
                    }
                }
                catch (SqlException)
                {
                    this.mensagem = "erro com banco de dados";
                }
                return tem;
            }
        }
    
    }

