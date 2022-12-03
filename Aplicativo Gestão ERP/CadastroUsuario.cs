using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class CadastroUsuario
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;
        public CadastroUsuario(string nome, string email, string senha)
        {

            cmd.CommandText = "Insert into CadUser (Nome, Email, Senha) values (@Nome, @Email, @Senha)";
            cmd.Parameters.AddWithValue("Nome", nome);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("Senha", senha);

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
