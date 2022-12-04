using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Security;

namespace Aplicativo_Gestão_ERP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            SalvaImagemDiretorio salvaImagemDiretorio = new SalvaImagemDiretorio();
            salvaImagemDiretorio.teste(short.Parse(Id.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ValidaProduto valida = new ValidaProduto();
            ControlaProduto controla = new ControlaProduto();

            if (controla.acessa(short.Parse(Id.Text)) == false)
            {
                if (string.IsNullOrEmpty(Nome.Text))
                {

                }
                else if (string.IsNullOrEmpty(Marca.Text))
                {
                }
                else if (string.IsNullOrEmpty(comboBox1.Text))
                {
                }
                else if (string.IsNullOrEmpty(Peso.Text))
                {
                }
                else if (string.IsNullOrEmpty(Quantidade.Text))
                {
                }
                else if (string.IsNullOrEmpty(Validade.Text))
                {
                }
                else if (string.IsNullOrEmpty(DataEntrada.Text))
                {
                }
                else if (string.IsNullOrEmpty(DataSaida.Text))
                {
                }
                else if (string.IsNullOrEmpty(PrecoCusto.Text))
                {
                }
                else if (string.IsNullOrEmpty(PrecoVenda.Text))
                {
                }
                else
                {
                    Produto produto = new Produto(short.Parse(Id.Text), Nome.Text, Marca.Text, comboBox1.Text, float.Parse(Peso.Text), short.Parse(Quantidade.Text), Validade.Text, DataEntrada.Text, DataSaida.Text, float.Parse(PrecoCusto.Text), float.Parse(PrecoVenda.Text));
                    produto.RegistraProduto();
                    Close();
                }
            }
            else
            {
                Produto produto = new Produto(short.Parse(Id.Text), Nome.Text, Marca.Text, comboBox1.Text, float.Parse(Peso.Text), short.Parse(Quantidade.Text), Validade.Text, DataEntrada.Text, DataSaida.Text, float.Parse(PrecoCusto.Text), float.Parse(PrecoVenda.Text));
                produto.AlteraProduto();
                Close();
            }
        }
        public void PesquisaProduto_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                painelPesquisa.Visible = true;
                PesquisaProduto pesquisa = new PesquisaProduto();
                dataGridView1.DataSource = pesquisa.pesquisaproduto(PesquisaProduto.Text);
            }
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
            Id.Text = "";
            Nome.Text = "";
            Marca.Text = "";
            comboBox1.Text = "";
            Peso.Text = "";
            Quantidade.Text = "";
            Validade.Text = "";
            DataEntrada.Text = "";
            DataSaida.Text = "";
            PrecoCusto.Text = "";
            PrecoVenda.Text = "";
        }

        private void ExcluirProduto_Click(object sender, EventArgs e)
        {
            ControlaProduto controla = new ControlaProduto();

            if (controla.acessa(Convert.ToInt16(Id.Text)) == false)
            {
                MessageBox.Show("Não é Possível Exluir esse Produto Selecionado");
            }
            else
            {
                ExcluirProduto excluir = new ExcluirProduto(int.Parse(Id.Text));
                MessageBox.Show("Produto excluido com sucesso");
                LimpaCampo();
            }
        }
        private void selecionar_Click(object sender, EventArgs e)
        {
            painelPesquisa.Visible = false;
            int rowindex = dataGridView1.CurrentRow.Index;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                string nome = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                string marca = dataGridView1.SelectedRows[0].Cells["marca"].Value.ToString();
                string unidadeMedida = dataGridView1.SelectedRows[0].Cells["UnidadeMedida"].Value.ToString();
                string peso = dataGridView1.SelectedRows[0].Cells["Peso"].Value.ToString();
                string quantidade = dataGridView1.SelectedRows[0].Cells["Quantidade"].Value.ToString();
                string validade = dataGridView1.SelectedRows[0].Cells["Validade"].Value.ToString();
                string dataEntrada = dataGridView1.SelectedRows[0].Cells["DataCompra"].Value.ToString();
                string dataSaida = dataGridView1.SelectedRows[0].Cells["DataVenda"].Value.ToString();
                string precoCusto = dataGridView1.SelectedRows[0].Cells["PrecoCusto"].Value.ToString();
                string precoVenda = dataGridView1.SelectedRows[0].Cells["PrecoVenda"].Value.ToString();

                Id.Text = id;
                Nome.Text = nome;
                Marca.Text = marca;
                Peso.Text = peso;
                comboBox1.Text = unidadeMedida;
                Quantidade.Text = quantidade;
                Validade.Text = validade;
                DataEntrada.Text = dataEntrada;
                DataSaida.Text = dataSaida;
                PrecoCusto.Text = precoCusto;
                PrecoVenda.Text = precoVenda;
                SalvaImagemDiretorio salvaImagemDiretorio = new SalvaImagemDiretorio();
                pictureBox1.LoadAsync(salvaImagemDiretorio.buscaImagem(int.Parse(id)));
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            painelPesquisa.Visible = false;
        }
    }
}

