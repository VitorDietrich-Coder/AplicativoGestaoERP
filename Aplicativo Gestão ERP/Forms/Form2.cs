using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security;
using static System.Net.WebRequestMethods;

namespace Aplicativo_Gestão_ERP
{
    public partial class Form2 : Form
    {
        BuscaProduto buscaProduto = new BuscaProduto();


        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (label16.Text != string.Empty)
            {
                this.openFileDialog1.Multiselect = true;
                this.openFileDialog1.Title = "Selecionar Fotos";
                openFileDialog1.InitialDirectory = @"C:\Users\";
                //filtra para exibir somente arquivos de imagens
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.ReadOnlyChecked = true;
                openFileDialog1.ShowReadOnly = true;

                DialogResult dr = this.openFileDialog1.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    // Le os arquivos selecionados 
                    foreach (String arquivo in openFileDialog1.FileNames)
                    {
                        // cria um PictureBox
                        try
                        {
                            Image Imagem = Image.FromFile(arquivo);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            //para exibir as imagens em tamanho natural 
                            //descomente as linhas abaixo e comente as duas seguintes
                            //pb.Height = loadedImage.Height;
                            //pb.Width = loadedImage.Width;
                            pictureBox1.Height = 100;
                            pictureBox1.Width = 100;
                            //atribui a imagem ao PictureBox - pb
                            pictureBox1.Image = Imagem;
                            //inclui a imagem no containter flowLayoutPanel
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
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
                salvaImagemDiretorio.salvaImagem(openFileDialog1.FileName);
            }
            else
            {
                NomeProd.Text = "teste";
                MessageBox.Show("Selecione um produto para importar a imagem");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ValidaProduto valida = new ValidaProduto();
            ControlaProduto controla = new ControlaProduto();
            NomeProd.Text = "teste"; NomeProd.Text = "teste";
            if (controla.acessa(label16.Text) == false)
            {
                CadastrodeProduto cadastro = new CadastrodeProduto(NomeProd.Text, Marca.Text, comboBox1.Text, float.Parse(Peso.Text), Convert.ToInt32(Quantidade.Text), Validade.Text, DataEntrada.Text, DataSaida.Text, float.Parse(PreçoCusto.Text), float.Parse(PreçoVenda.Text));
                MessageBox.Show(cadastro.mensagem);
            }
            else
            {
                UpdateProduto update = new UpdateProduto(int.Parse(label16.Text), NomeProd.Text, Marca.Text, comboBox1.Text, float.Parse(Peso.Text), Convert.ToInt32(Quantidade.Text), Validade.Text, DataEntrada.Text, DataSaida.Text, float.Parse(PreçoCusto.Text), float.Parse(PreçoVenda.Text));
                MessageBox.Show(update.mensagem);

            }
        }
        private void Peso_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        public void PesquisaProduto_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (buscaProduto.Visible == false)
                {
                    buscaProduto.Visible = true;
                    PesquisaProduto pesquisa = new PesquisaProduto();
                    buscaProduto.dataGridView1.DataSource = pesquisa.pesquisaproduto(PesquisaProduto.Text);

                }
                else
                {
                    buscaProduto.Visible = false;
                }
            }
        }
        public void PreencheValores(List<string> lista)
        {
            NomeProd.Text = lista[0].ToString();
            label16.Text = lista[1].ToString();
            NomeProd.Text = lista[2].ToString();
            Marca.Text = lista[3].ToString();
            comboBox1.Text = lista[4].ToString();
            Peso.Text = lista[5].ToString();
            Quantidade.Text = lista[6].ToString();
            Validade.Text = lista[7].ToString();
            DataEntrada.Text = lista[8].ToString();
            DataSaida.Text = lista[9].ToString();
            PreçoCusto.Text = lista[10].ToString();
           // PreçoVenda.Text = lista[11].ToString();

            SalvaImagemDiretorio salvaImagemDiretorio = new SalvaImagemDiretorio();
       //    pictureBox1.LoadAsync(salvaImagemDiretorio.buscaImagem(int.Parse(label16.Text)));
        }
    

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
    }
    private void Form2_Load_1(object sender, EventArgs e)
    {
        MinimizeBox = false;
        MaximizeBox = false;
    }
    private void NovoProduto_Click(object sender, EventArgs e)
    {
        LimpaCampo();
    }
    private void LimpaCampo()
    {
        label16.Text = "";
        NomeProd.Text = "";
        Marca.Text = "";
        comboBox1.Text = "";
        Peso.Text = "";
        Quantidade.Text = "";
        Validade.Text = "";
        DataEntrada.Text = "";
        DataSaida.Text = "";
        PreçoCusto.Text = "";
        PreçoVenda.Text = "";

    }
    private void button4_Click(object sender, EventArgs e)
    {
        buscaProduto.Visible = false;
    }

    private void ExcluirProduto_Click(object sender, EventArgs e)
    {
        ControlaProduto controla = new ControlaProduto();

        if (controla.acessa(label16.Text) == false)
        {
            MessageBox.Show("Não é Possível Exluir esse Produto Selecionado");
        }
        else
        {
            ExcluirProduto excluir = new ExcluirProduto(int.Parse(label16.Text));
            MessageBox.Show("Produto excluido com sucesso");
            LimpaCampo();

        }
    }

    private void button3_Click_1(object sender, EventArgs e)
    {

    }
}
}

