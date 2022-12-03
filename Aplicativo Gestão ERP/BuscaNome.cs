using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class BuscaNome
    {
        public string Nome { get; set; }
        public string BuscaNomes(string email)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoGET.conn))
                {
                    conexao.Open();
                    string lista = "";

                    SqlCommand cmd = new SqlCommand("select * from CadUser Where Email = @Email", conexao);
                    cmd.Parameters.AddWithValue("Email", email);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        BuscaNome c = new BuscaNome();
                        c.Nome = dr["Nome"].ToString();

                        lista = c.Nome;
                    }
                    return lista;
                }
            }
            finally
            {
            }
        }
    }
}

