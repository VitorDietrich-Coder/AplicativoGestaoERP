﻿using System;
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
            ImportaImagem import = new ImportaImagem(pictureBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ValidaProduto valida = new ValidaProduto();
            ControlaProduto controla = new ControlaProduto();

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

                buscaProduto.Visible = true;
                Pesquisaproduto pesquisa = new Pesquisaproduto();
                buscaProduto.dataGridView1.DataSource = pesquisa.pesquisaproduto(PesquisaProduto.Text);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        public void PreencheValores(DataGridView dataGridView1)
        {
            int rowindex = dataGridView1.CurrentRow.Index;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                BuscaProduto buscaProduto = new BuscaProduto();
                buscaProduto.Close();

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Cód"].Value.ToString());
                string name3 = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                string marca = dataGridView1.SelectedRows[0].Cells["marca"].Value.ToString();
                string UnidadeMedida = dataGridView1.SelectedRows[0].Cells["UnidadeMedida"].Value.ToString();
                string peso = dataGridView1.SelectedRows[0].Cells["Peso"].Value.ToString();
                string quantidade = dataGridView1.SelectedRows[0].Cells["Quantidade"].Value.ToString();
                string validade = dataGridView1.SelectedRows[0].Cells["Validade"].Value.ToString();
                string dataCompra = dataGridView1.SelectedRows[0].Cells["DataCompra"].Value.ToString();
                string DataVenda = dataGridView1.SelectedRows[0].Cells["DataVenda"].Value.ToString();
                string preçoCusto = dataGridView1.SelectedRows[0].Cells["PreçoCusto"].Value.ToString();
                string preçoVenda = dataGridView1.SelectedRows[0].Cells["PreçoVenda"].Value.ToString();


                label16.Text = Convert.ToString(id);
                NomeProd.Text = name3;
                Marca.Text = marca;
                comboBox1.Text = UnidadeMedida;
                Peso.Text = peso;
                Quantidade.Text = quantidade;
                Validade.Text = validade;
                DataEntrada.Text = dataCompra;
                DataSaida.Text = DataVenda;
                PreçoCusto.Text = preçoCusto;
                PreçoVenda.Text = preçoVenda;
                buscaProduto.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = buscaProduto.dataGridView1.CurrentRow.Index;
            if (buscaProduto.dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(buscaProduto.dataGridView1.SelectedRows[0].Cells["Cód"].Value.ToString());
                string nome = buscaProduto.dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                string marca = buscaProduto.dataGridView1.SelectedRows[0].Cells["marca"].Value.ToString();
                string unidadeMedida = buscaProduto.dataGridView1.SelectedRows[0].Cells["UnidadeMedida"].Value.ToString();
                string peso = buscaProduto.dataGridView1.SelectedRows[0].Cells["Peso"].Value.ToString();
                string quantidade = buscaProduto.dataGridView1.SelectedRows[0].Cells["Quantidade"].Value.ToString();
                string validade = buscaProduto.dataGridView1.SelectedRows[0].Cells["Validade"].Value.ToString();
                string dataCompra = buscaProduto.dataGridView1.SelectedRows[0].Cells["DataCompra"].Value.ToString();
                string dataVenda = buscaProduto.dataGridView1.SelectedRows[0].Cells["DataVenda"].Value.ToString();
                string precoCusto = buscaProduto.dataGridView1.SelectedRows[0].Cells["PreçoCusto"].Value.ToString();
                string precoVenda = buscaProduto.dataGridView1.SelectedRows[0].Cells["PreçoVenda"].Value.ToString();


                label16.Text = Convert.ToString(id);
                NomeProd.Text = nome;
                Marca.Text = marca;
                comboBox1.Text = unidadeMedida;
                Peso.Text = peso;
                Quantidade.Text = quantidade;
                Validade.Text = validade;
                DataEntrada.Text = dataCompra;
                DataSaida.Text = dataVenda;
                PreçoCusto.Text = precoCusto;
                PreçoVenda.Text = precoVenda;
                buscaProduto.Visible = false;
            }
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
        }
    }
}

