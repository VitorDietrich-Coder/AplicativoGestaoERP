using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Gestão_ERP
{
    public class Produto
    {
        private int id;
        private string nome;
        private string marca;
        private string especie;
        private float peso;
        private int quantidade;
        private string validade;
        private string dataEntrada;
        private string dataSaida;
        private float precoCusto;
        private float precoVenda;

        public Produto(int id, string nome, string marca, string especie, float peso, int quantidade, string validade, string dataEntrada, string dataSaida, float precoCusto, float precoVenda)
        {
            this.id = id;
            this.nome = nome;
            this.marca = marca;
            this.especie = especie; 
            this.peso = peso;
            this.quantidade = quantidade;
            this.validade = validade;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
            this.precoCusto = precoCusto;
            this.precoVenda = precoVenda;
        }
        public void RegistraProduto()
        {
            CadastraProduto cadastro = new CadastraProduto(nome, marca, especie, peso, quantidade, validade, dataEntrada, dataSaida, precoCusto, precoVenda);
            MessageBox.Show(cadastro.mensagem);
        }
        public void AlteraProduto()
        {
            UpdateProduto update = new UpdateProduto(id, nome, marca, especie, peso, quantidade, validade, dataEntrada, dataSaida, precoCusto, precoVenda);
            MessageBox.Show(update.mensagem);
        }
    }
}
