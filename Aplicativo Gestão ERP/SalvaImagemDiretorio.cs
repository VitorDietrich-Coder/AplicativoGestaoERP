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
        private string strCaminho;
        private string strNovaPasta;
        private string strTitulo;

        public void salvaImagem(string filename)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "update CadProduto set CaminhoImagem = @CAMINHO";
                cmd.Parameters.AddWithValue("CAMINHO", filename);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Imagem cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
