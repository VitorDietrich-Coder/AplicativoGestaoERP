using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Gestão_ERP
{
    public class SalvaImagemDiretorio
    {

        public void salvaImagem(string filename, int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "update CadProduto set CaminhoImagem = @CAMINHO where Id = @Id";
                cmd.Parameters.AddWithValue("CAMINHO", filename);
                cmd.Parameters.AddWithValue("Id", codigo);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Imagem cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string buscaImagem(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            var caminho = string.Empty;
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "Select CaminhoImagem from CadProduto where Id = @Id";
                cmd.Parameters.AddWithValue("Id", codigo);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    caminho = dr["CaminhoImagem"].ToString().Replace(@"\\", @"\");

                }
                return caminho;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return caminho;
        }
    }
}
