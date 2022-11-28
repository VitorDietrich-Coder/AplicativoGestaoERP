using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Gestão_ERP
{
    public class PreencheValores
    {
        public void preencheLabel(DataGridView dataGridView1)
        {
            int rowindex = dataGridView1.CurrentRow.Index;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["Cód"].Value.ToString();
                string nome = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                string marca = dataGridView1.SelectedRows[0].Cells["marca"].Value.ToString();
                string unidadeMedida = dataGridView1.SelectedRows[0].Cells["UnidadeMedida"].Value.ToString();
                string peso = dataGridView1.SelectedRows[0].Cells["Peso"].Value.ToString();
                string quantidade = dataGridView1.SelectedRows[0].Cells["Quantidade"].Value.ToString();
                string validade = dataGridView1.SelectedRows[0].Cells["Validade"].Value.ToString();
                string dataCompra = dataGridView1.SelectedRows[0].Cells["DataCompra"].Value.ToString();
                string dataVenda = dataGridView1.SelectedRows[0].Cells["DataVenda"].Value.ToString();
                string precoCusto = dataGridView1.SelectedRows[0].Cells["PreçoCusto"].Value.ToString();
                string precoVenda = dataGridView1.SelectedRows[0].Cells["PreçoVenda"].Value.ToString();

                List<string> teste = new List<string>();
                teste.Add(id);
                teste.Add(nome);
                teste.Add(marca);
                teste.Add(unidadeMedida);
                teste.Add(peso);
                teste.Add(quantidade);
                teste.Add(validade);
                teste.Add(dataCompra);
                teste.Add(dataVenda);
                teste.Add(precoCusto);
                teste.Add(precoVenda);

                Form2 form2 = new Form2();
                form2.PreencheValores(teste);
            }
        }

    }
}
