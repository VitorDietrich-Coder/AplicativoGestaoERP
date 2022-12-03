using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class CadastraProduto
    {
   
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;
        public CadastraProduto(string Nome, string Marca, string UnidadeMedida, float Peso, int Quantidade, string Validade, string DataCompra, string DataVenda, float PreçoCusto, float PreçoVenda)
        {
            cmd.CommandText = "insert into CadProduto (Nome, Marca, UnidadeMedida, Peso, Quantidade, Validade, DataCompra, DataVenda, PreçoCusto, PreçoVenda) values (@Nome, @Marca, @UnidadeMedida, @Peso, @Quantidade, @Validade, @DataCompra, @DataVenda, @PreçoCusto, @PreçoVenda)";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@UnidadeMedida", UnidadeMedida);
            cmd.Parameters.AddWithValue("@Peso", Peso);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@Validade", Validade);
            cmd.Parameters.AddWithValue("@DataCompra", DataCompra);
            cmd.Parameters.AddWithValue("@DataVenda", DataVenda);
            cmd.Parameters.AddWithValue("@PreçoCusto", PreçoCusto);
            cmd.Parameters.AddWithValue("@PreçoVenda", PreçoVenda);

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

