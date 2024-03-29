﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    public class ExcluirProduto
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;
        public ExcluirProduto(int codigo)
        {
            cmd.CommandText = "DELETE FROM CadProduto WHERE Id = @Id";
            cmd.Parameters.AddWithValue("Id", codigo);

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
