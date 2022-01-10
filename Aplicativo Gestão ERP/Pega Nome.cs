using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class Pega_Nome
    {
        public string Nome { get; set; }

        public string Pega_Nome2(string Email)
            {

            try
            {
               
                using (SqlConnection con = new SqlConnection(ConexaoGET.conn))
                {
                    con.Open();
                    string lista =  "";

                    SqlCommand cmd = new SqlCommand("select * from CadUser Where Email = @Email", con);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Pega_Nome c = new Pega_Nome();
                        c.Nome = dr["Nome"].ToString();

                        lista = c.Nome;
                    }
                    return lista;
                }
            }
            finally { }
            }
        }
    }

