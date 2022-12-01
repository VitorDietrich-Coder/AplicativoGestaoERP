using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aplicativo_Gestão_ERP
{
        public class ValidaEmail
        {
            public bool tem;
            public String mensagem = "";

            SqlCommand cmd = new SqlCommand();
            VerificaCadastro conn = new VerificaCadastro();
            SqlDataReader dre;
            public bool verificaemail(String email)
            {
                cmd.CommandText = "select * from CadUser where email = @email";
                cmd.Parameters.AddWithValue("@email", email);
          

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