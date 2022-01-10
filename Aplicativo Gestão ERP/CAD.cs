using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class CAD
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;
        public CAD(string Nome, string Email, string Senha)
        {
         
            cmd.CommandText = "insert into CadUser (Nome, Email, Senha) values (@Nome, @Email, @Senha)";

            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Senha", Senha);

            try
            {
                cmd.Connection = conexao.conectar();    

                cmd.ExecuteNonQuery();

                conexao.desconectar();
                
                this.mensagem = "Cadastro efetuado com sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de conexao";
            
            }
        }
    }
}
