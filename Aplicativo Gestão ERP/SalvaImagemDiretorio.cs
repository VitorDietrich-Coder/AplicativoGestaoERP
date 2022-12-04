using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Gestão_ERP
{
    public class SalvaImagemDiretorio
    {
        public void teste(int id)
        {
            Form2 form2 = new Form2();
            form2.openFileDialog1.Multiselect = true;
            form2.openFileDialog1.Title = "Selecionar Fotos";
            form2.openFileDialog1.InitialDirectory = @"C:\Users\";
            //filtra para exibir somente arquivos de imagens
            form2.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            form2.openFileDialog1.CheckFileExists = true;
            form2.openFileDialog1.CheckPathExists = true;
            form2.openFileDialog1.FilterIndex = 2;
            form2.openFileDialog1.RestoreDirectory = true;
            form2.openFileDialog1.ReadOnlyChecked = true;
            form2.openFileDialog1.ShowReadOnly = true;

            DialogResult dr = form2.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in form2.openFileDialog1.FileNames)
                {
                    // cria um PictureBox
                    try
                    {
                        Image Imagem = Image.FromFile(arquivo);
                        form2.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        form2.pictureBox1.Height = 200;
                        form2.pictureBox1.Width = 200;
                        form2.pictureBox1.Image = Imagem;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem");
                    }
                }
            }//fim e evento botão
            SalvaImagemDiretorio salvaImagemDiretorio = new SalvaImagemDiretorio();
            salvaImagemDiretorio.salvaImagem(form2.openFileDialog1.FileName, id);

        }
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
