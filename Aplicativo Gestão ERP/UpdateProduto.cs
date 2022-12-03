using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class UpdateProduto
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;
        public UpdateProduto(int codigo, string nome, string marca, string unidadeMedida, float peso, int quantidade, string validade, string dataCompra, string dataVenda, float precoCusto, float precoVenda)
        {
            cmd.CommandText = "UPDATE CadProduto SET Nome = @Nome, Marca = @Marca, UnidadeMedida = @UnidadeMedida, Peso = @Peso, Quantidade = @Quantidade, Validade = @Validade, DataCompra = @DataCompra, DataVenda = @DataVenda, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", codigo);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Marca", marca);
            cmd.Parameters.AddWithValue("@UnidadeMedida", unidadeMedida);
            cmd.Parameters.AddWithValue("@Peso", peso);
            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
            cmd.Parameters.AddWithValue("@Validade", validade);
            cmd.Parameters.AddWithValue("@DataCompra", dataCompra);
            cmd.Parameters.AddWithValue("@DataVenda", dataVenda);
            cmd.Parameters.AddWithValue("@PrecoCusto", precoCusto);
            cmd.Parameters.AddWithValue("@PrecoVenda", precoVenda);
            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.mensagem = "Alterado campo com sucesso efetuado com sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de conexao";

            }
        }
    }
}

