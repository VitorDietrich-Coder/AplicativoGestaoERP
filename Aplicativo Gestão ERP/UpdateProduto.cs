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
            public UpdateProduto(int Cód, string Nome, string Marca, string UnidadeMedida, float Peso, int Quantidade, string Validade, string DataCompra, string DataVenda, float PreçoCusto, float PreçoVenda)
            {
            cmd.CommandText = "UPDATE CadProduto SET Nome = @Nome, Marca = @Marca, UnidadeMedida = @UnidadeMedida, Peso = @Peso, Quantidade = @Quantidade, Validade = @Validade, DataCompra = @DataCompra, DataVenda = @DataVenda, PreçoCusto = @PreçoCusto, PreçoVenda = @PreçoVenda Where Cód = @Cód";
                cmd.Parameters.AddWithValue("@Cód", Cód);
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

                    this.mensagem = "Alterado campo com sucesso efetuado com sucesso";
                }
                catch (Exception e)
                {
                    this.mensagem = "Erro de conexao";

                }
            }
        }
    }

